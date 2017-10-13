using System;
namespace CursoDesignPatterns
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        public Aprovado()
        {
        }

		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
		}

		public void Aprova(Orcamento orcamento)
		{
			throw new Exception("Orcamento ja esta em aprovado");
		}

		public void Finaliza(Orcamento orcamento)
		{
            orcamento.EstadoAtual = new Finalizado();
		}

		public void Reprova(Orcamento orcamento)
		{
			throw new Exception("Orcamento em aprovacao nao pode ir reprovado agora");

		}
    }
}
