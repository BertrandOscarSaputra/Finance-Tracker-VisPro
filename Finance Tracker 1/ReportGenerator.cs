using MySql.Data.MySqlClient;
using System.Data;

public class ReportGenerator
{
    private string connectionString = "server=localhost; database=finance_tracker; username=root; password=;";

    public DataSet GetUserTransactions(int userId)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            string query = "SELECT TransactionID, Date, Amount, Description FROM transactions WHERE user_id = @userId";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userId", userId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataSet transactionData = new DataSet();
                adapter.Fill(transactionData, "Transactions");
                return transactionData;
            }
        }
    }
    
}