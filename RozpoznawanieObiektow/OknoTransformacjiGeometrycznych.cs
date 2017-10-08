using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozpoznawanieObiektow
{
    public partial class OknoTransformacjiGeometrycznych : Form
    {
        private PrzeksztalceniaObrazu przeksztalcenia;

        private OknoGlowne oknoGlowne;

        private Bitmap bitmapaOperacyjna;

        private Bitmap bitmapaWycinanieObrazu;

        private float zliczajKat;

        private int pozycjaPrzyblizenia;

        private int wysokoscWyjsciowa;

        private int szerokoscWyjsciowa;

        private int przytnijParametrSzerPocz;

        private int przytnijParametrWysPocz;

        private int przytnijParametrSzerKon;

        private int przytnijParametrWysKon;


        public OknoTransformacjiGeometrycznych(OknoGlowne okno)
        {
            oknoGlowne = okno;

            przeksztalcenia = new PrzeksztalceniaObrazu();
            bitmapaOperacyjna = new Bitmap(okno.bitmapa);
            bitmapaWycinanieObrazu = bitmapaOperacyjna;
            zliczajKat = 0;
            pozycjaPrzyblizenia = 0;
            wysokoscWyjsciowa = bitmapaOperacyjna.Height;
            szerokoscWyjsciowa = bitmapaOperacyjna.Width;

            InitializeComponent();
        }

        private void OknoTransformacjiGeometrycznych_Load(object sender, EventArgs e)
        {
            txtb_ustalKat.Text = "1";
            pb_obrazWeTransGeo.Image = oknoGlowne.bitmapa;

            trackb_ustalSzer.Maximum = bitmapaOperacyjna.Width;
            trackb_ustalWys.Maximum = bitmapaOperacyjna.Height;
            trackb_ustalSzer.Minimum = 1;
            trackb_ustalWys.Minimum = 1;
            trackb_ustalSzer.Value = bitmapaOperacyjna.Width;
            trackb_ustalWys.Value = bitmapaOperacyjna.Height;

            przytnijParametrSzerPocz = 0;
            przytnijParametrWysPocz = 0;
            przytnijParametrSzerKon = 100;
            przytnijParametrWysKon = 100;

            numericUD_szerPocz.Value = przytnijParametrSzerPocz;
            numericUD_wysPocz.Value = przytnijParametrWysPocz;
            numericUD_szerPrzyc.Value = przytnijParametrSzerKon;
            numericUD_wysPrzyc.Value = przytnijParametrWysKon;

            numericUD_szerPocz.Maximum = bitmapaOperacyjna.Width - przytnijParametrSzerKon;
            numericUD_wysPocz.Maximum = bitmapaOperacyjna.Height - przytnijParametrWysKon;
            numericUD_szerPrzyc.Maximum = bitmapaOperacyjna.Width;
            numericUD_wysPrzyc.Maximum = bitmapaOperacyjna.Height;
        }
        private void ObrotWPrawo(object sender, EventArgs e)
        {
            try
            {
                zliczajKat += float.Parse(txtb_ustalKat.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Proszę podać poprawne dane");
            }
            pb_obrazWeTransGeo.Image = przeksztalcenia.ObrotObrazu(new Bitmap(pb_obrazWeTransGeo.Image), zliczajKat);
            bitmapaWycinanieObrazu = new Bitmap(pb_obrazWeTransGeo.Image);
        }
        private void ObrotWLewo(object sender, EventArgs e)
        {
            try
            {
                zliczajKat -= float.Parse(txtb_ustalKat.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Proszę podać poprawne dane");
            }
            pb_obrazWeTransGeo.Image = przeksztalcenia.ObrotObrazu(new Bitmap(pb_obrazWeTransGeo.Image), zliczajKat);
            bitmapaWycinanieObrazu = new Bitmap(pb_obrazWeTransGeo.Image);
        }
        private void btn_zatwierdzOperacje_Click(object sender, EventArgs e)
        {
            oknoGlowne.pb_obrazWe.Image = przeksztalcenia.PrzytnijObraz(new Bitmap(pb_obrazWeTransGeo.Image), pb_obrazWeTransGeo.Width, pb_obrazWeTransGeo.Height);
            oknoGlowne.bitmapa = new Bitmap(oknoGlowne.pb_obrazWe.Image);
            oknoGlowne.listaObrazow.Add(oknoGlowne.bitmapa);
            oknoGlowne.UstalHistorieTransformacjiObrazu += "Przekształcenie geometryczne," + Environment.NewLine;

            Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackb_przyblizenieObrazu.Value > pozycjaPrzyblizenia)
            {
                double skala = 1.1;
                pb_obrazWeTransGeo.Image = przeksztalcenia.PrzyblizObraz(new Bitmap(pb_obrazWeTransGeo.Image), skala);
                bitmapaOperacyjna = new Bitmap(pb_obrazWeTransGeo.Image);
            }
            if (trackb_przyblizenieObrazu.Value < pozycjaPrzyblizenia)
            {
                double skala = 1.1;
                pb_obrazWeTransGeo.Image = przeksztalcenia.OddalObraz(new Bitmap(pb_obrazWeTransGeo.Image), skala);
                bitmapaOperacyjna = new Bitmap(pb_obrazWeTransGeo.Image);
            }

            pozycjaPrzyblizenia = trackb_przyblizenieObrazu.Value;
        }

        private void trackb_ustalWys_Scroll(object sender, EventArgs e)
        {
            wysokoscWyjsciowa = trackb_ustalWys.Value;

            pb_obrazWeTransGeo.Image = przeksztalcenia.ZmienRozmiarObrazu(bitmapaOperacyjna, szerokoscWyjsciowa, wysokoscWyjsciowa);
        }

        private void trackb_ustalSzer_Scroll(object sender, EventArgs e)
        {
            szerokoscWyjsciowa = trackb_ustalSzer.Value;

            pb_obrazWeTransGeo.Image = przeksztalcenia.ZmienRozmiarObrazu(bitmapaOperacyjna, szerokoscWyjsciowa, wysokoscWyjsciowa);
        }

        private void numericUD_szerPocz_ValueChanged(object sender, EventArgs e)
        {
            przytnijParametrSzerPocz = int.Parse(numericUD_szerPocz.Text);
            pb_obrazWeTransGeo.Image = przeksztalcenia.OdrysujFragmentDoWyciecia(bitmapaWycinanieObrazu, przytnijParametrSzerPocz, przytnijParametrWysPocz, przytnijParametrSzerKon, przytnijParametrWysKon);
        }

        private void numericUD_wysPocz_ValueChanged(object sender, EventArgs e)
        {
            przytnijParametrWysPocz = int.Parse(numericUD_wysPocz.Text);
            pb_obrazWeTransGeo.Image = przeksztalcenia.OdrysujFragmentDoWyciecia(bitmapaWycinanieObrazu, przytnijParametrSzerPocz, przytnijParametrWysPocz, przytnijParametrSzerKon, przytnijParametrWysKon);
        }
        private void numericUD_szerPrzyc_ValueChanged(object sender, EventArgs e)
        {
            przytnijParametrSzerKon = int.Parse(numericUD_szerPrzyc.Text);
            pb_obrazWeTransGeo.Image = przeksztalcenia.OdrysujFragmentDoWyciecia(bitmapaWycinanieObrazu, przytnijParametrSzerPocz, przytnijParametrWysPocz, przytnijParametrSzerKon, przytnijParametrWysKon);
            numericUD_szerPocz.Maximum = bitmapaOperacyjna.Width - przytnijParametrSzerKon;
        }
        private void numericUD_wysPrzyc_ValueChanged(object sender, EventArgs e)
        {
            przytnijParametrWysKon = int.Parse(numericUD_wysPrzyc.Text);
            pb_obrazWeTransGeo.Image = przeksztalcenia.OdrysujFragmentDoWyciecia(bitmapaWycinanieObrazu, przytnijParametrSzerPocz, przytnijParametrWysPocz, przytnijParametrSzerKon, przytnijParametrWysKon);

            numericUD_wysPocz.Maximum = bitmapaOperacyjna.Height - przytnijParametrWysKon;

        }
        private void btn_zatwierdzPrzyciecie_Click(object sender, EventArgs e)
        {
            pb_obrazWeTransGeo.Image = przeksztalcenia.WytnijFragmentObrazu(bitmapaWycinanieObrazu, przytnijParametrSzerPocz, przytnijParametrWysPocz, przytnijParametrSzerKon, przytnijParametrWysKon);
            bitmapaWycinanieObrazu = new Bitmap(pb_obrazWeTransGeo.Image);
        }

        private void pb_obrazWeTransGeo_Click(object sender, EventArgs e)
        {

        }
    }
}
