using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci
{
    public class Siparis
    {
        public Menu Menu { get; set; }
        public Boyut Boyut { get; set; }
        public List<Sos> Soslar { get; set; } = new List<Sos>();
        public byte Adet { get; set; }
        public decimal Tutar { get; private set; }


        public decimal Hesapla()
        {
            Tutar = 0;
            foreach (Sos sos in Soslar)
                Tutar += sos.Fiyat;

            if (Boyut == Boyut.Küçük)
                Tutar += Menu.Fiyat * Adet;
            else if (Boyut == Boyut.Orta)
                Tutar += Menu.Fiyat * 1.1m * Adet;
            else if (Boyut == Boyut.Büyük)
                Tutar += Menu.Fiyat * 1.25m * Adet;
            return Tutar;
        }

        public override string ToString()
        {
            string txt = $"{Menu.Ad} Menü x {Adet}, {Boyut}";

            if (Soslar.Count > 0)
                txt += $" + {string.Join(", ", Soslar)}";

            txt += $" = {Hesapla():n2} ₺";
            return txt;
        }
    }
}
