using System;
namespace CursoDesignPatterns
{
    public class IKCV : TemplateDeImpostoCondicional
    {

		public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && ItemMaiorQue100Reais(orcamento);
           
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

		public override double MinimaTaxacao(Orcamento orcamento)
		{
            return orcamento.Valor * 0.06;
		}

        private bool ItemMaiorQue100Reais(Orcamento orcamento)
        {
            foreach( Item item in orcamento.Itens )
            {
                if (item.Valor > 100 )
                {
                    return true;
                }
            }

            return false;
        }
    }
}
