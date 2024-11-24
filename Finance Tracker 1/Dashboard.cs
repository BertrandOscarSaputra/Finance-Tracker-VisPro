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

    public partial class Dashboard : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;

        private int currentUserId;
        public Dashboard(int userId)
        {
            alamat = "server=localhost; database=finance_tracker; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            this.currentUserId = userId;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button_addtransaction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTransaction addtransaction = new AddTransaction(currentUserId);
            addtransaction.Show();
            
        }

        private void button_transactionhistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHistory history = new FrmHistory(currentUserId);
            history.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Budget budget = new Budget(currentUserId);
            budget.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLogin form = new FrmLogin();
            form.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void labeluser_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                query = "SELECT username, balance FROM users WHERE user_id = @userId";
                perintah = new MySqlCommand(query, koneksi);
                perintah.Parameters.AddWithValue("@userId", currentUserId);

                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                koneksi.Close();
                DataTable balanceTable = ds.Tables[0].Clone();
                DataTable nameTable = ds.Tables[0].Clone();

                balanceTable.Columns.Remove("username");
                balanceTable.ImportRow(ds.Tables[0].Rows[0]);

                nameTable.Columns.Remove("balance");
                nameTable.ImportRow(ds.Tables[0].Rows[0]);

                dataGridView2.DataSource = balanceTable;
                dataGridView2.Columns["balance"].Width = 50;
                dataGridView2.RowHeadersVisible = false;
                dataGridView2.ColumnHeadersVisible = false;

                dataGridViewName.DataSource = nameTable;
                dataGridViewName.Columns["username"].Width = 90;
                dataGridViewName.RowHeadersVisible = false;
                dataGridViewName.ColumnHeadersVisible = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewName_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Dashboard_Load(null, null);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPay pay = new FrmPay(currentUserId);
            pay.Show();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ExHistory exHistory = new ExHistory(currentUserId);
            exHistory.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEdit edit = new FrmEdit(currentUserId);
            edit.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
