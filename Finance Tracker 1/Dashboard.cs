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
        public Dashboard(int userId)
        {
            
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button_addtransaction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddTransaction addtransaction = new AddTransaction();
            addtransaction.Show();
            
        }

        private void button_transactionhistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHistory history = new FrmHistory();
            history.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Budget budget = new Budget();
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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
