using System;
namespace CursoDesignPatterns
{
    public class EnviadorDeSMS : AcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Envia por sms");
        }

        public EnviadorDeSMS()
        {
        }
    }
}
