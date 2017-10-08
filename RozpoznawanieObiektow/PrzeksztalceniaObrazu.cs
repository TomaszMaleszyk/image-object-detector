using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RozpoznawanieObiektow
{
    class PrzeksztalceniaObrazu                        
    {
        #region Binaryzacja
        public double ProgOtsu(Bitmap bitmapaWe)
        {
            double pob = 0, pb, mob, mb, s2b;
            Color kolorPiksela;
            double[] histogram = new double[256];
            histogram[0] = 0;
            double liczbaPikseliObrazu = bitmapaWe.Width * bitmapaWe.Height;
            for (int y = 0; y < bitmapaWe.Height; y++)
                for (int x = 0; x < bitmapaWe.Width; x++)
                {
                    kolorPiksela = bitmapaWe.GetPixel(x, y);
                    byte r = kolorPiksela.R;
                    byte g = kolorPiksela.G;
                    byte b = kolorPiksela.B;
                    byte k = (byte)((r + g + b) / 3);
                    histogram[k] = histogram[k] + 1;
                }

            for (int i = 0; i < 256; i++)
                histogram[i] = histogram[i] / liczbaPikseliObrazu;

            int t = 0;
            double maxs2 = 0, progBinaryzacjiOtsu = 0;
            for (t = 1; t < 255; t++)
            {
                pob = pb = mob = mb = s2b = 0;
                for (int k = 0; k <= t; k++)
                    pob += histogram[k];
                for (int k = t + 1; k < 256; k++)
                    pb += histogram[k];
                for (int k = 0; k < t; k++)
                    mob += k * histogram[k];
                if (pob != 0) mob = mob / pob;
                for (int k = t + 1; k < 256; k++)
                    mb += k * histogram[k];
                if (pb != 0) mb = mb / pb;
                s2b = pob * pb * (mob - mb) * (mob - mb);
                if (s2b > maxs2)
                {
                    maxs2 = s2b;
                    progBinaryzacjiOtsu = t;
                }
            }
            return progBinaryzacjiOtsu;
        }
        public Bitmap Binaryzacja(Bitmap bitmapaWe, int progBinaryzacji)
        {
            int wysokosc = bitmapaWe.Height;
            int szerokosc = bitmapaWe.Width;

            bitmapaWe = OdcienieSzarosci(bitmapaWe);

            BitmapData bitmapaWeDane = bitmapaWe.LockBits(new Rectangle(0, 0, szerokosc, wysokosc), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int liniaSkanowaniaBitmapaWe = bitmapaWeDane.Stride;
            unsafe
            {
                byte* odczytPiksela = (byte*)(void*)bitmapaWeDane.Scan0.ToPointer();

                for (int j = 0; j < wysokosc; j++)
                {
                    byte* pWe = &odczytPiksela[j * liniaSkanowaniaBitmapaWe];
                    for (int i = 0; i < szerokosc * 3; i += 3)
                    {
                        pWe[i] = (byte)((pWe[i] > (byte)progBinaryzacji) ? 255 : 0);
                        pWe[i + 1] = (byte)((pWe[i + 1] > (byte)progBinaryzacji) ? 255 : 0);
                        pWe[i + 2] = (byte)((pWe[i + 2] > (byte)progBinaryzacji) ? 255 : 0);
                    }
                }
            }
            bitmapaWe.UnlockBits(bitmapaWeDane);

            return bitmapaWe;
        }
        #endregion
        #region Jasność obrazu
        public Bitmap UstalJasnosciObrazu(Bitmap bitmapaWe, int poziomJasnosci)
        {
            Color kolorPiksela;
            int szerokoscBitmapy = bitmapaWe.Width;
            int wysokoscBitmapy = bitmapaWe.Height;

            for (int j = 0; j < wysokoscBitmapy; j++)
            {
                for (int i = 0; i < szerokoscBitmapy; i++)
                {
                    kolorPiksela = bitmapaWe.GetPixel(i, j);
                    int barwaR = kolorPiksela.R + poziomJasnosci;
                    int barwaG = kolorPiksela.G + poziomJasnosci;
                    int barwaB = kolorPiksela.B + poziomJasnosci;

                    if (barwaR < 0) barwaR = 1;
                    if (barwaR > 255) barwaR = 255;

                    if (barwaG < 0) barwaG = 1;
                    if (barwaG > 255) barwaG = 255;

                    if (barwaB < 0) barwaB = 1;
                    if (barwaB > 255) barwaB = 255;

                    bitmapaWe.SetPixel(i, j, Color.FromArgb((byte)barwaR, (byte)barwaG, (byte)barwaB));
                }
            }
            return bitmapaWe;
        }

        #endregion
        #region Kontrast obrazu
        public Bitmap UstalKontrastObrazu(Bitmap bitmapaWe, double poziomKontrastu)
        {
            int szerokoscBitmapy = bitmapaWe.Width;
            int wysokoscBitmapy = bitmapaWe.Height;

            if (poziomKontrastu < -100) poziomKontrastu = -100;
            if (poziomKontrastu > 100) poziomKontrastu = 100;

            poziomKontrastu = (100.0 + poziomKontrastu) / 100.0;
            poziomKontrastu *= poziomKontrastu;
            Color kolorPiksela;
            for (int j = 0; j < wysokoscBitmapy; j++)
            {
                for (int i = 0; i < szerokoscBitmapy; i++)
                {
                    kolorPiksela = bitmapaWe.GetPixel(i, j);
                    double barwaR = kolorPiksela.R / 255.0;
                    barwaR -= 0.5;
                    barwaR *= poziomKontrastu;
                    barwaR += 0.5;
                    barwaR *= 255;
                    if (barwaR < 0) barwaR = 0;
                    if (barwaR > 255) barwaR = 255;

                    double barwaG = kolorPiksela.G / 255.0;
                    barwaG -= 0.5;
                    barwaG *= poziomKontrastu;
                    barwaG += 0.5;
                    barwaG *= 255;
                    if (barwaG < 0) barwaG = 0;
                    if (barwaG > 255) barwaG = 255;

                    double barwaB = kolorPiksela.B / 255.0;
                    barwaB -= 0.5;
                    barwaB *= poziomKontrastu;
                    barwaB += 0.5;
                    barwaB *= 255;
                    if (barwaB < 0) barwaB = 0;
                    if (barwaB > 255) barwaB = 255;

                    bitmapaWe.SetPixel(i, j, Color.FromArgb((byte)barwaR, (byte)barwaG, (byte)barwaB));
                }
            }
            return bitmapaWe;
        }

        #endregion
        #region Odcienie szarości
        public Bitmap OdcienieSzarosci(Bitmap bitmapaWe)
        {
            Color kolorPiksela;
            int szerokoscBitmapy = bitmapaWe.Width;
            int wysokoscBitmapy = bitmapaWe.Height;

            for (int j = 0; j < wysokoscBitmapy; j++)
            {
                for (int i = 0; i < szerokoscBitmapy; i++)
                {
                    kolorPiksela = bitmapaWe.GetPixel(i, j);

                    byte barwaR = kolorPiksela.R;
                    byte barwaG = kolorPiksela.G;
                    byte barwaB = kolorPiksela.B;
                    int szarosc = (barwaR + barwaG + barwaB) / 3;

                    kolorPiksela = Color.FromArgb(szarosc, szarosc, szarosc);
                    bitmapaWe.SetPixel(i, j, kolorPiksela);
                }
            }
            return bitmapaWe;
        }
        #endregion
        #region Histogram
        private double[] TworzHistogram(Bitmap bitmapaWe, Color kolorKan)
        {
            Color kolorPiksela;
            int szerokoscBitmapy = bitmapaWe.Width;
            int wysokoscBitmapy = bitmapaWe.Height;

            double[] tablicaR = new double[256];
            double[] tablicaG = new double[256];
            double[] tablicaB = new double[256];
            double[] tablicaGray = new double[256];

            Array.Clear(tablicaR, 0, tablicaR.Length);
            Array.Clear(tablicaG, 0, tablicaG.Length);
            Array.Clear(tablicaB, 0, tablicaB.Length);
            Array.Clear(tablicaGray, 0, tablicaGray.Length);

            for (int j = 0; j < bitmapaWe.Height; j++)
            {
                for (int i = 0; i < bitmapaWe.Width; i++)
                {
                    kolorPiksela = bitmapaWe.GetPixel(i, j);

                    tablicaR[kolorPiksela.R]++;
                    tablicaG[kolorPiksela.G]++;
                    tablicaB[kolorPiksela.B]++;
                }
            }

            for (int i = 0; i < tablicaR.Length; i++)
            {
                tablicaGray[i] = (tablicaR[i] + tablicaG[i] + tablicaB[i]) / 3;
            }

            if (kolorKan == Color.Red)
            {
                return tablicaR;
            }
            else if (kolorKan == Color.Green)
            {
                return tablicaG;
            }
            else if (kolorKan == Color.Blue)
            {
                return tablicaB;
            }
            else if (kolorKan == Color.Gray)
            {
                return tablicaGray;
            }
            else
            {
                return new double[] { 0, 0, 0, 0, 0 };
            }
        }
        private void NormalizujWysokoscHistogramu(double[] tablicaKoloru, int wysokoscBitmapy)
        {
            double najliczniejszyOdcien = tablicaKoloru.Max();
            for (int i = 0; i < 256; i++)
            {
                tablicaKoloru[i] = (tablicaKoloru[i] / najliczniejszyOdcien) * wysokoscBitmapy;
            }
        }
        private void RysujHistogram(Bitmap bitmapaWy, double[] tablicaKoloru, Color kolorPedzla)
        {
            Graphics rysuj = Graphics.FromImage(bitmapaWy);
            double szczytSlupkaHistogramu;
            Pen pedzel = new Pen(kolorPedzla, 1);

            for (int i = 0; i < 255; i++)
            {
                szczytSlupkaHistogramu = bitmapaWy.Height - tablicaKoloru[i];
                rysuj.DrawLine(pedzel, i, bitmapaWy.Height, i, (int)szczytSlupkaHistogramu);
            }
        }
        private void RysujHistogramLiniowy(Bitmap bitmapaWy, double[] tablicaKoloru, Color kolorPedzla)
        {
            Graphics rysuj = Graphics.FromImage(bitmapaWy);
            double szczytSlupkaHistogramu;
            double szczytNastSlupkaHistogramu;

            Pen pedzel = new Pen(kolorPedzla, 1);

            for (int i = 0; i < 255; i++)
            {
                szczytSlupkaHistogramu = bitmapaWy.Height - tablicaKoloru[i];
                szczytNastSlupkaHistogramu = bitmapaWy.Height - tablicaKoloru[i + 1];

                rysuj.DrawLine(pedzel, i, (int)szczytSlupkaHistogramu, i + 1, (int)szczytNastSlupkaHistogramu);
            }
        }
        private void CzyscHistogram(Bitmap bitmapaWy)
        {
            Graphics rysuj = Graphics.FromImage(bitmapaWy);
            SolidBrush pedzel = new SolidBrush(Color.Silver);
            rysuj.FillRectangle(pedzel, 0, 0, bitmapaWy.Width, bitmapaWy.Height);
        }
        #region Histogram poszczególnych kolorów
        public Bitmap ObliczHistogram(Bitmap bitmapaWe, Bitmap bitmapaWy, Color kolorKan)
        {
            int wysokoscBitmapyWyj = bitmapaWy.Height;
            double[] tablicaKoloru = TworzHistogram(bitmapaWe, kolorKan);

            NormalizujWysokoscHistogramu(tablicaKoloru, wysokoscBitmapyWyj);
            CzyscHistogram(bitmapaWy);
            RysujHistogram(bitmapaWy, tablicaKoloru, kolorKan);

            return bitmapaWy;
        }
        #endregion
        #region Histogram Liniowy
        public Bitmap ObliczHistogramLiniowy(Bitmap bitmapaWe, Bitmap bitmapaWy)
        {
            Color analizowanyKolor = Color.Red;
            double[] tablicaKoloru = TworzHistogram(bitmapaWe, analizowanyKolor);

            CzyscHistogram(bitmapaWy);

            NormalizujWysokoscHistogramu(tablicaKoloru, bitmapaWy.Height);
            RysujHistogramLiniowy(bitmapaWy, tablicaKoloru, Color.Red);

            analizowanyKolor = Color.Green;
            tablicaKoloru = TworzHistogram(bitmapaWe, analizowanyKolor);

            NormalizujWysokoscHistogramu(tablicaKoloru, bitmapaWy.Height);
            RysujHistogramLiniowy(bitmapaWy, tablicaKoloru, Color.Green);

            analizowanyKolor = Color.Blue;
            tablicaKoloru = TworzHistogram(bitmapaWe, analizowanyKolor);

            NormalizujWysokoscHistogramu(tablicaKoloru, bitmapaWy.Height);
            RysujHistogramLiniowy(bitmapaWy, tablicaKoloru, Color.Blue);

            return bitmapaWy;
        }
        #endregion
        #endregion

        public Bitmap WyrownanieHistogramu(Bitmap bitmapaWe) 
        {
            Bitmap bitmapaWy = bitmapaWe;

            int wysokoscBitmapy = bitmapaWe.Height;
            int szerokoscBitmapy = bitmapaWe.Width;

            decimal iloscPikseliObrazu = bitmapaWy.Height * bitmapaWy.Width;
            decimal sredniaJasnosc = 255 / iloscPikseliObrazu; //średnia jasność na piksel???
            double[] tablicaR = TworzHistogram(bitmapaWe, Color.Red);
            double[] tablicaG = TworzHistogram(bitmapaWe, Color.Green);
            double[] tablicaB = TworzHistogram(bitmapaWe, Color.Blue);

            for (int i = 1; i <= 255; i++)
            {
                tablicaR[i] = tablicaR[i] + tablicaR[i - 1];
                tablicaG[i] = tablicaG[i] + tablicaG[i - 1];
                tablicaB[i] = tablicaB[i] + tablicaB[i - 1];
            }

            for (int j = 0; j < wysokoscBitmapy; j++)
            {
                for (int i = 0; i < szerokoscBitmapy; i++)
                {
                    int barwaR, barwaG, barwaB;

                    Color kolorAnalizowanegoPiksela = bitmapaWy.GetPixel(i, j);

                    barwaR = (int)((decimal)tablicaR[kolorAnalizowanegoPiksela.R] * sredniaJasnosc);
                    barwaG = (int)((decimal)tablicaG[kolorAnalizowanegoPiksela.G] * sredniaJasnosc);
                    barwaB = (int)((decimal)tablicaB[kolorAnalizowanegoPiksela.B] * sredniaJasnosc);

                    Color nowyKolor = Color.FromArgb(barwaR, barwaG, barwaB);
                    bitmapaWy.SetPixel(i, j, nowyKolor);
                }
            }
            return bitmapaWy;
        }
        public Bitmap FiltrMedianowy(Bitmap bitmapaWe, int rozmiarMaski)
        {
            List<int> sasiadujacePiksele = new List<int>();

            int promienMaski = (rozmiarMaski - 1) / 2;
            int analizowanyPiksel = 0;
            int numerPiksela = 0;

            byte[] srodkowyPiksel;

            BitmapData daneBitmapaWe =
                       bitmapaWe.LockBits(new Rectangle(0, 0,
                       bitmapaWe.Width, bitmapaWe.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] tabPikseliObrazu = new byte[daneBitmapaWe.Stride * daneBitmapaWe.Height];

            byte[] wynikowaTabPikseliObrazu = new byte[daneBitmapaWe.Stride * daneBitmapaWe.Height];

            Marshal.Copy(daneBitmapaWe.Scan0, tabPikseliObrazu, 0,
                                       tabPikseliObrazu.Length);

            bitmapaWe.UnlockBits(daneBitmapaWe);

            for (int i = promienMaski; i < bitmapaWe.Height - promienMaski; i++)
            {
                for (int j = promienMaski; j < bitmapaWe.Width - promienMaski; j++)
                {
                    numerPiksela = i * daneBitmapaWe.Stride + j * 4;

                    sasiadujacePiksele.Clear();

                    for (int filtrY = -promienMaski; filtrY <= promienMaski; filtrY++)
                    {
                        for (int filtrX = -promienMaski; filtrX <= promienMaski; filtrX++)
                        {
                            analizowanyPiksel = numerPiksela + (filtrX * 4) + (filtrY * daneBitmapaWe.Stride);

                            sasiadujacePiksele.Add(BitConverter.ToInt32(tabPikseliObrazu, analizowanyPiksel));
                        }
                    }
                    sasiadujacePiksele.Sort();

                    srodkowyPiksel = BitConverter.GetBytes(sasiadujacePiksele[promienMaski]);

                    wynikowaTabPikseliObrazu[numerPiksela] = srodkowyPiksel[0];
                    wynikowaTabPikseliObrazu[numerPiksela + 1] = srodkowyPiksel[1];
                    wynikowaTabPikseliObrazu[numerPiksela + 2] = srodkowyPiksel[2];
                    wynikowaTabPikseliObrazu[numerPiksela + 3] = srodkowyPiksel[3];
                }
            }

            Bitmap bitmapaWy = new Bitmap(bitmapaWe.Width,
                                             bitmapaWe.Height);

            BitmapData daneBitmapyWy =
                       bitmapaWy.LockBits(new Rectangle(0, 0,
                       bitmapaWy.Width, bitmapaWy.Height),
                       ImageLockMode.WriteOnly,
                       PixelFormat.Format32bppArgb);

            Marshal.Copy(wynikowaTabPikseliObrazu, 0, daneBitmapyWy.Scan0, wynikowaTabPikseliObrazu.Length);

            bitmapaWy.UnlockBits(daneBitmapyWy);

            return bitmapaWy;
        }
        public Bitmap ObrotObrazu(Bitmap bitmapaWe, float stopienObrotu)
        {
            Bitmap bitmapaWy = new Bitmap(bitmapaWe.Width, bitmapaWe.Height);
            Graphics rysuj = Graphics.FromImage(bitmapaWy);

            rysuj.TranslateTransform((float)bitmapaWy.Width / 2, (float)bitmapaWy.Height / 2);
            rysuj.RotateTransform(stopienObrotu);
            rysuj.TranslateTransform(-(float)bitmapaWy.Width / 2, -(float)bitmapaWy.Height / 2);

            rysuj.InterpolationMode = InterpolationMode.HighQualityBicubic;
            rysuj.DrawImage(bitmapaWe, new Point(0, 0));

            rysuj.Dispose();
            return bitmapaWy;
        }
        public Bitmap ZmienRozmiarObrazu(Bitmap bitmapaWe, int szerokoscWyjsciowa, int wysokoscWyjsciowa)
        {
            Bitmap bitmapaWy = new Bitmap(szerokoscWyjsciowa, wysokoscWyjsciowa, bitmapaWe.PixelFormat);

            double stosunekSzerokosci = (double)bitmapaWe.Width / (double)szerokoscWyjsciowa;
            double stosunekWysokosci = (double)bitmapaWe.Height / (double)wysokoscWyjsciowa;

            double fx, fy, nx, ny;
            int cx, cy, fr_x, fr_y;
            Color kolor1 = new Color();
            Color kolor2 = new Color();
            Color kolor3 = new Color();
            Color kolor4 = new Color();
            byte barwaR, barwaG, barwaB;

            byte bp1, bp2;

            for (int j = 0; j < bitmapaWy.Height; j++)
            {
                for (int i = 0; i < bitmapaWy.Width; i++)
                {
                    fr_x = (int)Math.Floor(i * stosunekSzerokosci);
                    fr_y = (int)Math.Floor(j * stosunekWysokosci);
                    cx = fr_x + 1;
                    if (cx >= bitmapaWe.Width) cx = fr_x;
                    cy = fr_y + 1;
                    if (cy >= bitmapaWe.Height) cy = fr_y;
                    fx = i * stosunekSzerokosci - fr_x;
                    fy = j * stosunekWysokosci - fr_y;
                    nx = 1.0 - fx;
                    ny = 1.0 - fy;

                    kolor1 = bitmapaWe.GetPixel(fr_x, fr_y);
                    kolor2 = bitmapaWe.GetPixel(cx, fr_y);
                    kolor3 = bitmapaWe.GetPixel(fr_x, cy);
                    kolor4 = bitmapaWe.GetPixel(cx, cy);


                    bp1 = (byte)(nx * kolor1.R + fx * kolor2.R);
                    bp2 = (byte)(nx * kolor3.R + fx * kolor4.R);
                    barwaR = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                    bp1 = (byte)(nx * kolor1.G + fx * kolor2.G);
                    bp2 = (byte)(nx * kolor3.G + fx * kolor4.G);
                    barwaG = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                    bp1 = (byte)(nx * kolor1.B + fx * kolor2.B);
                    bp2 = (byte)(nx * kolor3.B + fx * kolor4.B);
                    barwaB = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                    bitmapaWy.SetPixel(i, j, System.Drawing.Color.FromArgb
            (255, barwaR, barwaG, barwaB));
                }
            }
            return bitmapaWy;
        }
        public Bitmap OddalObraz(Bitmap bitmapaWe, double skala)   
        {
            double stosunekSzerSkala = bitmapaWe.Width / skala; 
            double stosunekWysSkala = bitmapaWe.Height / skala;

            int szerokoscBitmapy = (int)stosunekSzerSkala;
            int wysokoscBitmapy = (int)stosunekWysSkala;

            Rectangle prostokatWyjsciowy = new Rectangle(0, 0, szerokoscBitmapy, wysokoscBitmapy);
            Bitmap bitmapaWy = new Bitmap(szerokoscBitmapy, wysokoscBitmapy);

            bitmapaWy.SetResolution(bitmapaWe.HorizontalResolution, bitmapaWe.VerticalResolution);

            using (var rysuj = Graphics.FromImage(bitmapaWy))
            {
                rysuj.CompositingMode = CompositingMode.SourceCopy;
                rysuj.CompositingQuality = CompositingQuality.HighQuality;
                rysuj.InterpolationMode = InterpolationMode.HighQualityBicubic;
                rysuj.SmoothingMode = SmoothingMode.HighQuality;
                rysuj.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    rysuj.DrawImage(bitmapaWe, prostokatWyjsciowy, 0, 0, bitmapaWe.Width, bitmapaWe.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return bitmapaWy;
        }
        public Bitmap PrzyblizObraz(Bitmap bitmapaWe, double skala)     
        {
            double stosunekSzerSkala = bitmapaWe.Width * skala;
            double stosunekWysSkala = bitmapaWe.Height * skala;

            int szerokoscBitmapy = (int)stosunekSzerSkala;
            int wysokoscBitmapy = (int)stosunekWysSkala;

            Rectangle prostokatWyjsciowy = new Rectangle(0, 0, szerokoscBitmapy, wysokoscBitmapy);
            Bitmap bitmapaWy = new Bitmap(szerokoscBitmapy, wysokoscBitmapy);

            bitmapaWy.SetResolution(bitmapaWe.HorizontalResolution, bitmapaWe.VerticalResolution);

            using (var rysuj = Graphics.FromImage(bitmapaWy))
            {
                rysuj.CompositingMode = CompositingMode.SourceCopy;
                rysuj.CompositingQuality = CompositingQuality.HighQuality;
                rysuj.InterpolationMode = InterpolationMode.HighQualityBicubic;
                rysuj.SmoothingMode = SmoothingMode.HighQuality;
                rysuj.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    rysuj.DrawImage(bitmapaWe, prostokatWyjsciowy, 0, 0, bitmapaWe.Width, bitmapaWe.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return bitmapaWy;
        }
        public Bitmap PrzytnijObraz(Bitmap bitmapaWe, int szerokoscWyjsciowa, int wysokoscWyjsciowa)
        {
            var prostokatWyjsciowy = new Rectangle(0, 0, szerokoscWyjsciowa, wysokoscWyjsciowa);
            var bitmapaWy = new Bitmap(szerokoscWyjsciowa, wysokoscWyjsciowa);

            bitmapaWy.SetResolution(bitmapaWe.HorizontalResolution, bitmapaWe.VerticalResolution);

            using (var rysuj = Graphics.FromImage(bitmapaWy))
            {
                rysuj.CompositingMode = CompositingMode.SourceCopy;
                rysuj.CompositingQuality = CompositingQuality.HighQuality;
                rysuj.InterpolationMode = InterpolationMode.HighQualityBicubic;
                rysuj.SmoothingMode = SmoothingMode.HighQuality;
                rysuj.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    rysuj.DrawImage(bitmapaWe, prostokatWyjsciowy, 0, 0, szerokoscWyjsciowa, wysokoscWyjsciowa, GraphicsUnit.Pixel);
                }
            }

            return bitmapaWy;
        }
        public Bitmap OdrysujFragmentDoWyciecia(Bitmap bitmapaWe, int szerokoscWejsciowa, int wysokoscWejsciowa, int szerokoscFragmentu, int wysokoscFragmentu)
        {
            Bitmap bitmapaOperacyjna = (Bitmap)bitmapaWe.Clone();
            Graphics rysuj = Graphics.FromImage(bitmapaOperacyjna);
            Brush pedzel = new Pen(Color.FromArgb(150, Color.White)).Brush;
            Rectangle prostokatGora = new Rectangle(0, 0, bitmapaWe.Width, wysokoscWejsciowa);
            Rectangle prostokatLewyBok = new Rectangle(0, wysokoscWejsciowa, szerokoscWejsciowa, wysokoscFragmentu);
            Rectangle prostokatDol = new Rectangle(0, (wysokoscWejsciowa + wysokoscFragmentu), bitmapaWe.Width, bitmapaWe.Height);
            Rectangle prostokatPrawyBok = new Rectangle((szerokoscWejsciowa + szerokoscFragmentu), wysokoscWejsciowa, (bitmapaWe.Width - szerokoscWejsciowa - szerokoscFragmentu), wysokoscFragmentu);

            rysuj.FillRectangle(pedzel, prostokatGora);
            rysuj.FillRectangle(pedzel, prostokatLewyBok);
            rysuj.FillRectangle(pedzel, prostokatDol);
            rysuj.FillRectangle(pedzel, prostokatPrawyBok);

            return bitmapaOperacyjna;
        }
        public Bitmap WytnijFragmentObrazu(Bitmap bitmapaWe, int szerokoscWejsciowa, int wysokoscWejsciowa, int szerokoscFragmentu, int wysokoscFragmentu)
        {
            if (szerokoscWejsciowa + szerokoscFragmentu > bitmapaWe.Width)
                szerokoscFragmentu = bitmapaWe.Width - szerokoscWejsciowa;
            if (wysokoscWejsciowa + wysokoscFragmentu > bitmapaWe.Height)
                wysokoscFragmentu = bitmapaWe.Height - wysokoscWejsciowa;
            Rectangle fragmentBitmapy = new Rectangle(szerokoscWejsciowa, wysokoscWejsciowa, szerokoscFragmentu, wysokoscFragmentu);
            bitmapaWe = (Bitmap)bitmapaWe.Clone(fragmentBitmapy, bitmapaWe.PixelFormat);

            return bitmapaWe;
        }

    }
}
