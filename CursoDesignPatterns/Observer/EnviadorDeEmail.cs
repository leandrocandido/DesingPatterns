using System;
namespace CursoDesignPatterns
{
    public class EnviadorDeEmail : AcaoAposGerarNota
    {

        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Envia nota por email");
        }


        public EnviadorDeEmail()
        {
        }
    }
}
