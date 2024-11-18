using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Finance_Tracker_1
{
    public partial class FrmAdmin : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public FrmAdmin()
        {
            alamat = "server=localhost; database=finance_tracker; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPasswordAdmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
    
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("select * from users where username = '{0}'", txtUserAdmin.Text);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                adapter.Fill(ds);
                koneksi.Close();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    string sandi = ds.Tables[0].Rows[0]["password"].ToString();
                    if (sandi == txtPasswordAdmin.Text)
                    {
                        FrmAdminDashboard admindash = new FrmAdminDashboard();
                        admindash.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Anda salah input password");
                    }
                }
                else
                {
                    MessageBox.Show("Username tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
