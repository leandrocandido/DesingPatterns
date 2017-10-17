using System;
namespace DesingPatterns2.Cap4
{
    public class Numero : IExpressao
    {
        private int numero;

        public int Avalia()
        {
            return this.numero;
        }

        public Numero(int numero)
        {
            this.numero = numero;
        }
    }
}
