using System;
namespace DesingPatterns2.Cap4
{
    public class Subtracao : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

		public int Avalia()
		{
			int valorEsquerda = esquerda.Avalia();
			int valorDireita = direita.Avalia();
			return valorEsquerda - valorDireita;
		}

        public Subtracao(IExpressao esquerda , IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }
    }
}
