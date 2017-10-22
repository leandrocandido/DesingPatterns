using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using DesingPatterns2.Cap1;
using DesingPatterns2.Cap2;
using DesingPatterns2.Cap3;
using DesingPatterns2.Cap4;
using DesingPatterns2.Cap5;
using DesingPatterns2.Cap6;

namespace DesingPatterns2
{
    class Program
    {
        static void Main(string[] args)
        {

            IMensagem mensagem = new MensagemCliente("leandro");
            IEnviador enviador = new EnviaPorEmail();
            mensagem.Enviador = enviador;
            mensagem.Envia();
            
			Console.ReadKey();	
        }

		static void InterpreterVisitor()
		{
			IExpressao esquerda = new Soma(new Soma(new Numero(1), new Numero(100)), new Numero(10));
			IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
			IExpressao soma = new Soma(esquerda, direita);
            Console.WriteLine(soma.Avalia());
			ImpressoraVisitor impressora = new ImpressoraVisitor();
			soma.Aceita(impressora);
		}


        static void Interpreter()
        {
			//IExpressao esquerda = new Soma( new Soma(new Numero(1) , new Numero(100)), new Numero(10));
            //IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
            //IExpressao soma = new Soma(esquerda, direita);
            //Console.WriteLine(soma.Avalia());
   
            Expression soma = Expression.Add(Expression.Constant(10), Expression.Constant(100));
			Func<int> funcao = Expression.Lambda<Func<int>>(soma).Compile();
			Console.WriteLine(funcao());

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
