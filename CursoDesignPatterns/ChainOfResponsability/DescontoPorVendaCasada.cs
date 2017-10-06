using System;
namespace CursoDesignPatterns
{
    public class DescontoPorVendaCasada : Desconto
    {



		public double Desconta(Orcamento orcamento)
        {
            if (Existe("Lapis", orcamento) && Existe("Lapis", orcamento))
            {
                return orcamento.Valor * 0.05;
            }
            else
                return Proximo.Desconta(orcamento);
        }

		private bool Existe(String nomeDoItem, Orcamento orcamento)
		{
			foreach (Item item in orcamento.Itens)
			{
				if (item.Nome.Equals(nomeDoItem))
					return true;
			}
			return false;
		}

		public Desconto Proximo { get; set; }

    }
}
