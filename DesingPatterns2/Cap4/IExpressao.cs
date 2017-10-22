using System;
using DesingPatterns2.Cap5;

namespace DesingPatterns2.Cap4
{
    public interface IExpressao
    {
        int Avalia();

        void Aceita(IVisitor impressora);
    }
}
