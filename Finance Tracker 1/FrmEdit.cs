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
    public partial class FrmEdit : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        private int userId;
        public FrmEdit(int userId)
        {
            alamat = "server=localhost; database=finance_tracker; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            this.userId = userId;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FrmEdit_Load(null, null);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtID.Text = "";
            txtCategory.Text = "";
            txtAmount.Text = "";
            richDesc.Text = "";
            dateStartBudget.Value = DateTime.Now;
            dateEndBudget.Value = DateTime.Now;
            FrmEdit_Load(null,null);
        }

        private void dateEndBudget_ValueChanged(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text != "")
                {
                    if (MessageBox.Show("Anda Yakin Menghapus Data Ini ??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        query = string.Format("Delete from users where user_id = '{0}'", txtID.Text);
                        ds.Clear();
                        koneksi.Open();
                        perintah = new MySqlCommand(query, koneksi);
                        adapter = new MySqlDataAdapter(perintah);
                        int res = perintah.ExecuteNonQuery();
                        koneksi.Close();
                        if (res == 1)
                        {
                            MessageBox.Show("Delete Data Suksess ...");
                        }
                        else
                        {
                            MessageBox.Show("Gagal Delete data");
                        }
                    }
                    FrmEdit_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Data Yang Anda Pilih Tidak Ada !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = "SELECT budget_id,name,category,amount,start_date,end_date,description FROM budgets WHERE user_id = @userId";
                perintah = new MySqlCommand(query, koneksi);
                perintah.Parameters.AddWithValue("@userId", userId);

                adapter = new MySqlDataAdapter(perintah);
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 75;
                dataGridView1.Columns[0].HeaderText = "Id";
                dataGridView1.Columns[1].Width = 156;
                dataGridView1.Columns[1].HeaderText = "Name";
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[2].HeaderText = "Category";
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[3].HeaderText = "Amount";
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[4].HeaderText = "Start_Date";
                dataGridView1.Columns[5].Width = 100;
                dataGridView1.Columns[5].HeaderText = "End_Date";
                dataGridView1.Columns[6].Width = 235;
                dataGridView1.Columns[6].HeaderText = "Description";



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
