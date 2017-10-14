using System;
namespace CursoDesignPatterns
{
    public class NotaFiscalDao : AcaoAposGerarNota
    {

        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Salva no banco de dados");
        }

        public NotaFiscalDao()
        {
        }
    }
}
