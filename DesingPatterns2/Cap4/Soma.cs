using System;
namespace DesingPatterns2.Cap4
{
    public class Soma : IExpressao
    {
        private IExpressao esquerda;
        private IExpressao direita;

        public int Avalia()
        {
            int valorEsquerda = esquerda.Avalia();
            int valorDireita = direita.Avalia();
            return valorEsquerda + valorDireita;
        }

        public Soma(IExpressao esquerda , IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }
    }
}
