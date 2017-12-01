using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnyVTydnu
{
    class DnyVTydnu
    {
        public static void VypisDenTydne(string cisloDne)
        {
            int denTydne = int.Parse(cisloDne);

            if (denTydne > 0 && denTydne < 8)
            { 
                // toto je spravny vstup

                switch (denTydne)
            {
                case 0:
                case 7:
                     Console.WriteLine("Dnesni den je Nedele");
                     break;
                case 1:
                    Console.WriteLine("Dnesni den je Pondeli");
                    break;
                case 2:
                    Console.WriteLine("Dnesni den je Utery");
                    break;
                case 3:
                    Console.WriteLine("Dnesni den je Streda");
                    break;
                case 4:
                    Console.WriteLine("Dnesni den je Ctvrtek");
                    break;
                case 5:
                    Console.WriteLine("Dnesni den je Patek");
                    break;
                case 6:
                    Console.WriteLine("Dnesni den je Sobota");
                    break;
                default:
                    Console.WriteLine("Dnesni den je 30.02., nebo si se spletl?");
                    break;
            }

                else
                {
                    //chybny vstup
                    Console.WriteLine{"Spatny vstup"};
                }

            }
        }
        public static void VypisDenTydne(string cisloDne, bool nedeleJePrvni)
        {
            int denTydne = int.Parse(cisloDne);

            if(ZkontrolujVstup (denTydne))
            { 
                if (nedeleJePrvni)
                 {
                        DenTydne--;
                 }
                 VypisDenTydne(denTydne.ToString());
            }
            else
            {
                Console.WriteLine ("Spatny vstup");
            }
        }
    }

    public static bool ZkontrolujVstup(int cisloDne)
    {
        if (cisloDne >=1 && cisloDne <= 7)
        {
            Console.WriteLine("spravny vstup");
            return true;
        }
        else
        {
            Console.WriteLine("nespravny vstup, napis od 1 do 7");
            return false;
        }

        // najkratsi zapis return(cisloDne >=1 && cisloDne <= 7);

    }
}
