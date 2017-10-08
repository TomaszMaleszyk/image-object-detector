using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectDetector
{
    public partial class BinarizationWindow : Form
    {
        private readonly MainWindow mainWindow;
        private readonly ImageTransformations imageTransformations;
        private Bitmap operationalBitmap;
        public BinarizationWindow(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
            imageTransformations = new ImageTransformations();
            operationalBitmap = new Bitmap(this.mainWindow.Bitmap);

            pb_inputImageBinarization.Image = this.mainWindow.Bitmap;
            rb_userThreshold.Checked = true;
            lb_userThreshold.Text = trackb_binarizationThreshold.Value.ToString();
        }
        private void ChangeThresholdValue(object sender, EventArgs e)
        {
            var binarizationThreshold = trackb_binarizationThreshold.Value;
            lb_userThreshold.Text = binarizationThreshold.ToString();
        }
        private void BinarizationOfInputImage(object sender, MouseEventArgs e)
        {
            operationalBitmap = new Bitmap(mainWindow.Bitmap);

            var binarizationThreshold = trackb_binarizationThreshold.Value;
            pb_inputImageBinarization.Image = imageTransformations.Binarization(operationalBitmap, binarizationThreshold);
        }
        private void ControlRadioButtonsActivity(object sender, EventArgs e)
        {
            if(rb_userThreshold.Checked)
            {
                trackb_binarizationThreshold.Enabled = true;
                lb_OtsuThreshold.Enabled = false;
            }
            if(rb_otsuThreshold.Checked)
            {
                operationalBitmap = new Bitmap(mainWindow.Bitmap);

                lb_OtsuThreshold.Enabled = true;
                trackb_binarizationThreshold.Enabled = false;

                var thresholdOtsu = (int)imageTransformations.OtsuThreshold(operationalBitmap);
                lb_OtsuThreshold.Text = $@"Próg Otsu wynosi: {thresholdOtsu}";
                pb_inputImageBinarization.Image = imageTransformations.Binarization(operationalBitmap, thresholdOtsu);
            }
        }
        private void ConfirmOperations(object sender, EventArgs e)
        {
            mainWindow.Bitmap = new Bitmap(pb_inputImageBinarization.Image);
            mainWindow.pb_entranceImage.Image = mainWindow.Bitmap;
            mainWindow.CollectionOfBitmapTransformations.Add(mainWindow.Bitmap);
            mainWindow.HistoryOfImageTransformation += "Binarization," + Environment.NewLine;
            Close();
        }
    }
}
