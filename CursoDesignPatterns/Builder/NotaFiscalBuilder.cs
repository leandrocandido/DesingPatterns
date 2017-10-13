using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }

        private double valorToral;
        private double impostos;

        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

        public NotaFiscalBuilder ParaEmpresa(string razaosocial)
        {
            this.RazaoSocial = razaosocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(string obs)
        {
            this.Observacoes = obs;
            return this;
        }

        public NotaFiscalBuilder NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorToral += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, valorToral, impostos, todosItens, Observacoes);
        }

        public NotaFiscalBuilder()
        {
        }
    }
}
