using System.Data.SqlClient;
using System.Data;

namespace NewDatabaseProject
{
    class Filler
    {
        public static DataTable DataTableFiller(string query)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-BSO196BK\SQLEXPRESS;Initial Catalog=CarDealership;Integrated Security=True");

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);           
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            sda.Dispose();

            return dtbl;
        }

        public static void InserterDeleter(string query)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-BSO196BK\SQLEXPRESS;Initial Catalog=CarDealership;Integrated Security=True");

            sqlcon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            sda.InsertCommand = new SqlCommand(query, sqlcon);
            sda.InsertCommand.ExecuteNonQuery(); 
            
            sqlcon.Close();
            sda.Dispose();
        }
    }
}
