using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDemoTerningspil.model;

namespace ClassDemoTerningspil
{
    class Program
    {
        static void Main(string[] args)
        {
            Spiller spiller = new Spiller();
            spiller.Navn = "Peter";

            for (int i = 0; i < 10; i++)
            {


                spiller.VilSpille(i+1);
            }

            // blot for at nå at se resultat
            Console.ReadLine();
        }
    }
}
