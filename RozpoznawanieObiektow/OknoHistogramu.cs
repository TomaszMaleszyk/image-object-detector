using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozpoznawanieObiektow
{
    public partial class OknoHistogramu : Form
    {
        private OknoGlowne oknoGlowne;

        private PrzeksztalceniaObrazu przeksztalcenia;

        private MiaryStatystyczneObrazu miary;

        private Bitmap bitmapaOperacyjna;

        public OknoHistogramu(OknoGlowne okno)
        {
            oknoGlowne = okno;
            bitmapaOperacyjna = new Bitmap(oknoGlowne.bitmapa);
            przeksztalcenia = new PrzeksztalceniaObrazu();
            miary = new MiaryStatystyczneObrazu();

            InitializeComponent();

            pb_obrazWeHistogram.Image = oknoGlowne.bitmapa;
            pb_histogramObrazu.Image = (new Bitmap(255, pb_histogramObrazu.Height));
            cb_kanalHistogramu.SelectedIndex = 0;
            rb_histogram.Checked = true;
        }
        private void wybierzRodzajHistogramu(object sender, EventArgs e)
        {
            string kolorKanalu = cb_kanalHistogramu.SelectedItem.ToString();
            Color kolorKan = new Color();

            kontrolaDostepnosciComboBox();

            switch (kolorKanalu)
            {
                case "Czerwony":
                    kolorKan = Color.Red;
                    break;
                case "Zielony":
                    kolorKan = Color.Green;
                    break;
                case "Niebieski":
                    kolorKan = Color.Blue;
                    break;
                case "Szary":
                    kolorKan = Color.Gray;
                    break;
            }
            if (rb_histogramLiniowy.Checked == true)
            {
                pb_histogramObrazu.Image = przeksztalcenia.ObliczHistogramLiniowy(bitmapaOperacyjna, new Bitmap(pb_histogramObrazu.Image));
            }
            else if (rb_histogram.Checked == true)
            {
                pb_histogramObrazu.Image = przeksztalcenia.ObliczHistogram(bitmapaOperacyjna, new Bitmap(pb_histogramObrazu.Image), kolorKan);
            }
        }
        private void cb_kanalHistogramu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kolorKanalu = cb_kanalHistogramu.SelectedItem.ToString();
            Color kolorKan = new Color();

            switch (kolorKanalu)
            {
                case "Czerwony":
                    kolorKan = Color.Red;
                    break;
                case "Zielony":
                    kolorKan = Color.Green;
                    break;
                case "Niebieski":
                    kolorKan = Color.Blue;
                    break;
                case "Szary":
                    kolorKan = Color.Gray;
                    break;
            }

            pb_histogramObrazu.Image = przeksztalcenia.ObliczHistogram(bitmapaOperacyjna, new Bitmap(pb_histogramObrazu.Image), kolorKan);

            lb_wartoscSrednia.Text = miary.SredniaJasnoscPiksela(bitmapaOperacyjna, kolorKanalu).ToString();
            lb_wartoscMin.Text = miary.NajciemniejszyPikselObrazu(bitmapaOperacyjna, kolorKanalu).ToString();
            lb_wartoscMax.Text = miary.NajjasniejszyPikselObrazu(bitmapaOperacyjna, kolorKanalu).ToString();
            lb_wartoscKontrast.Text = miary.WartoscKontrastu(bitmapaOperacyjna, kolorKanalu).ToString();
            lb_wartoscWariancja.Text = miary.WartoscWariancji(bitmapaOperacyjna, kolorKanalu).ToString();
            lb_wartoscOdchylenie.Text = miary.WartoscOdchylenia(bitmapaOperacyjna, kolorKanalu).ToString();

            lb_wartoscAnalizKolor.Text = kolorKanalu;

        }
        private void kontrolaDostepnosciComboBox()
        {
            if (rb_histogramLiniowy.Checked == true)
            {
                cb_kanalHistogramu.Enabled = false;
            }
            if (rb_histogram.Checked == true)
            {
                cb_kanalHistogramu.Enabled = true;
            }
        }
        private void btn_wyrownajHistogram_Click(object sender, EventArgs e)
        {
            pb_obrazWeHistogram.Image = przeksztalcenia.WyrownanieHistogramu(bitmapaOperacyjna);
            RysujKomunikat();
            lb_wartoscKontrast.Text = "0000";
            lb_wartoscMax.Text = "0000";
            lb_wartoscMin.Text = "0000";
            lb_wartoscOdchylenie.Text = "0000";
            lb_wartoscSrednia.Text = "0000";
            lb_wartoscAnalizKolor.Text = "0000";
            lb_wartoscWariancja.Text = "0000";
        }
        private void btn_zatwierdz_Click(object sender, EventArgs e)
        {
            oknoGlowne.pb_obrazWe.Image = pb_obrazWeHistogram.Image;
            oknoGlowne.bitmapa = new Bitmap(oknoGlowne.pb_obrazWe.Image);
            oknoGlowne.listaObrazow.Add(oknoGlowne.bitmapa);
            oknoGlowne.UstalHistorieTransformacjiObrazu += "Operacja wyrównania histogramu," + Environment.NewLine;

            Close();
        }
        private void RysujKomunikat()
        {
            Bitmap histogram = new Bitmap(pb_histogramObrazu.Image);
            Graphics gr = Graphics.FromImage(histogram);
            SolidBrush kolorPedzla = new SolidBrush(Color.Black);
            Font czcionka = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);
            string komunikat = string.Format("ZOSTAŁA{0}PRZEPROWADZONA{0}OPERACJA{0}WYRÓWNYWANIA{0}HISTOGRAMU{0}---{0}HISTOGRAM{0}NIEAKTUALNY", Environment.NewLine);

            gr.DrawString(komunikat, czcionka, kolorPedzla, 10, 10);
            pb_histogramObrazu.Image = histogram;
        }

        private void OknoHistogramu_Load(object sender, EventArgs e)
        {

        }
    }
}
