using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DesingPatterns2.Cap1;
using DesingPatterns2.Cap2;
using DesingPatterns2.Cap3;

namespace DesingPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }

        static void Memento()
        {
			Historico historico = new Historico();

			Contrato contrato = new Contrato(DateTime.Now, "Mauricio", TipoContrato.Novo);
			historico.Adiciona(contrato.SalvaEstado());

			contrato.Avanca();
			historico.Adiciona(contrato.SalvaEstado());

			contrato.Avanca();
			historico.Adiciona(contrato.SalvaEstado());

			contrato.Avanca();
			historico.Adiciona(contrato.SalvaEstado());
        }

        static void Factory()
        {
			IDbConnection conexao = new ConnectionFactory().GetConnection();

			IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * from tabela";

		}

        static void Flyweight()
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
        }

    }
}
