using System;
namespace CursoDesignPatterns
{
    public class ICMS : Imposto
    {
        public ICMS()
        {
        }

        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.3;
        }
    }
}
