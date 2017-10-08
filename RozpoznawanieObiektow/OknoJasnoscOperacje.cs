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
    public partial class OknoJasnoscOperacje : Form
    {
        OknoGlowne oknoGlowne;
        Bitmap bitmapaOperacyjna;
        PrzeksztalceniaObrazu przeksztalcenia;
        public OknoJasnoscOperacje(OknoGlowne okno)
        {
            oknoGlowne = okno;
            InitializeComponent();
            przeksztalcenia = new PrzeksztalceniaObrazu();

            pb_obrazWeJasnosc.Image = oknoGlowne.bitmapa;

            bitmapaOperacyjna = new Bitmap(oknoGlowne.bitmapa);
            rb_jasnoscObrazu.Checked = true;

            lb_poziom.Text = "Poziom min: " + trackb_poziom.Minimum.ToString() + Environment.NewLine+ "Poziom max: " + trackb_poziom.Maximum.ToString() + Environment.NewLine + "Aktualny poziom: " + trackb_poziom.Value.ToString();
        }
        private void KontrolaRadioButtonow(object sender, EventArgs e)
        {
            if (rb_jasnoscObrazu.Checked == true)
            {
                trackb_poziom.Minimum = -255;
                trackb_poziom.Maximum = 255;
                trackb_poziom.Value = 0;
                lb_poziom.Text = "Poziom min: " + trackb_poziom.Minimum.ToString() + Environment.NewLine + "Poziom max: " + trackb_poziom.Maximum.ToString() + Environment.NewLine + "Aktualny poziom: " + trackb_poziom.Value.ToString();
            }
            if (rb_kontrast.Checked == true)
            {
                trackb_poziom.Minimum = -100;
                trackb_poziom.Maximum = 100;
                trackb_poziom.Value = 0;
                lb_poziom.Text = "Poziom min: " + trackb_poziom.Minimum.ToString() + Environment.NewLine + "Poziom max: " + trackb_poziom.Maximum.ToString() + Environment.NewLine + "Aktualny poziom: " + trackb_poziom.Value.ToString();
            }
        }

        private void trackb_poziom_Scroll(object sender, EventArgs e)
        {
            int poziom = trackb_poziom.Value;

            lb_poziom.Text = "Poziom min: " + trackb_poziom.Minimum.ToString() + Environment.NewLine + "Poziom max: " + trackb_poziom.Maximum.ToString() + Environment.NewLine + "Aktualny poziom: " + trackb_poziom.Value.ToString();
        }
        private void btn_zatwierdz_Click(object sender, EventArgs e)
        {
            oknoGlowne.pb_obrazWe.Image = pb_obrazWeJasnosc.Image;
            oknoGlowne.bitmapa = new Bitmap(oknoGlowne.pb_obrazWe.Image);
            oknoGlowne.listaObrazow.Add(oknoGlowne.bitmapa);
            oknoGlowne.UstalHistorieTransformacjiObrazu += "Operacja na poziomie jasności pikseli," + Environment.NewLine;

            Close();
        }
        private void trackb_poziom_MouseUp(object sender, MouseEventArgs e)
        {
            int poziom = trackb_poziom.Value;
            if (rb_jasnoscObrazu.Checked == true)
            {
                pb_obrazWeJasnosc.Image = przeksztalcenia.UstalJasnosciObrazu(bitmapaOperacyjna, poziom);
            }
            if (rb_kontrast.Checked == true)
            {
                pb_obrazWeJasnosc.Image = przeksztalcenia.UstalKontrastObrazu(bitmapaOperacyjna, poziom);
            }
        }
    }
}
