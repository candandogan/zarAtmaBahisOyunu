using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zarAtmaBahisOyunu
{
    class Oyun
    {
        public Oyuncu BirinciOyuncu { get; set; }
        public Oyuncu İkinciOyuncu { get; set; }
        

        public void IlkOyuncuZarAt()
        {
            BirinciOyuncu.Oyna();
        }

        public void IkıncıOyuncuZarAt()
        {
            İkinciOyuncu.Oyna();
        }

       
        
    }
}
