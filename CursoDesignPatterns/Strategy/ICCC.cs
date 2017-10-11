using System;
namespace CursoDesignPatterns
{
    public class ICCC : Imposto
    {
        public ICCC()
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000 )
            {
                return orcamento.Valor * 0.05;
            }
            else if (orcamento.Valor > 1000 && orcamento.Valor < 3000 )
            {
                return orcamento.Valor * 0.07;
            }
            else if (orcamento.Valor > 3000)
            {
                return (( orcamento.Valor * 0.08 ) + 30 );
            }
            else
            {
                return orcamento.Valor;
            }
        }
    }
}
