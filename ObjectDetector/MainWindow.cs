using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using ObjectDetector.Models;

namespace ObjectDetector
{
    public partial class MainWindow : Form
    {
        public Bitmap Bitmap { get; set; }
        public List<Bitmap> CollectionOfBitmapTransformations { get; set; }
        private readonly ImageTransformations imageTransformations;
        private ObjectDetectionAlgorithms objectDetectionAlgorithms;
        private Bitmap surfTemplate;
        private Bitmap resultOfDetection;
        private readonly Task getReadyToImageDetectionTask;
        public MainWindow()
        {
            InitializeComponent();
            AppDomain.CurrentDomain.ProcessExit += OnProcessExit;

            imageTransformations = new ImageTransformations();
            CollectionOfBitmapTransformations = new List<Bitmap>();
            Bitmap = new Bitmap(Properties.Resources.Lena);
            getReadyToImageDetectionTask = new Task(GetReadyToImageDetection);

            getReadyToImageDetectionTask.Start();
            gb_imageDetectionTools.Enabled = false;
            pb_entranceImage.Image = Bitmap;

            rTB_loggerOfImageTransformationHistory.Text += @"Obraz domyślny," + Environment.NewLine;
        }
        private void OnProcessExit(object sender, EventArgs e)
        {
            getReadyToImageDetectionTask.Dispose();
        }
        public string HistoryOfImageTransformation
        {
            get { return rTB_loggerOfImageTransformationHistory.Text; }
            set { rTB_loggerOfImageTransformationHistory.Text = value; }
        }
        private void LoadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CollectionOfBitmapTransformations.Clear();
                Bitmap = new Bitmap(Image.FromFile(openFileDialog.FileName));
                pb_entranceImage.Image = Bitmap;
                CollectionOfBitmapTransformations.Add(Bitmap);
                rTB_loggerOfImageTransformationHistory.Clear();
                rTB_loggerOfImageTransformationHistory.Text += @"Obraz domyślny," + Environment.NewLine;
            }
        }
        private void ApplicationExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void saveResultOfObjectDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"Images|*.png;*.bmp;*.jpg";

            if(resultOfDetection != null && saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(Bitmap != null && saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var imageFormat = ImageFormatManager(System.IO.Path.GetExtension(saveFileDialog1.FileName));
                    Bitmap.Save(saveFileDialog1.FileName, imageFormat);
                }
            }
            else
            {
                MessageBox.Show(@"Operacja detekcji nie została przeprowadzona");
            }
        }
        private void saveFormOfAnalizedImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = @"Images|*.png;*.bmp;*.jpg";
            if(Bitmap != null && saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var imageFormat = ImageFormatManager(System.IO.Path.GetExtension(saveFileDialog1.FileName));
                Bitmap.Save(saveFileDialog1.FileName, imageFormat);
            }
            else
            {
                MessageBox.Show(@"Nie wczytano obrazu");
            }
        }
        private ImageFormat ImageFormatManager(string saveDialogSelectedFileNameExtension)
        {
            var imageFormat = new ImageFormat(Guid.Empty);

            switch(saveDialogSelectedFileNameExtension)
            {
                case ".jpg":
                    imageFormat = ImageFormat.Jpeg;
                    break;
                case ".bmp":
                    imageFormat = ImageFormat.Bmp;
                    break;
                case ".png":
                    imageFormat = ImageFormat.Png;
                    break;
            }

            return imageFormat;
        }
        private void histogramOfImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ImageHistogramWindow(this).Show();
        }
        private void geometricalTransformationOfImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GeometricalTransformationWindow(this).Show();
        }
        private void imageMedianFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap = imageTransformations.MedianFilter(Bitmap, 3);
            pb_entranceImage.Image = Bitmap;
            CollectionOfBitmapTransformations.Add(Bitmap);
            rTB_loggerOfImageTransformationHistory.Text += @"Filtr medianowy," + Environment.NewLine;
        }
        private void imageBinarizationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new BinarizationWindow(this).Show();
        }
        private void monochromeImageTransformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap = imageTransformations.GrayScaleTransformation(Bitmap);
            pb_entranceImage.Image = Bitmap;
            CollectionOfBitmapTransformations.Add(Bitmap);
            rTB_loggerOfImageTransformationHistory.Text += @"Odcienie szarości," + Environment.NewLine;
        }
        private void levelOfImageBrightnessContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BrightnessOperationWindow(this).Show();
        }
        private void StartSearchingObject(object sender, EventArgs e)
        {
            var obiektDoWyszukania = cb_wyborObiektu.SelectedItem.ToString();
            lb_statusOfSearchingObject.Text = @"Wyszukiwanie obiektu w toku...";
            lb_statusOfSearchingObject.Refresh();

            if(rb_violaJonesMethod.Checked)
            {
                Bitmap = objectDetectionAlgorithms.ViolaJones(Bitmap, obiektDoWyszukania);
                lb_statusOfSearchingObject.Text = @"Wyszukiwanie zakończone";
            }
            if(rb_surfMethod.Checked)
            {
                Bitmap = objectDetectionAlgorithms.Surf(Bitmap, surfTemplate);
                lb_statusOfSearchingObject.Text = @"Wyszukiwanie zakończone";
            }
            if(rb_hogMethod.Checked)
            {
                Bitmap = objectDetectionAlgorithms.Hog(Bitmap);
                lb_statusOfSearchingObject.Text = @"Wyszukiwanie zakończone";
            }
            new ObjectDetectionWindow(this).Show();
            resultOfDetection = Bitmap;
            Bitmap = new Bitmap(pb_entranceImage.Image);

        }
        private void GetReadyToImageDetection()
        {
            objectDetectionAlgorithms = new ObjectDetectionAlgorithms();

            lb_statusOfSearchingObject.Invoke(new Action(delegate
            {
                lb_statusOfSearchingObject.Text = @"Algorytm wyszukiwania obiektu na obrazie cyfrowym jest gotowy do użycia";
            }));

            gb_imageDetectionTools.Invoke(new Action(delegate
            {
                gb_imageDetectionTools.Enabled = true;
            }));
        }
        private void ManagerOfComboboxElementList(object sender, EventArgs e)
        {
            cb_wyborObiektu.Items.Clear();
            if(rb_surfMethod.Checked)
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    surfTemplate = new Bitmap(Image.FromFile(openFileDialog.FileName));
                }
                cb_wyborObiektu.Items.Add("Wzorzec SURF");
            }
            if(rb_violaJonesMethod.Checked)
            {
                cb_wyborObiektu.Items.Add("Twarz");
                cb_wyborObiektu.Items.Add("Góra ciała");
                cb_wyborObiektu.Items.Add("Usta");
                cb_wyborObiektu.Items.Add("Nos");
            }
            if(rb_hogMethod.Checked)
            {
                cb_wyborObiektu.Items.Add("Ludzka sylwetka");
            }
            cb_wyborObiektu.SelectedIndex = 0;
        }
        private void UndoTransformationChanges(object sender, EventArgs e)
        {
            if(CollectionOfBitmapTransformations.Count > 1)
            {
                var transformationHistoryPositionOfActualImage = CollectionOfBitmapTransformations.Count - 1;

                pb_entranceImage.Image = CollectionOfBitmapTransformations[transformationHistoryPositionOfActualImage - 1];
                Bitmap = CollectionOfBitmapTransformations[transformationHistoryPositionOfActualImage - 1];
                CollectionOfBitmapTransformations.RemoveAt(transformationHistoryPositionOfActualImage);

                var lastPositionOfrichTextBoxHistoryLogger = rTB_loggerOfImageTransformationHistory.Text.LastIndexOf(",", StringComparison.Ordinal);
                if(lastPositionOfrichTextBoxHistoryLogger > 1)
                {
                    rTB_loggerOfImageTransformationHistory.Text = rTB_loggerOfImageTransformationHistory.Text.Substring(0, lastPositionOfrichTextBoxHistoryLogger - 1);
                    var penultimatePositionOfrichTextBoxHistoryLogger = rTB_loggerOfImageTransformationHistory.Text.LastIndexOf(",", StringComparison.Ordinal);
                    rTB_loggerOfImageTransformationHistory.Text = rTB_loggerOfImageTransformationHistory.Text.Substring(0, penultimatePositionOfrichTextBoxHistoryLogger + 1) + Environment.NewLine;
                }
            }
            else
            {
                MessageBox.Show(@"Wyświetlana jest pierwotna postać obrazu");
            }
        }

        private void informacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Algorytmy szybkiego rozpoznawania obiektów na obrazach cyfrowych\nAutor: Tomasz Maleszyk");
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

    }
}
