using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Finance_Tracker_1
{

    public partial class Budget : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        private int userId;

        public Budget(int userId)
        {
            alamat = "server=localhost; database=finance_tracker; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            this.userId = userId;
            InitializeComponent();
        }

        private void labeladdtransaction_Click(object sender, EventArgs e)
        {
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSetBudget_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAmount.Text != "" && dateStartBudget.Text != "" && cbCategory.Text != "")
                {
                    int amount;
                    int actualAmount = 0;
                    if (!int.TryParse(txtAmount.Text, out amount))
                    {
                        MessageBox.Show("Amount must be a valid integer.");
                        return;
                    }

                    query = "INSERT INTO budgets (user_id, name, category, type, amount,aktual, start_date, end_date, description) " +
                            "VALUES (@userId, @name, @category, @type, @amount, @actual, @startDate, @endDate, @description)";

                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@userId", this.userId);
                    perintah.Parameters.AddWithValue("@name", txtName.Text);
                    perintah.Parameters.AddWithValue("@category", cbCategory.Text);
                    perintah.Parameters.AddWithValue("@type", cbType.Text);
                    perintah.Parameters.AddWithValue("@amount", amount);
                    perintah.Parameters.AddWithValue("@actual", actualAmount);
                    perintah.Parameters.AddWithValue("@startDate", dateStartBudget.Value.ToString("yyyy-MM-dd"));
                    perintah.Parameters.AddWithValue("@endDate", dateEndBudget.Value.ToString("yyyy-MM-dd"));
                    perintah.Parameters.AddWithValue("@description", richDesc1.Text);


                    koneksi.Open();
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        dateStartBudget.Value = DateTime.Now;
                        dateEndBudget.Value = DateTime.Now;
                        txtAmount.Text = "";
                        txtName.Text = "";
                        richDesc1.Text = "";
                        txtCategory.Text = "";
                        MessageBox.Show("Insert budget sukses ...");
                        Budget_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal insert budget . . . ");
                    }
                }
                else
                {
                    MessageBox.Show("Data Tidak lengkap !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateStartBudget_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richDesc1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Budget_Load(object sender, EventArgs e)
        {

        }
    }
}
