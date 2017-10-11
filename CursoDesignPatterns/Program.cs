using System;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento reforma = new Orcamento(500);
            Console.WriteLine(reforma.Valor);

            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Aprova();
            reforma.AplicaDescontoExtra();
            Console.WriteLine(reforma.Valor);

            reforma.Finaliza();


            Console.ReadKey();
        }

        private void PadraoStrategy()
        {
			 Imposto iss = new ISS();
             Imposto icms = new ICMS();
             Orcamento orcamento = new Orcamento(500);
             CalculadorImposto calc = new CalculadorImposto();
             calc.RealizaCalculo(orcamento , iss);
             calc.RealizaCalculo(orcamento, icms);
		}

        private void ChainOfresponsability()
        {
			CalculadorDescontos calculador = new CalculadorDescontos();
			Orcamento orcamento = new Orcamento(500);

			orcamento.AdicionaItens(new Item("caneta", 250));
			orcamento.AdicionaItens(new Item("lapis", 250));
			orcamento.AdicionaItens(new Item("gealdeira", 250));
			orcamento.AdicionaItens(new Item("micro", 250));
			orcamento.AdicionaItens(new Item("xbox", 250));
			orcamento.AdicionaItens(new Item("fogao", 250));

			double desconto = calculador.Calcula(orcamento);

			Console.WriteLine(desconto);
        }

    }
}
