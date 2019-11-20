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
            sqlcon.Close();
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            return dtbl;
        }
    }
}
