using System.Drawing;
using MathWorks.MATLAB.NET.Arrays;
using System;

namespace RozpoznawanieObiektow
{
    class WyszukiwanieObiektu
    {
        BibliotekaMatlab.WyszukajObiekt matlabWyszukajObiekt;

        public WyszukiwanieObiektu()
        {
            matlabWyszukajObiekt = new BibliotekaMatlab.WyszukajObiekt();
        }
        public Bitmap ViolaJones(Bitmap bitmapaWe, string rodzajObiektuDoWyszukania)
        {
            int wysokoscBitmapyWe = bitmapaWe.Height;
            int szerokoscBitmapyWy = bitmapaWe.Width;

            Bitmap bitmapaWy = new Bitmap(szerokoscBitmapyWy, wysokoscBitmapyWe);

            byte[,,] rgb = new byte[3, wysokoscBitmapyWe, szerokoscBitmapyWy];
            for (int j = 0; j < wysokoscBitmapyWe; j++)
            {
                for (int i = 0; i < szerokoscBitmapyWy; i++)
                {
                    rgb[0, j, i] = bitmapaWe.GetPixel(i, j).R;
                    rgb[1, j, i] = bitmapaWe.GetPixel(i, j).G;
                    rgb[2, j, i] = bitmapaWe.GetPixel(i, j).B;
                }
            }
            MWNumericArray macierzObrazu = rgb;
            MWArray macierzObrazuWynikowego = 0;

            switch (rodzajObiektuDoWyszukania)
            {
                case "Twarz":
                    macierzObrazuWynikowego = matlabWyszukajObiekt.ViolaJones((MWArray)macierzObrazu, "Face");
                    break;
                case "Góra ciała":
                    macierzObrazuWynikowego = matlabWyszukajObiekt.ViolaJones((MWArray)macierzObrazu, "UpperBody");
                    break;
                case "Usta":
                    macierzObrazuWynikowego = matlabWyszukajObiekt.ViolaJones((MWArray)macierzObrazu, "Mouth");
                    break;
                case "Nos":
                    macierzObrazuWynikowego = matlabWyszukajObiekt.ViolaJones((MWArray)macierzObrazu, "Nose");
                    break;
            }
            for (int i = 0; i < wysokoscBitmapyWe; i++)
            {
                for (int j = 0; j < szerokoscBitmapyWy; j++)
                {
                    bitmapaWy.SetPixel(j, i, Color.FromArgb(Convert.ToInt32(macierzObrazuWynikowego[i + 1, j + 1, 1].ToString()), Convert.ToInt32(macierzObrazuWynikowego[i + 1, j + 1, 2].ToString()), Convert.ToInt32(macierzObrazuWynikowego[i + 1, j + 1, 3].ToString())));
                }
            }
            return bitmapaWy;
        }
        public Bitmap SURF(Bitmap bitmapaWe, Bitmap wzorzec)
        {
            int wysokoscBitmapyWe = bitmapaWe.Height;
            int szerokoscBitmapyWy = bitmapaWe.Width;
            int wysokoscWzorzec = wzorzec.Height;
            int szerokoscWzorzec = wzorzec.Width;
            bool blad = false;

            Bitmap bitmapaWy = new Bitmap(szerokoscBitmapyWy, wysokoscBitmapyWe);

            byte[,,] rgb = new byte[3, wysokoscBitmapyWe, szerokoscBitmapyWy];
            for (int j = 0; j < wysokoscBitmapyWe; j++)
            {
                for (int i = 0; i < szerokoscBitmapyWy; i++)
                {
                    rgb[0, j, i] = bitmapaWe.GetPixel(i, j).R;
                    rgb[1, j, i] = bitmapaWe.GetPixel(i, j).G;
                    rgb[2, j, i] = bitmapaWe.GetPixel(i, j).B;
                }
            }
            MWNumericArray macierzObrazu = rgb;

            byte[,,] rgbWzorzec = new byte[3, wysokoscWzorzec, szerokoscWzorzec];
            for (int j = 0; j < wysokoscWzorzec; j++)
            {
                for (int i = 0; i < szerokoscWzorzec; i++)
                {
                    rgbWzorzec[0, j, i] = wzorzec.GetPixel(i, j).R;
                    rgbWzorzec[1, j, i] = wzorzec.GetPixel(i, j).G;
                    rgbWzorzec[2, j, i] = wzorzec.GetPixel(i, j).B;
                }
            }
            MWNumericArray macierzWzorca = rgbWzorzec;
            MWArray macierzObrazuWynikowego = 0;
            try
            {
                macierzObrazuWynikowego = matlabWyszukajObiekt.SURF((MWArray)macierzWzorca, (MWArray)macierzObrazu);
            }
            catch (Exception)
            {
                blad = true;
            }
            if (blad == false)
            {
                for (int i = 0; i < wysokoscBitmapyWe; i++)
                {
                    for (int j = 0; j < szerokoscBitmapyWy; j++)
                    {
                        bitmapaWy.SetPixel(j, i, Color.FromArgb(Convert.ToInt32(macierzObrazuWynikowego[i + 1, j + 1, 1].ToString()), Convert.ToInt32(macierzObrazuWynikowego[i + 1, j + 1, 2].ToString()), Convert.ToInt32(macierzObrazuWynikowego[i + 1, j + 1, 3].ToString())));
                    }
                }
            }

            return bitmapaWy;
        }
        public Bitmap HOG(Bitmap bitmapaWe)
        {
            int wysokoscBitmapyWe = bitmapaWe.Height;
            int szerokoscBitmapyWy = bitmapaWe.Width;

            Bitmap bitmapaWy = new Bitmap(szerokoscBitmapyWy, wysokoscBitmapyWe);

            byte[,,] rgb = new byte[3, wysokoscBitmapyWe, szerokoscBitmapyWy];
            for (int j = 0; j < wysokoscBitmapyWe; j++)
            {
                for (int i = 0; i < szerokoscBitmapyWy; i++)
                {
                    rgb[0, j, i] = bitmapaWe.GetPixel(i, j).R;
                    rgb[1, j, i] = bitmapaWe.GetPixel(i, j).G;
                    rgb[2, j, i] = bitmapaWe.GetPixel(i, j).B;
                }
            }
            MWNumericArray macierzObrazu = rgb;
            MWArray macierzObrazuWynikowego = 0;

            macierzObrazuWynikowego = matlabWyszukajObiekt.HOG_SVM((MWArray)macierzObrazu);

            for (int i = 0; i < wysokoscBitmapyWe; i++)
            {
                for (int j = 0; j < szerokoscBitmapyWy; j++)
                {
                    bitmapaWy.SetPixel(j, i, Color.FromArgb(Convert.ToInt32(macierzObrazuWynikowego[i + 1, j + 1, 1].ToString()), Convert.ToInt32(macierzObrazuWynikowego[i + 1, j + 1, 2].ToString()), Convert.ToInt32(macierzObrazuWynikowego[i + 1, j + 1, 3].ToString())));
                }
            }
            return bitmapaWy;
        }
    }
}
