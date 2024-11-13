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

        private int userId;

        public AddTransaction(int userId)
        {
            alamat = "server=localhost; database=finance_tracker; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            this.userId = userId;
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
                    int amount;
                    if (!int.TryParse(txtAmount.Text, out amount))
                    {
                        MessageBox.Show("Amount must be a valid integer.");
                        return;
                    }

                    
                    query = "SELECT balance FROM users WHERE user_id = @userId";
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@userId", this.userId);
                    koneksi.Open();
                    object result = perintah.ExecuteScalar();
                    koneksi.Close();

                    if (result == null)
                    {
                        MessageBox.Show("User not found.");
                        return;
                    }

                    int currentBalance = Convert.ToInt32(result);

                    
                    if (txtType.Text.ToLower() == "income")
                    {
                        currentBalance += amount;
                    }
                    else if (txtType.Text.ToLower() == "expense")
                    {
                        currentBalance -= amount;
                    }
                    else
                    {
                        MessageBox.Show("Invalid transaction type. Use 'income' or 'expense'.");
                        return;
                    }

                    query = "INSERT INTO transactions (user_id, type, amount, category, date, description) VALUES (@userId, @type, @amount, @category, @date, @description)";
                    perintah = new MySqlCommand(query, koneksi);
                    perintah.Parameters.AddWithValue("@userId", this.userId);
                    perintah.Parameters.AddWithValue("@type", txtType.Text);
                    perintah.Parameters.AddWithValue("@amount", amount);
                    perintah.Parameters.AddWithValue("@category", txtCategory.Text);
                    perintah.Parameters.AddWithValue("@date", dateTransaction.Value.ToString("yyyy-MM-dd"));
                    perintah.Parameters.AddWithValue("@description",richDesc.Text);


                    koneksi.Open();
                    int res = perintah.ExecuteNonQuery();
                    koneksi.Close();

                   
                    if (res == 1)
                    {
                        query = "UPDATE users SET balance = @balance WHERE user_id = @userId";
                        perintah = new MySqlCommand(query, koneksi);
                        perintah.Parameters.AddWithValue("@balance", currentBalance);
                        perintah.Parameters.AddWithValue("@userId", this.userId);

                        koneksi.Open();
                        perintah.ExecuteNonQuery();
                        koneksi.Close();

                        txtType.Text = "";
                        txtCategory.Text = "";
                        txtAmount.Text = "";
                        dateTransaction.Value = DateTime.Now;
                        richDesc.Text = "";
                        MessageBox.Show("Transaction Successful, balance updated.");
                       
                        AddTransaction_Load(null, null);

                    }
                    else
                    {
                        MessageBox.Show("Failed to insert transaction.");
                    }
                }
                else
                {
                    MessageBox.Show("Incomplete data!");
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

        private void richDesc_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void richDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}