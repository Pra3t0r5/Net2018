using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Datos
{
    public class Adapter
    {
        protected SqlConnection connString;

        protected void OpenConnection()
        {
            SqlConnection conn = new SqlConnection(
                new SqlConnectionStringBuilder()
                {
                    DataSource = "Localhost",
                    InitialCatalog = "NetGenerica",
                    UserID = "net",
                    Password = "net"

                }.ConnectionString);
            connString = conn;
            conn.Open();
        } 
        
        protected void CloseConnection()
        {
            connString.Close();
        }
       

    }
}
