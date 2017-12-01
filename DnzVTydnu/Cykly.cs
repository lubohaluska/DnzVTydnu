using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnyVTydnu
{
    class Cykly
    {
        public static void CyklusWhile()
        {
            int i = 0;

            while (i < 4)
            {

                i++;
                Console.WriteLine("Ahoj");
            }
        }

        public static void DoWhile()
        {
            int i = 0;
            do
            {
                i++;
                Console.WriteLine("Ahoj");
            }
            while (i < 4);
        }
            
            
            
        
    }
}
