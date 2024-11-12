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

        private void FrmPay_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = "SELECT * FROM budgets WHERE user_id = @userId";
                perintah = new MySqlCommand(query, koneksi);
                perintah.Parameters.AddWithValue("@userId", userId);

                adapter = new MySqlDataAdapter(perintah);
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 75;
                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].Width = 75;
                dataGridView1.Columns[1].HeaderText = "User";
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[2].HeaderText = "Name";
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[3].HeaderText = "Category";
                dataGridView1.Columns[4].Width = 200;
                dataGridView1.Columns[4].HeaderText = "Amount";
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[5].HeaderText = "Start_Date";
                dataGridView1.Columns[6].Width = 100;
                dataGridView1.Columns[6].HeaderText = "End_Date";
                dataGridView1.Columns[7].Width = 200;
                dataGridView1.Columns[7].HeaderText = "description";



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
                int budgetAmount = Convert.ToInt32(selectedRow.Cells["amount"].Value);

                int payAmount;
                if (!int.TryParse(txtPay.Text, out payAmount) || payAmount <= 0)
                {
                    MessageBox.Show("Enter a valid payment amount.");
                    return;
                }

                if (payAmount > budgetAmount)
                {
                    MessageBox.Show("Payment amount exceeds the budget amount.");
                    return;
                }

                try
                {
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

                    koneksi.Open();

                    query = "UPDATE budgets SET amount = amount - @payAmount WHERE budget_id = @budgetId";
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@payAmount", payAmount);
                    perintah.Parameters.AddWithValue("@budgetId", budgetId);
                    perintah.ExecuteNonQuery();

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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtName.Text.Trim();
            string searchIdText = txtID.Text.Trim();

            try
            {
                koneksi.Open();

                if (!string.IsNullOrEmpty(searchIdText) && int.TryParse(searchIdText, out int searchId))
                {
                    query = "SELECT * FROM budgets WHERE user_id = @userId AND budget_id = @searchId";
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@userId", userId);
                    perintah.Parameters.AddWithValue("@searchId", searchId);
                }
                else if (!string.IsNullOrEmpty(searchText))
                {
                    query = "SELECT * FROM budgets WHERE user_id = @userId AND name LIKE @searchText";
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@userId", userId);
                    perintah.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                }
                else
                {
                    MessageBox.Show("Enter either a Budget ID or Name to search.");
                    koneksi.Close();
                    return;
                }

                adapter = new MySqlDataAdapter(perintah);
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView1.DataSource = ds.Tables[0];

                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[0].Selected = true;
                }
                else
                {
                    MessageBox.Show("No matching budget found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
