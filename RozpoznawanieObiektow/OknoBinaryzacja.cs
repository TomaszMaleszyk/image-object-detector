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
    public partial class OknoBinaryzacja : Form
    {
        private OknoGlowne oknoGlowne;

        private PrzeksztalceniaObrazu przeksztalcenia = new PrzeksztalceniaObrazu();

        private Bitmap bitmapaOperacyjna;

        public OknoBinaryzacja(OknoGlowne okno)
        {
            oknoGlowne = okno;
            InitializeComponent();
            pb_obrazWeBinaryzacja.Image = oknoGlowne.bitmapa;

            bitmapaOperacyjna = new Bitmap(oknoGlowne.bitmapa);

            rb_progUzytkownika.Checked = true;
            lb_progUzytkownika.Text = trackb_progBinaryzacji.Value.ToString();
        }  
        private void tb_progBinaryzacji_Scroll(object sender, EventArgs e)
        {
            int progBinaryzacji = trackb_progBinaryzacji.Value;

            lb_progUzytkownika.Text = progBinaryzacji.ToString();

        }
    
        private void btn_zatwierdz_Click(object sender, EventArgs e)
        {
            oknoGlowne.bitmapa = new Bitmap(pb_obrazWeBinaryzacja.Image);
            oknoGlowne.pb_obrazWe.Image = oknoGlowne.bitmapa;
            oknoGlowne.listaObrazow.Add(oknoGlowne.bitmapa);
            oknoGlowne.UstalHistorieTransformacjiObrazu += "Binaryzacja," + Environment.NewLine;
            Close();
        }
        private void KontrolaRadioButtonow(object sender, EventArgs e)
        {
            if (rb_progUzytkownika.Checked == true)
            {
                trackb_progBinaryzacji.Enabled = true;
                lb_progOtsu.Enabled = false;
            }
            if (rb_progOtsu.Checked == true)
            {
                bitmapaOperacyjna = new Bitmap(oknoGlowne.bitmapa);

                lb_progOtsu.Enabled = true;
                trackb_progBinaryzacji.Enabled = false;

                int progOtsu = (int) przeksztalcenia.ProgOtsu(bitmapaOperacyjna);
                lb_progOtsu.Text = string.Format("Próg Otsu wynosi: {0}", progOtsu); // tu jest jakiś problem z wyświetlaniem
                pb_obrazWeBinaryzacja.Image = przeksztalcenia.Binaryzacja(bitmapaOperacyjna,progOtsu);
            }
        }
        private void trackb_progBinaryzacji_MouseUp(object sender, MouseEventArgs e)
        {
            bitmapaOperacyjna = new Bitmap(oknoGlowne.bitmapa);

            int progBinaryzacji = trackb_progBinaryzacji.Value;
            pb_obrazWeBinaryzacja.Image = przeksztalcenia.Binaryzacja(bitmapaOperacyjna, progBinaryzacji);
        }
    }
}
