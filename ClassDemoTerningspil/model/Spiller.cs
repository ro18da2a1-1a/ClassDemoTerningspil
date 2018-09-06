﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoTerningspil.model
{
    class Spiller
    {
        // attribute
        public String Navn { get; set; }


        // metode
        public void VilSpille(int indsats)
        {
            Spil spil = new Spil();
            spil.Indsats(indsats);
            int gevinst = spil.Spille();

            Console.WriteLine("Spiller med navn " + Navn + " fik en gevinst på " + gevinst + " kroner");
        }
    }
}
