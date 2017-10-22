﻿using System;
namespace DesingPatterns2.Cap6
{
    public class MensagemAdministrativa : IMensagem
    {
        private string nome;

        public MensagemAdministrativa(string nome)
        {
            this.nome = nome;
        }

        public IEnviador Enviador { get ; set; }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o administrador {0}", this.nome);
        }
    }
}
