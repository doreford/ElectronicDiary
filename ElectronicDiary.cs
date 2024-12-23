using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace ElectronicDiary
{
    internal class ElectronicDiary
    {
        SqlConnection SqlConnection = new SqlConnection(@"Data Source=DESKTOP-STTUHEI;Initial Catalog=EJournalDB;Integrated Security=true;");
        static string DbConnect = "server = localhos; user=root; password=root;database=db";
        static SqlConnection SqlConnection2 = new SqlConnection(DbConnect);
        static public SqlCommand sqlCommand;
      

        public void openConnection()
        {
            if (SqlConnection.State == System.Data.ConnectionState.Closed)
            {
                SqlConnection.Close();
            }

        }

        public SqlConnection getConnection()
        {
            return SqlConnection;
        }
    }
}
