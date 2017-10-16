using System;
using System.Collections.Generic;

namespace DesingPatterns2.Cap2
{
    public class Piano
    {
        public void Toca(IList<INota> musica)
        {
            try
            {
				foreach (var nota in musica)
				{
					Console.Beep(nota.Frequencia, 300);
				}    
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public Piano()
        {
        }
    }
}
