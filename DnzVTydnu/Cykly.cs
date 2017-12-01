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
                Console.WriteLine("Cyklus cislo {0}", i);
            }
            while (i < 4);
        }

        // naj4astej3ie pouzivany
        public static void CyklusFor()
        {
            //            for (int i = 0; i < 6; i=i+2)  najbeznejsie
            // aj takto sa to da
            //            for (int i = 0; i < 6; i+=2)  najbeznejsie

            // cyklus dvomi premennymi
            for (int i = 0, j = 10; i <= j; i++, j--)
            {
                //                Console.Write("Som v cykle na cisle: ");
                Console.Write("Som v cykle na cisle i{0}, j{1}:", i, j);
                Console.WriteLine(i);
            }

        }
        public static void CyklusFor2(int opakovanie)
        {
            for (int i = 0; i < opakovanie; i++)
            {
                Console.WriteLine("Som v cykle na cisle {0}", i);
            }

            Console.WriteLine("Pocet opakovani bol {0}", opakovanie);
        }
        public static void CyklusForContinue()
        {
            for (int i = 0; i <= 10; i++)
            {
                int zbytek = i % 2;
                if (zbytek != 0)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
        }
        public static void HodnotVsReference()
        {
            int hodnota1 = 6;


            int hodnota2 = hodnota1;
//zvysime hodnotu o 1
            hodnota2++;

            Console.WriteLine(hodnota1);
            Console.WriteLine(hodnota2);

            Auto auto1 = new Auto();
            auto1.Barva = "cervena";

            Auto auto2 = auto1;
            auto2.Barva = "cerna";
//tuto bunku nezamenil, lebo to nie je hodnotova premenna

            Console.WriteLine(auto1.Barva);
            Console.WriteLine(auto2.Barva);

        }
        public static void PrebarviAuto(Auto auto)
        {
            auto.Barva = "bila";

        }
        public static void ZvysOJednicku(ref int a)
        {
            a++;

        }

// vrati aj navratovu hodnotu funkcia
        public static bool Otoc(bool vstup, out int b)
        {
            b = 10;
            return !vstup;
        }


    }
    


}
