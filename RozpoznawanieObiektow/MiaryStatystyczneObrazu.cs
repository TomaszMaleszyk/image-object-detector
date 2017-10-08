using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RozpoznawanieObiektow
{

    class MiaryStatystyczneObrazu
    {
        public double SredniaJasnoscPiksela(Bitmap bitmapaWe, string analizowanyKolor)
        {
            double[] tabAnalizowanyKolor = new double[256];

            double liczbaPikseli = bitmapaWe.Width * bitmapaWe.Height;

            double srJasnoscAnalizowanegoKoloru = 0;

            tabAnalizowanyKolor = TworzHistogram(bitmapaWe, analizowanyKolor);

            for (int i = 0; i < 256; i++)
            {
                srJasnoscAnalizowanegoKoloru += tabAnalizowanyKolor[i] * i;
            }

            srJasnoscAnalizowanegoKoloru /= liczbaPikseli;

            return srJasnoscAnalizowanegoKoloru;

        }
        public double NajciemniejszyPikselObrazu(Bitmap bitmapaWe, string analizowanyKolor) //tu są jakieś niedopracowania z tym min i maxem
        {
            double[] tabAnalizowanyKolor = new double[256];

            double wartoscMinJasnosci = 0;

            tabAnalizowanyKolor = TworzHistogram(bitmapaWe, analizowanyKolor);

            wartoscMinJasnosci = Array.IndexOf(tabAnalizowanyKolor, tabAnalizowanyKolor.First(x => x > 0));

            return wartoscMinJasnosci;

        }
        public double NajjasniejszyPikselObrazu(Bitmap bitmapaWe, string analizowanyKolor)
        {
            double[] tabAnalizowanyKolor = new double[256];
            double wartoscMaxJasnosci = 0;

            tabAnalizowanyKolor = TworzHistogram(bitmapaWe, analizowanyKolor);
            for (int i = 0; i < tabAnalizowanyKolor.Length; i++)
            {
                if (tabAnalizowanyKolor[i] > 0)
                {
                    wartoscMaxJasnosci = i;
                }
            }
            return wartoscMaxJasnosci;
        }
        private double[] TworzHistogram(Bitmap bitmapaWe, string analizowanyKolor)
        {
            Color kolorPiksela;

            double[] r = new double[256];
            double[] g = new double[256];
            double[] b = new double[256];
            double[] gray = new double[256];

            Array.Clear(r, 0, r.Length);
            Array.Clear(g, 0, g.Length);
            Array.Clear(b, 0, b.Length);
            Array.Clear(gray, 0, gray.Length);

            for (int j = 0; j < bitmapaWe.Height; j++)
            {
                for (int i = 0; i < bitmapaWe.Width; i++)
                {
                    kolorPiksela = bitmapaWe.GetPixel(i, j);

                    r[kolorPiksela.R]++;
                    g[kolorPiksela.G]++;
                    b[kolorPiksela.B]++;
                }
            }

            for (int i = 0; i < r.Length; i++)
            {
                gray[i] = (r[i] + g[i] + b[i]) / 3;
            }

            if (analizowanyKolor == "Czerwony")
            {
                return r;
            }
            else if (analizowanyKolor == "Zielony")
            {
                return g;
            }
            else if (analizowanyKolor == "Niebieski")
            {
                return b;
            }
            else if (analizowanyKolor == "Szary")
            {
                return gray;
            }
            else
            {
                return new double[] { 0, 0, 0, 0, 0 };
            }
        }
        public double WartoscKontrastu(Bitmap bitmapaWe, string analizowanyKolor)
        {
            double kontrast;
            double minJasnosc = NajciemniejszyPikselObrazu(bitmapaWe, analizowanyKolor);
            double maxJasnosc = NajjasniejszyPikselObrazu(bitmapaWe, analizowanyKolor);
            double zakresJasnosc = 255;

            if (minJasnosc == 0)
            {
                minJasnosc = 1;
            }

            if (maxJasnosc == 0)
            {
                kontrast = 0;
            }
            else
            {
                kontrast = (maxJasnosc / minJasnosc) / zakresJasnosc;
            }

            return kontrast;
        }
        public double WartoscWariancji(Bitmap bitmapaWe, string analizowanyKolor)         
        {
            double wariancja=0;
            double iloscPikseli= bitmapaWe.Width*bitmapaWe.Height;
            double sredniaJasnosc = SredniaJasnoscPiksela(bitmapaWe,analizowanyKolor);
            double[] tablicaKoloru = TworzHistogram(bitmapaWe, analizowanyKolor);
            for (int i = 0; i < tablicaKoloru.Length; i++)
			{
                wariancja += (tablicaKoloru[i] - sredniaJasnosc) * (tablicaKoloru[i] - sredniaJasnosc);
			}
            wariancja /= iloscPikseli;
            return wariancja;
        }
        public double WartoscOdchylenia(Bitmap bitmapaWe,string analizowanyKolor)
        {
            double odchylenie = 0;
            try
            {
                Math.Sqrt(WartoscWariancji(bitmapaWe,analizowanyKolor));
            }
            catch (Exception)
            {
                odchylenie = 0;   
            }
            return odchylenie;
        }
    }
}
