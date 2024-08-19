using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPrintRafa19_Agosto.Clases
{
    public class Aleatorio
    {
        public static int NumeroAleatorio(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public int Valor { get; set; }
        public int Posicion { get; set; }
        public long Id { get; set; }
        public Aleatorio() { }

    }
}
