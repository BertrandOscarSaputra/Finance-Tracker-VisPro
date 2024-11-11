using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    
    public partial class AddTransaction : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        
        public AddTransaction()
        {
            alamat = "server=localhost; database=finance_tracker; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            
            InitializeComponent();
        }

        private void AddTransaction_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtType.Text != "" && txtCategory.Text != "" && txtAmount.Text != "")
                {
                    int userId = 1;
                    query = string.Format("INSERT into transactions  values ('{0}','{1}','{2}','{3}','{4}','{5}');",null,userId, txtType.Text, txtAmount, txtCategory.Text, dateTransaction.Value.ToString("yyyy-MM-dd"));


                    koneksi.Open();
                    perintah = new MySqlCommand(query, koneksi);
                    adapter = new MySqlDataAdapter(perintah);
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();
                    if (res == 1)
                    {
                        MessageBox.Show("Transaksi Suksess ...");
                        AddTransaction_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Gagal insert transaksi . . . ");
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

        

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}