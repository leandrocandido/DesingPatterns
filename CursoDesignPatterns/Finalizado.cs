using System;
namespace CursoDesignPatterns
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public Finalizado()
        {
        }

		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.02);
		}

		public void Aprova(Orcamento orcamento)
		{
			throw new Exception("orcamento ja esta finalizado");
		}

		public void Finaliza(Orcamento orcamento)
		{
			throw new Exception("orcamento ja esta finalizado");
		}

		public void Reprova(Orcamento orcamento)
		{
			throw new Exception("orcamento ja esta finalizado");

		}
    }
}
