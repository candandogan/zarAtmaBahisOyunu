using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarAtmaBahisOyunu
{
    class Oyuncu
    {
        public string Ad { get; set; }

        public double toplamButce { get; set; }

        
        public zar OyuncununZari { get; set; }
        public double bahisMiktari { get; set; }

        public void Oyna()
        {
            OyuncununZari.At();
        }

        public Oyuncu()
        {

        }

        public Oyuncu (string Ad)
        {
            this.Ad = Ad;
        }
    }
}
