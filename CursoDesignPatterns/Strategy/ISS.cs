using System;
namespace CursoDesignPatterns
{
    public class ISS : Imposto
    {
        public ISS()
        {
        }

        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

    }
}
