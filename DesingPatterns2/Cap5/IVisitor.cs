using System;
using DesingPatterns2.Cap4;

namespace DesingPatterns2.Cap5
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao soma);
        void ImprimeNumero(Numero soma);
    }
}
