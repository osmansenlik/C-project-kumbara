using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsKumbara
{
    public class Coin
    {
        public string BozukParaAdi { get; set; }
        public double BozukParaDegeri { get; set; }
        public double Yaricap { get; set; }
        public double Kalinlik { get; set; }
        public override string ToString()
        {
            return BozukParaAdi;
        }
    }
}
