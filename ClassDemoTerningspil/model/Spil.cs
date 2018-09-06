using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoTerningspil.model
{
    class Spil
    {
        private Terning terning1 = new Terning();
        private Terning terning2 = new Terning();

        private int indsats = 0;

        public void Indsats(int kroner)
        {
            indsats = kroner;
        }

        public int Spille()
        {
            terning1.Slå();
            terning2.Slå();

            int værdi1 = terning1.AflæsVærdi();
            int værdi2 = terning2.AflæsVærdi();

            int sum = værdi1 + værdi2;

            if (sum == 7)
            {
                //return 2; 
                return indsats * 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
