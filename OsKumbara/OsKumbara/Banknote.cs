using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsKumbara
{
    public class Banknote
    {
        public string BanknotAdi { get; set; }
        public double BanknotDegeri { get; set; }
        public double En { get; set; }
        public double Boy { get; set; }
        public double Yukseklik { get; set; }
        public override string ToString()
        {
            return BanknotAdi;
        }
    }
}
