using System;
using System.Collections.Generic;

namespace DesingPatterns2.Cap2
{
    public class NotasMusicais
    {
        private static IDictionary<string, INota> notas = new Dictionary<string, INota>(){
            {"do",new Do()},
            {"re",new Re()},
            {"mi",new Mi()},
            {"fa",new Fa()},
            {"sol",new Sol()},
            {"la",new La()},
            {"Si",new Si()}
        };

        public INota Pega(string nome)
        {
            return notas[nome];
        }

        public NotasMusicais()
        {
        }
    }
}
