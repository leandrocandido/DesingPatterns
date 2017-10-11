using System;
namespace CursoDesignPatterns
{
    public class ICMS : Imposto
    {
        public ICMS()
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.3;
        }
    }
}
