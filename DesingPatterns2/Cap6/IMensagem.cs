using System;
namespace DesingPatterns2.Cap6
{
    public interface IMensagem
    {
        IEnviador Enviador { get; set; }

        void Envia();
        string Formata();
    }
}
