using System;
using System.Data;
using System.Data.SqlClient;

namespace DesingPatterns2.Cap1
{
    public class ConnectionFactory
    {

        public IDbConnection GetConnection()
        {
			IDbConnection conexao = new SqlConnection();
			conexao.ConnectionString = "User Id=root;Password=;Server=localhost;Database=meubanco";
			conexao.Open();
            return conexao;
		}

        public ConnectionFactory()
        {
        }
    }
}
