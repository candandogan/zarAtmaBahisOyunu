using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarAtmaBahisOyunu
{
    class zar
    {
        public int Deger { get; set; }

        public void At()
        {
            Random random = new Random();
            Deger = random.Next(1, 7);
        }
    }
}
