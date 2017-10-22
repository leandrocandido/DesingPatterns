using System;
using DesingPatterns2.Cap5;

namespace DesingPatterns2.Cap4
{
    public class Numero : IExpressao
    {
        public int Valor { get; private set; }

        public int Avalia()
        {
            return this.Valor;
        }

		public void Aceita(IVisitor impressora)
		{
			impressora.ImprimeNumero(this);
		}

        public Numero(int numero)
        {
            this.Valor = numero;
        }

		
    }
}
