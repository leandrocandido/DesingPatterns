using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            PadraoBuilder();

            Console.ReadKey();
        }

        private static void PadraoBuilder()
        {
          /*  criador.AdicionaAcao(new EnviadorDeEmail());
            criador.AdicionaAcao(new NotaFiscalDao());
            criador.AdicionaAcao(new EnviadorDeSMS());
*/
            IList<AcaoAposGerarNota> listaAcoes = new List<AcaoAposGerarNota>();
            listaAcoes.Add(new EnviadorDeEmail());
            listaAcoes.Add(new NotaFiscalDao());
            listaAcoes.Add(new EnviadorDeSMS());
            NotaFiscalBuilder criador = new NotaFiscalBuilder(listaAcoes);
			
            //Fluent Interface e method chaining
			criador
			.ParaEmpresa("Caelum ensino e inovacao")
			.ComCnpj("876.908.6776/0001-45")
			.ComItem(new ItemDaNota("item 1", 100))
			.ComItem(new ItemDaNota("item 2", 200))
			.NaDataAtual()
			.ComObservacoes("uma observacao qualquer");

			NotaFiscal nf = criador.Constroi();
			Console.WriteLine(nf.Valorbruto);
			Console.WriteLine(nf.DataEmissao);
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

        private void PadraoState()
        {
			Orcamento reforma = new Orcamento(500);
			Console.WriteLine(reforma.Valor);

			reforma.AplicaDescontoExtra();
			Console.WriteLine(reforma.Valor);

			reforma.Aprova();
			reforma.AplicaDescontoExtra();
			Console.WriteLine(reforma.Valor);

            reforma.Finaliza();

		}

    }
}
