
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnyVTydnu
{
    class Program
    {
        static void Main(string[] args)
        {
//            Cykly.CyklusWhile();
//            Cykly.DoWhile();
//            Cykly.CyklusFor();
//            Cykly.CyklusFor2(10);
//            Cykly.CyklusForContinue();
            Cykly.HodnotVsReference();

            //           Auto autoPuvodni = new Auto();
            //            autoPuvodni.Barva = "cerna";

            //            Cykly.PrebarviAuto(autoPuvodni);
            //            Console.WriteLine(autoPuvodni.Barva);

            //            int aPuvodni = 10;
            //            Cykly.ZvysOJednicku(ref aPuvodni);

            //            Console.WriteLine(aPuvodni);

            Pole p = new Pole();
            p.NaplPole();
            p.VypisPole();


            Console.ReadLine();
        }
    }
}
