using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoTerningspil.model
{
    class Terning
    {
        // til at lave tilfældige tal
        private static Random rand = new Random((int)DateTime.Now.Millisecond);


        // attribut
        public int Værdi { get; set; }

        // metoder
        public void Slå()
        {
            Værdi = rand.Next(1, 7);
        }

        public int AflæsVærdi()
        {
            return Værdi;
        }



    }
}
