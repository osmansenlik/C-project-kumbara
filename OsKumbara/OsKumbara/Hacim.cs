using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsKumbara
{
    public class Hacim
    {
        public string Para { get; set; }
        public double ToplamHacim { get; set; }
        public double ShakeHacim { get; set; }
        public Banknote SecilenBanknot { get; set; }
        public Coin SecilenBozukluk { get; set; }

        public void BanknoteHacimHesapla()
        {
            ToplamHacim = 0;
            ToplamHacim = (SecilenBanknot.En) * (SecilenBanknot.Boy) * (SecilenBanknot.Yukseklik);
            ShakeHacim = 0;
            ShakeHacim = (SecilenBanknot.En) * (SecilenBanknot.Boy) * (SecilenBanknot.Yukseklik) * (1.25);
        }
        public void CoinHacimHesapla()
        {
            double pi =3.14;
            ToplamHacim = 0;
            ToplamHacim = (pi) * (SecilenBozukluk.Yaricap) * (SecilenBozukluk.Yaricap) * (SecilenBozukluk.Kalinlik);
        }
    }
}
