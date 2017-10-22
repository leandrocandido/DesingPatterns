using System;
namespace DesingPatterns2.Cap6
{
    public class EnviaPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("enviando a mensagem por email");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
