using System;
namespace CursoDesignPatterns
{
    public class Reprovado : EstadoDeUmOrcamento
    {
        public Reprovado()
        {
        }

        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado/finalizados não recebem desconto extra");
        }

		public void Aprova(Orcamento orcamento)
		{
			throw new Exception("Orcamento ja esta em aprovado");
		}

		public void Finaliza(Orcamento orcamento)
		{
			throw new Exception("Orcamento esta em aprovacao e nao pode ser reprovado agora");
		}

		public void Reprova(Orcamento orcamento)
		{
			throw new Exception("Orcamento em aprovacao nao pode ir reprovado agora");

		}
    }
}
