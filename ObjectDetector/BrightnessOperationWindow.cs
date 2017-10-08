using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectDetector
{
    public partial class BrightnessOperationWindow : Form
    {
        private readonly MainWindow mainWindow;
        private readonly ImageTransformations imageTransformations;
        private readonly Bitmap operationalBitmap;
        public BrightnessOperationWindow(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
            imageTransformations = new ImageTransformations();

            pb_inputImage.Image = this.mainWindow.Bitmap;

            operationalBitmap = new Bitmap(this.mainWindow.Bitmap);
            rb_brightnessOfImage.Checked = true;

            lb_levelOfOperation.Text = @"Poziom min: " + trackb_levelOfOperation.Minimum + Environment.NewLine
                + @"Poziom max: " + trackb_levelOfOperation.Maximum + Environment.NewLine + @"Aktualny poziom: " + trackb_levelOfOperation.Value;
        }
        private void UpdateStatementsAndInputDataOfMainOperation(object sender, EventArgs e)
        {
            if(rb_brightnessOfImage.Checked)
            {
                trackb_levelOfOperation.Minimum = -255;
                trackb_levelOfOperation.Maximum = 255;
                trackb_levelOfOperation.Value = 0;
                lb_levelOfOperation.Text = @"Poziom min: " + trackb_levelOfOperation.Minimum + Environment.NewLine
                    + "Poziom max: " + trackb_levelOfOperation.Maximum + Environment.NewLine + @"Aktualny poziom: " + trackb_levelOfOperation.Value;
            }
            if(rb_contrastOfImage.Checked)
            {
                trackb_levelOfOperation.Minimum = -100;
                trackb_levelOfOperation.Maximum = 100;
                trackb_levelOfOperation.Value = 0;
                lb_levelOfOperation.Text = @"Poziom min: " + trackb_levelOfOperation.Minimum + Environment.NewLine 
                    + @"Poziom max: " + trackb_levelOfOperation.Maximum + Environment.NewLine + @"Aktualny poziom: " + trackb_levelOfOperation.Value;
            }
        }

        private void UpdateOperationChangesOnImage(object sender, EventArgs e)
        {
            var actualLevelOfOperation = trackb_levelOfOperation.Value;

            lb_levelOfOperation.Text = @"Poziom min: " + trackb_levelOfOperation.Minimum + Environment.NewLine 
                + @"Poziom max: " + trackb_levelOfOperation.Maximum + Environment.NewLine + @"Aktualny poziom: " + actualLevelOfOperation;
        }
        private void ConfirmOperationsChanges(object sender, EventArgs e)
        {
            mainWindow.pb_entranceImage.Image = pb_inputImage.Image;
            mainWindow.Bitmap = new Bitmap(mainWindow.pb_entranceImage.Image);
            mainWindow.CollectionOfBitmapTransformations.Add(mainWindow.Bitmap);
            mainWindow.HistoryOfImageTransformation += "Operacja na poziomie jasności pikseli," + Environment.NewLine;

            Close();
        }
        private void PerformMainOperation(object sender, MouseEventArgs e)
        {
            var operationLevel = trackb_levelOfOperation.Value;
            if(rb_brightnessOfImage.Checked)
            {
                pb_inputImage.Image = imageTransformations.SetBrightnessOfImage(operationalBitmap, operationLevel);
            }
            if(rb_contrastOfImage.Checked)
            {
                pb_inputImage.Image = imageTransformations.UstalKontrastObrazu(operationalBitmap, operationLevel);
            }
        }
    }
}
