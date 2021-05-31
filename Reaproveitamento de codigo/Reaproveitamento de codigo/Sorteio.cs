using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaproveitamento_de_codigo
{
    class Sorteio
    {
        public static void SorteioNum(int num1, int num2)
        {
            Random numAleatorio = new Random();
            int a = numAleatorio.Next(num1, num2);
        }
    }
}
