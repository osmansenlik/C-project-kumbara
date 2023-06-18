using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OsKumbara
{
    public partial class Form1 : Form
    {
        double toplamTutar = 0;
        double toplamHacim = 0;
        double shakeHacim = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public static List<Kumbara> Degerler = new List<Kumbara>();
        public static List<Kumbara> ElimizdekiDegerler = new List<Kumbara>();
        public static List<Banknote> banknotes = new List<Banknote>()
        {
            new Banknote{BanknotAdi = "5 Lira", BanknotDegeri = 5,En= 130, Boy=64 ,Yukseklik= 0.25},
            new Banknote{BanknotAdi = "10 Lira", BanknotDegeri = 10,En= 136, Boy=64 ,Yukseklik= 0.25},
            new Banknote{BanknotAdi = "20 Lira", BanknotDegeri = 20,En= 142, Boy=68 ,Yukseklik= 0.25},
            new Banknote{BanknotAdi = "50 Lira", BanknotDegeri = 50,En= 148, Boy= 68,Yukseklik= 0.25},
            new Banknote{BanknotAdi = "100 Lira", BanknotDegeri = 100,En= 154, Boy= 72,Yukseklik= 0.25},
            new Banknote{BanknotAdi = "200 Lira", BanknotDegeri = 200,En= 160, Boy= 72,Yukseklik= 0.25}
        };
        public static List<Coin> coins = new List<Coin>()
        {
            new Coin{BozukParaAdi = "1 Kuruş", BozukParaDegeri = 0.01,Yaricap=8.25 ,Kalinlik=1.35},
            new Coin{BozukParaAdi = "5 Kuruş", BozukParaDegeri = 0.05,Yaricap=8.75 ,Kalinlik=1.65},
            new Coin{BozukParaAdi = "10 Kuruş", BozukParaDegeri = 0.1,Yaricap=9.25 ,Kalinlik=1.65},
            new Coin{BozukParaAdi = "25 Kuruş", BozukParaDegeri = 0.25,Yaricap=10.25 ,Kalinlik=1.65},
            new Coin{BozukParaAdi = "50 Kuruş", BozukParaDegeri = 0.5,Yaricap=11.925 ,Kalinlik=1.9},
            new Coin{BozukParaAdi = "1 Lira", BozukParaDegeri = 1,Yaricap=13.075 ,Kalinlik=1.9}
        };
        public static List<Hacim> hacim = new List<Hacim>()
        {
            new Hacim{Para="1 Kuruş"},
            new Hacim{Para="5 Kuruş"},
            new Hacim{Para="10 Kuruş" },
            new Hacim{Para="25 Kuruş"},
            new Hacim{Para="50 Kuruş" },
            new Hacim{Para="1 Lira"},
            new Hacim{Para="5 Lira"},
            new Hacim{Para="10 Lira"},
            new Hacim{Para="20 Lira"},
            new Hacim{Para="50 Lira"},
            new Hacim{Para="100 Lira"},
            new Hacim{Para="200 Lira"},
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Banknote item in banknotes)
            {
                cmbBanknote.Items.Add(item);
            }
            foreach (Coin item in coins)
            {
                cmbCoin.Items.Add(item);
            }
            cmbBanknote.SelectedIndex = -1;
            cmbCoin.SelectedIndex = -1;
            if (cmbCoin.SelectedIndex == -1 && cmbBanknote.SelectedIndex == -1)
            {
                btnEkle.Enabled = false;
                cboxKatla.Enabled = false;
                btnBreak.Enabled = false;
                btnShake.Enabled = false;
            }
        }
        private double TotalPara()
        {
            toplamTutar = 0;
            for (int i = 0; i < Degerler.Count; i++)
            {
                Kumbara gelen = Degerler[i];
                toplamTutar += gelen.ToplamPara;
            }
            return toplamTutar;
        }
        private double TotalHacim()
        {
            toplamHacim = 0;
            for (int i = 0; i < Degerler.Count; i++)
            {
                Kumbara gelen = Degerler[i];
                toplamHacim += gelen.ToplamHacim;
            }
            return toplamHacim;
        }
        private double ShakeHacim()
        {
            shakeHacim = 0;
            for (int i = 0; i < Degerler.Count; i++)
            {
                Kumbara gelen = Degerler[i];
                shakeHacim += gelen.ShakeHacim;
            }
            return shakeHacim;
        }
        private void Temizle()
        {
            cmbBanknote.SelectedIndex = -1;
            cmbCoin.SelectedIndex = -1;
            cmbBanknote.Enabled = true;
            cmbCoin.Enabled = true;
            cboxKatla.Enabled = false;
        }

        int clickCount = 0;
        double elimizdekitoplam = 0;
        private void btnBreak_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount < 3)
            {
                btnEkle.Enabled = false;
                btnBreak.Enabled = true;
                btnShake.Enabled = false;
                elimizdekitoplam += toplamTutar;
                Degerler.Clear();
                if (clickCount == 2)
                {
                    btnEkle.Enabled = false;
                    btnBreak.Enabled = false;
                    btnShake.Enabled = false;
                    cboxKatla.Enabled = false;
                    cmbBanknote.Enabled = false;
                    cmbCoin.Enabled = false;
                    MessageBox.Show("Kumbara İkinci Kez Kırılmıştır. Tekrar Kullanılamaz. Elimizdeki Toplam Miktar: " + elimizdekitoplam + " TL'dir." );
                    btnTemizle.Enabled = false;
                }
                btnBreak.Enabled = false;
            }
            lblMevcutPara.Text = elimizdekitoplam.ToString() + " TL";
        }
        Random rnd = new Random();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Hacim hacimHesaplama = new Hacim();
            Kumbara ekleme = new Kumbara();
            hacimHesaplama.SecilenBanknot = (Banknote)cmbBanknote.SelectedItem;
            hacimHesaplama.SecilenBozukluk = (Coin)cmbCoin.SelectedItem;
            btnBreak.Enabled = true;
            if (cmbBanknote.SelectedIndex != -1 && cmbCoin.SelectedIndex == -1)
            {
                btnShake.Enabled = true;
                cboxKatla.Enabled = true;
                if (cboxKatla.Checked)
                {
                    hacimHesaplama.BanknoteHacimHesapla();
                    ekleme.ToplamPara += hacimHesaplama.SecilenBanknot.BanknotDegeri;
                    cmbBanknote.SelectedIndex = -1;
                    cboxKatla.Checked = false;
                    Temizle();
                }
                else MessageBox.Show("Kağıt Parayı Atamabilmeniz İçin Katlamanız Gerekmektedir.");
            }
            else if (cmbCoin.SelectedIndex != -1 && cmbBanknote.SelectedIndex == -1)
            {
                hacimHesaplama.CoinHacimHesapla();
                ekleme.ToplamPara += hacimHesaplama.SecilenBozukluk.BozukParaDegeri;
                cmbCoin.SelectedIndex = -1;
                Temizle();
            }
            ekleme.ShakeHacim += hacimHesaplama.ShakeHacim;
            hacimHesaplama.ToplamHacim += ((hacimHesaplama.ToplamHacim) * rnd.Next(25, 75)) / (100);
            ekleme.ToplamHacim += hacimHesaplama.ToplamHacim;
            Degerler.Add(ekleme);

            toplamHacim = TotalHacim();
            double Volume = 8000;
            if (toplamHacim > Volume)
            {
                MessageBox.Show("Kumbara Hacmi Doldu, Artık Para Atamazsınız.");
                btnEkle.Enabled = false;
            }
            else
            {
                toplamTutar = TotalPara();
            }
            ElimizdekiDegerler.Add(ekleme);
        }
        private void btnShake_Click(object sender, EventArgs e)
        {
            ShakeHacim();
            toplamHacim = shakeHacim;
            btnShake.Enabled = false;
        }
        private void cmbBanknote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBanknote.SelectedIndex != -1 && cmbCoin.SelectedIndex == -1)
            {
                cmbCoin.Enabled = false;
                btnEkle.Enabled = true;
                cboxKatla.Enabled = true;
            }
            else if (cmbBanknote.SelectedIndex == -1 && cmbCoin.SelectedIndex != -1)
            {
                btnEkle.Enabled = true;
            }
            else if (cmbCoin.SelectedIndex != -1 && cmbCoin.SelectedIndex != -1)
            {
                btnEkle.Enabled = false;
            }
            else btnEkle.Enabled = false;
        }
        private void cmbCoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoin.SelectedIndex != -1 && cmbBanknote.SelectedIndex == -1)
            {
                cmbBanknote.Enabled = false;
                cboxKatla.Enabled = false;
                btnEkle.Enabled = true;
            }
            else if (cmbCoin.SelectedIndex == -1 && cmbBanknote.SelectedIndex != -1)
            {
                btnEkle.Enabled = true;
            }
            else if (cmbCoin.SelectedIndex != -1 && cmbBanknote.SelectedIndex != -1)
            {
                btnEkle.Enabled = false;
            }
            else btnEkle.Enabled = false;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
