using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnyVTydnu
{
    class Pole
    {
        public int[] VnitrniPole = new int[4] { 10, 4, 5, 6 };
        public void VypisPole()
        {
            // VnitrniPole.Length
            // VnitrniPole[2]
            // cyklus pre vypis


            for (int i = 0; i < VnitrniPole.Length; i++)
            {

                Console.WriteLine("Prvok cislo {0} a jeho hodnota {1}", i, VnitrniPole[i]);

            }
        }

// naplnenie buniek matice pola
        public void NaplPole()
        {
            Random r = new Random();
            for (int i = 0; i < VnitrniPole.Length; i++)
            {

            VnitrniPole[i] = r.Next(100);

            }
        }

    }


}
