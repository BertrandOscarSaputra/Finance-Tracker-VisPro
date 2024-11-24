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
using MySql.Data;

namespace Finance_Tracker_1
{
    public partial class ExHistory : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        private int userId;
        public ExHistory(int userId)
        {
            alamat = "server=localhost; database=finance_tracker; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            this.userId = userId;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ExHistory_Load(object sender, EventArgs e)
        {
            koneksi.Open();
            query = "SELECT Amount, Category, Date, Description FROM transactions WHERE type = 'expense' AND user_id = @userId";
            perintah = new MySqlCommand(query, koneksi);
            perintah.Parameters.AddWithValue("@userId", userId);

            adapter = new MySqlDataAdapter(perintah);
            ds.Clear();
            adapter.Fill(ds);
            koneksi.Close();
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[0].HeaderText = "Amount";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[1].HeaderText = "Category";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[2].HeaderText = "Date";
            dataGridView1.Columns[3].Width = 280;
            dataGridView1.Columns[3].HeaderText = "Description";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
