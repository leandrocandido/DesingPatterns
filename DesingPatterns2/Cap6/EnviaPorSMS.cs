using System;
namespace DesingPatterns2.Cap6
{
    public class EnviaPorSMS : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("enviando a mensagem por sms");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
