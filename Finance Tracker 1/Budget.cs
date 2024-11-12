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
                if (txtAmount.Text != "" && dateStartBudget.Text != "" && txtCategory.Text != "")
                {
                    int amount;
                    if (!int.TryParse(txtAmount.Text, out amount))
                    {
                        MessageBox.Show("Amount must be a valid integer.");
                        return;
                    }

                    query = string.Format("INSERT into budgets  values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}');", null, this.userId,txtName.Text, txtCat.Text, amount, dateStartBudget.Value.ToString("yyyy-MM-dd"), dateEndBudget.Value.ToString("yyyy-MM-dd"), richDesc1.Text);


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
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

        private void Budget_Load(object sender, EventArgs e)
        {

        }
    }
}
