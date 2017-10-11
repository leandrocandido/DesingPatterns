using System;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }

        public EstadoDeUmOrcamento EstadoAtual { get; set; }

        public void AplicaDescontoExtra()
        {
            this.EstadoAtual.AplicaDescontoExtra(this);
        }

        public void AdicionaItens (Item item)
        {
            this.Itens.Add(item);
        }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Itens = new List<Item>();
            this.EstadoAtual = new EmAprovacao();
        }

        public void Aprova()
        {
            this.EstadoAtual = new Aprovado();
        }

		public void Reprova()
		{
            this.EstadoAtual = new Reprovado();
		}

		public void Finaliza()
		{
			this.EstadoAtual = new Finalizado();
		}

    }
}
