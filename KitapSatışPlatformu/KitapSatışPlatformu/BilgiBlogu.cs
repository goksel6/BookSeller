using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapSatışPlatformu
{
   public class BilgiBlogu
    {
       //public String yazarAdi;
       public String kitapAdi;
       public String yayınevi;
        public String yazarAdi;
       public  int fiyati;


        public override string ToString()
        {
            return this.kitapAdi+"/" + this.yazarAdi+"/" + this.yayınevi + "/" + this.fiyati.ToString();
        }
    }
}
