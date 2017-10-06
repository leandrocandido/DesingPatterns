using System;
namespace CursoDesignPatterns
{
    public class CalculadorImposto
    {
        public CalculadorImposto()
        {
        }

        public void RealizaCalculo(Orcamento orcamento , Imposto imposto)
        {
            var val = imposto.Calcula(orcamento);
            Console.WriteLine(val);
        }

    }
}
