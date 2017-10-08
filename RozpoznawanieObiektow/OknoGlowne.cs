using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Drawing.Imaging;

namespace RozpoznawanieObiektow
{
    public partial class OknoGlowne : Form
    {
        public Bitmap bitmapa;

        public List<Bitmap> listaObrazow;

        private PrzeksztalceniaObrazu przeksztalcenia;

        private WyszukiwanieObiektu wyszukajObiekt;

        private Bitmap wzorzecSURF;

        private Bitmap wynikDetekcjiBmp;

        private Thread watek;

        public OknoGlowne()
        {
            InitializeComponent();

            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

            przeksztalcenia = new PrzeksztalceniaObrazu();
            listaObrazow = new List<Bitmap>();
            watek = new Thread(przygotujSieDoWyszukiwaniaObiektow);

            watek.Start();

            gb_narzedziaWyszObie.Enabled = false;

            bitmapa = new Bitmap(RozpoznawanieObiektow.Properties.Resources.Lena);
            pb_obrazWe.Image = bitmapa;
            rTB_historiaOperacji.Text += "Obraz domyślny," + Environment.NewLine;
        }
        void OnProcessExit(object sender, EventArgs e)
        {
            watek.Abort();
        }
        public String UstalHistorieTransformacjiObrazu
        {
            get { return this.rTB_historiaOperacji.Text; }
            set { this.rTB_historiaOperacji.Text = value; }
        }
        private void wczytajObrazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listaObrazow.Clear();
                bitmapa = new Bitmap(Image.FromFile(this.openFileDialog1.FileName));
                pb_obrazWe.Image = bitmapa;
                listaObrazow.Add(bitmapa);
                rTB_historiaOperacji.Clear();
                rTB_historiaOperacji.Text += "Obraz domyślny," + Environment.NewLine;
            }
        }
        private void zakończDziałanieProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void zapiszWynikDetekcjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;

            if (wynikDetekcjiBmp != null && saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }
                wynikDetekcjiBmp.Save(saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Operacja detekcji nie została przeprowadzona");
            }
        }
        private void zapiszPostaćAnalizowanegoObrazuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;

            if (bitmapa != null && saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                }
                bitmapa.Save(saveFileDialog1.FileName);
            }
            else
            {
                MessageBox.Show("Nie wczytano obrazu");
            }
        }
        private void histogramObrazuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OknoHistogramu(this).Show();
        }
        private void przekształceniaGeometyryczneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OknoTransformacjiGeometrycznych(this).Show();
        }
        private void filtrMedianowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmapa = przeksztalcenia.FiltrMedianowy(bitmapa, 3);
            pb_obrazWe.Image = bitmapa;
            listaObrazow.Add(bitmapa);
            rTB_historiaOperacji.Text += "Filtr medianowy," + Environment.NewLine;
        }
        private void binaryzacjaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new OknoBinaryzacja(this).Show();
        }
        private void odcienieSzarościToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bitmapa = przeksztalcenia.OdcienieSzarosci(bitmapa);
            pb_obrazWe.Image = bitmapa;
            listaObrazow.Add(bitmapa);
            rTB_historiaOperacji.Text += "Odcienie szarości," + Environment.NewLine;
        }
        private void poziomJasnościKontrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OknoJasnoscOperacje(this).Show();
        }
        private void btn_wyszukajObiekt_Click(object sender, EventArgs e)
        {
            string obiektDoWyszukania = cb_wyborObiektu.SelectedItem.ToString();
            lb_komunikatWyszObie.Text = "Wyszukiwanie obiektu w toku...";
            lb_komunikatWyszObie.Refresh();

            if (rb_WyborMetViolaJones.Checked == true)
            {
                bitmapa = wyszukajObiekt.ViolaJones(bitmapa, obiektDoWyszukania);
                lb_komunikatWyszObie.Text = "Wyszukiwanie zakończone";
            }
            if (rb_WyborMetSURF.Checked == true)
            {
                bitmapa = wyszukajObiekt.SURF(bitmapa, wzorzecSURF);
                lb_komunikatWyszObie.Text = "Wyszukiwanie zakończone";
            }
            if (rb_WyborMetHOG.Checked == true)
            {
                bitmapa = wyszukajObiekt.HOG(bitmapa);
                lb_komunikatWyszObie.Text = "Wyszukiwanie zakończone";
            }
            new OknoDetekcjiObiektu(this).Show();
            wynikDetekcjiBmp = bitmapa;
            bitmapa = new Bitmap(pb_obrazWe.Image);

        }
        private void przygotujSieDoWyszukiwaniaObiektow()
        {
            wyszukajObiekt = new WyszukiwanieObiektu();
            lb_komunikatWyszObie.Invoke(new Action(delegate ()
            {
                lb_komunikatWyszObie.Text = "Algorytm wyszukiwania obiektu na obrazie cyfrowym jest gotowy do użycia";
            }));
            gb_narzedziaWyszObie.Invoke(new Action(delegate ()
            {
                gb_narzedziaWyszObie.Enabled = true;
            }));
        }
        private void nadzorujListeElementow_cb_wyborObiektu(object sender, EventArgs e)
        {
            cb_wyborObiektu.Items.Clear();
            if (rb_WyborMetSURF.Checked == true)
            {
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    wzorzecSURF = new Bitmap(Image.FromFile(this.openFileDialog1.FileName));
                }
                cb_wyborObiektu.Items.Add("Wzorzec SURF");
            }
            if (rb_WyborMetViolaJones.Checked == true)
            {
                cb_wyborObiektu.Items.Add("Twarz");
                cb_wyborObiektu.Items.Add("Góra ciała");
                cb_wyborObiektu.Items.Add("Usta");
                cb_wyborObiektu.Items.Add("Nos");
            }
            if (rb_WyborMetHOG.Checked == true)
            {
                cb_wyborObiektu.Items.Add("Ludzka sylwetka");
            }
            cb_wyborObiektu.SelectedIndex = 0;
        }

        private void btn_cofnijPrzekObr_Click(object sender, EventArgs e)
        {
            if (listaObrazow.Count > 1)
            {
                int pozycjaAktualnegoObrazu = listaObrazow.Count - 1;

                pb_obrazWe.Image = listaObrazow[pozycjaAktualnegoObrazu - 1];
                bitmapa = listaObrazow[pozycjaAktualnegoObrazu - 1];
                listaObrazow.RemoveAt(pozycjaAktualnegoObrazu);

                int ostatniaPozycjaRTB = rTB_historiaOperacji.Text.LastIndexOf(",");
                if (ostatniaPozycjaRTB > 1)
                {
                    rTB_historiaOperacji.Text = rTB_historiaOperacji.Text.Substring(0, ostatniaPozycjaRTB - 1);
                    int przedostatniaPozycjaRTB = rTB_historiaOperacji.Text.LastIndexOf(",");
                    rTB_historiaOperacji.Text = rTB_historiaOperacji.Text.Substring(0, przedostatniaPozycjaRTB + 1) + Environment.NewLine;
                }
            }
            else
            {
                MessageBox.Show("Wyświetlana jest pierwotna postać obrazu");
            }
        }

        private void informacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Algorytmy szybkiego rozpoznawania obiektów na obrazach cyfrowych\nAutor: Tomasz Maleszyk");
        }

        private void OknoGlowne_Load(object sender, EventArgs e)
        {

        }

    }
}
