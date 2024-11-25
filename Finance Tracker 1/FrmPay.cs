using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Finance_Tracker_1
{
    public partial class FrmPay : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        private int userId;
        public FrmPay(int userId)
        {
            alamat = "server=localhost; database=finance_tracker; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
            this.userId = userId;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void PopulateDifferenceColumn()
        {
            // Add the 'Difference' column if it doesn't exist
            if (!dataGridView1.Columns.Contains("Difference"))
            {
                DataGridViewTextBoxColumn differenceColumn = new DataGridViewTextBoxColumn();
                differenceColumn.Name = "Difference";
                differenceColumn.HeaderText = "Selisih";
                differenceColumn.Width = 100;
                dataGridView1.Columns.Add(differenceColumn);
                differenceColumn.DisplayIndex = dataGridView1.Columns["aktual"].DisplayIndex + 1;
            }

            // Populate the 'Difference' column
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["amount"].Value != DBNull.Value && row.Cells["aktual"].Value != DBNull.Value)
                {
                    int budgetAmount = Convert.ToInt32(row.Cells["amount"].Value);
                    int actualAmount = Convert.ToInt32(row.Cells["aktual"].Value);
                    int difference = budgetAmount - actualAmount;
                    row.Cells["Difference"].Value = difference;
                }
            }
        }
        private void FrmPay_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = "SELECT budget_id,name,category,type,amount,aktual,start_date,end_date,description FROM budgets WHERE user_id = @userId";
                perintah = new MySqlCommand(query, koneksi);
                perintah.Parameters.AddWithValue("@userId", userId);

                adapter = new MySqlDataAdapter(perintah);
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Name";
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[2].HeaderText = "Category";
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[3].HeaderText = "Type";
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Amount";
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[5].HeaderText = "Aktual";
                dataGridView1.Columns[6].Width = 75;
                dataGridView1.Columns[6].HeaderText = "Start_Date";
                dataGridView1.Columns[7].Width = 75;
                dataGridView1.Columns[7].HeaderText = "End_Date";
                dataGridView1.Columns[8].Width = 167;
                dataGridView1.Columns[8].HeaderText = "Description";

                // Add the Difference column if it doesn't exist
                PopulateDifferenceColumn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPay_Load(null,null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int budgetId = Convert.ToInt32(selectedRow.Cells["budget_id"].Value);

                int payAmount;
                if (!int.TryParse(txtPay.Text, out payAmount) || payAmount <= 0)
                {
                    MessageBox.Show("Enter a valid payment amount.");
                    return;
                }

                try
                {
                    // Get the current balance
                    koneksi.Open();
                    query = "SELECT balance FROM users WHERE user_id = @userId";
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@userId", userId);
                    int currentBalance = Convert.ToInt32(perintah.ExecuteScalar());
                    koneksi.Close();

                    if (payAmount > currentBalance)
                    {
                        MessageBox.Show("Insufficient balance to complete the payment.");
                        return;
                    }

                    // Get the current actual amount for the selected budget
                    koneksi.Open();
                    query = "SELECT aktual FROM budgets WHERE budget_id = @budgetId";
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@budgetId", budgetId);
                    int currentAktual = Convert.ToInt32(perintah.ExecuteScalar());
                    koneksi.Close();

                    // Update the actual amount for the selected budget
                    koneksi.Open();
                    query = "UPDATE budgets SET aktual = @newAktual WHERE budget_id = @budgetId";
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@newAktual", currentAktual + payAmount);
                    perintah.Parameters.AddWithValue("@budgetId", budgetId);
                    perintah.ExecuteNonQuery();

                    // Deduct the payment amount from the user's balance
                    query = "UPDATE users SET balance = balance - @payAmount WHERE user_id = @userId";
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@payAmount", payAmount);
                    perintah.Parameters.AddWithValue("@userId", userId);
                    perintah.ExecuteNonQuery();

                    koneksi.Close();

                    MessageBox.Show("Payment successful. Budget and balance updated.");
                    FrmPay_Load(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a budget to pay.");
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtID.Text = "";
            txtPay.Text = "";
            FrmPay_Load(null, null);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();

               
                query = "DELETE FROM budgets WHERE amount = 0 AND user_id = @userId";
                perintah = new MySqlCommand(query, koneksi);
                perintah.Parameters.AddWithValue("@userId", userId);

                
                int rowsAffected = perintah.ExecuteNonQuery();
                koneksi.Close();

                
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Budgets with 0 amount have been deleted.");
                    FrmPay_Load(null, null); 
                }
                else
                {
                    MessageBox.Show("No budgets with 0 amount found to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtName.Text.Trim();
            string searchIdText = txtID.Text.Trim();

            // Check if either Budget ID or Name is provided
            if (string.IsNullOrEmpty(searchIdText) && string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Enter either a Budget ID or Name to search.");
                return;
            }

            try
            {
                koneksi.Open();

                if (!string.IsNullOrEmpty(searchIdText) && int.TryParse(searchIdText, out int searchId))
                {
                    query = "SELECT budget_id, name, category, type, amount, aktual, start_date, end_date, description FROM budgets WHERE user_id = @userId AND budget_id = @searchId";
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@userId", userId);
                    perintah.Parameters.AddWithValue("@searchId", searchId);
                }
                else if (!string.IsNullOrEmpty(searchText))
                {
                    query = "SELECT budget_id, name, category, type, amount, aktual, start_date, end_date, description FROM budgets WHERE user_id = @userId AND name LIKE @searchText";
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@userId", userId);
                    perintah.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                }
                else
                {
                    MessageBox.Show("Enter either a valid Budget ID or Name to search.");
                    koneksi.Close();
                    return;
                }

                adapter = new MySqlDataAdapter(perintah);
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();

                dataGridView1.DataSource = ds.Tables[0];

                // Restore column formatting and widths (same as in FrmPay_Load)
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].Width = 100;
                dataGridView1.Columns[1].HeaderText = "Name";
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[2].HeaderText = "Category";
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[3].HeaderText = "Type";
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Amount";
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[5].HeaderText = "Aktual";
                dataGridView1.Columns[6].Width = 75;
                dataGridView1.Columns[6].HeaderText = "Start_Date";
                dataGridView1.Columns[7].Width = 75;
                dataGridView1.Columns[7].HeaderText = "End_Date";
                dataGridView1.Columns[8].Width = 167;
                dataGridView1.Columns[8].HeaderText = "Description";

                // Remove any unwanted columns like user_id if it's not needed in the grid
                if (dataGridView1.Columns.Contains("user_id"))
                {
                    dataGridView1.Columns["user_id"].Visible = false;
                }

                // Add or update the Difference column
                PopulateDifferenceColumn();

                // Check if any rows were found and update the text boxes
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
                    DataGridViewRow selectedRow = dataGridView1.Rows[0];
                    txtID.Text = selectedRow.Cells["budget_id"].Value.ToString();
                    txtName.Text = selectedRow.Cells["name"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("No matching budget found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (koneksi.State == ConnectionState.Open)
                {
                    koneksi.Close();
                }
            }
        }


    }
}
