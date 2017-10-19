using System;
using DesingPatterns2.Cap5;

namespace DesingPatterns2.Cap4
{
    public class Subtracao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

		public int Avalia()
		{
			int valorEsquerda = Esquerda.Avalia();
			int valorDireita = Direita.Avalia();
			return valorEsquerda - valorDireita;
		}

        public Subtracao(IExpressao esquerda , IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

		public void Aceita(ImpressoraVisitor impressora)
		{
            impressora.ImprimeSubtracao(this);
		}
    }
}
