using System;
using System.Collections.Generic;

namespace DesingPatterns2.Cap7
{
    public class FilaDeTrabalho
    {
        private IList<IComando> comandos = new List<IComando>();


        public void Adiciona(IComando comando)
        {
            this.comandos.Add(comando);
        }

        public void Processa()
        {
            foreach(IComando com in comandos)
            {
                com.Executa();
            }
        }

        public FilaDeTrabalho()
        {
        }
    }
}
