using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaUrbanaDesktop.Repositories
{    
    public class DbConnection : IDisposable
    {
        private readonly IDbConnection connection;
        public DbConnection()
        {
            connection = new SqlConnection("Server=DESKTOP-RH54F6I\\MSSQLSERVER2;Database=fazenda_urb;Trusted_Connection=True;");
        }
        public IDbConnection GetConnection()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            return connection;
        }
        
        public void Dispose()
        {
            connection?.Dispose();
        }
    }
}
