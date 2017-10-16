using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DesingPatterns2.Cap1;
using DesingPatterns2.Cap2;

namespace DesingPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            NotasMusicais notas = new NotasMusicais();

            IList<INota> musica = new List<INota>()
            {
                notas.Pega("do"),
                notas.Pega("re"),
                notas.Pega("mi"),
                notas.Pega("fa"),
                notas.Pega("fa"),
                notas.Pega("fa")
            };

            Piano piano = new Piano();
            piano.Toca(musica);

            Console.ReadKey();

        }

        static void Factory()
        {
			IDbConnection conexao = new ConnectionFactory().GetConnection();

			IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tabela";

		}
    }
}
