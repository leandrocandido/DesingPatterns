using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
    public class NotaFiscal
    {

		public string RazaoSocial { get; set; }
		public string Cnpj { get; set; }
		public DateTime DataEmissao { get; set; }
		public double Valorbruto { get; set; }
		public double Impostos { get; set; }
		public IList<ItemDaNota> Itens { get; set; }
		public string Observacoes { get; set; }


		 

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataEmissa, double valorbruto, double impostos, IList<ItemDaNota> itens, string observacoes)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataEmissao = dataEmissa;
            this.Valorbruto = valorbruto;
            this.Impostos = impostos;
            this.Itens = itens;
            this.Observacoes = observacoes;

		}
    }
}
