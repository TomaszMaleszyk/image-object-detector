using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectDetector
{
    public partial class GeometricalTransformationWindow : Form
    {
        private readonly ImageTransformations imageTransformations;
        private readonly MainWindow mainWindow;
        private Bitmap operationalBitmap;
        private Bitmap cutedFragmentOfImageBitmap;
        private float ratioOfAngle;
        private int zoomPosition;
        private int outputHeight;
        private int outputWidth;
        private int inputWidthFragmentToCut;
        private int inputHeightFragmentToCut;
        private int outputWidthFragmentToCut;
        private int outputHeightFragmentToCut;

        public GeometricalTransformationWindow(MainWindow okno)
        {
            mainWindow = okno;

            imageTransformations = new ImageTransformations();
            operationalBitmap = new Bitmap(okno.Bitmap);
            cutedFragmentOfImageBitmap = operationalBitmap;
            ratioOfAngle = 0;
            zoomPosition = 0;
            outputHeight = operationalBitmap.Height;
            outputWidth = operationalBitmap.Width;

            InitializeComponent();
        }

        private void OknoTransformacjiGeometrycznych_Load(object sender, EventArgs e)
        {
            txtb_setAngleOfImageRotation.Text = @"1";
            pb_inputImage.Image = mainWindow.Bitmap;

            trackb_setWidth.Maximum = operationalBitmap.Width;
            trackb_setHeight.Maximum = operationalBitmap.Height;
            trackb_setWidth.Minimum = 1;
            trackb_setHeight.Minimum = 1;
            trackb_setWidth.Value = operationalBitmap.Width;
            trackb_setHeight.Value = operationalBitmap.Height;

            inputWidthFragmentToCut = 0;
            inputHeightFragmentToCut = 0;
            outputWidthFragmentToCut = 100;
            outputHeightFragmentToCut = 100;

            numericUD_inputWidth.Value = inputWidthFragmentToCut;
            numericUD_inputHeight.Value = inputHeightFragmentToCut;
            numericUD_widthToCut.Value = outputWidthFragmentToCut;
            numericUD_heightToCut.Value = outputHeightFragmentToCut;

            numericUD_inputWidth.Maximum = operationalBitmap.Width - outputWidthFragmentToCut;
            numericUD_inputHeight.Maximum = operationalBitmap.Height - outputHeightFragmentToCut;
            numericUD_widthToCut.Maximum = operationalBitmap.Width;
            numericUD_heightToCut.Maximum = operationalBitmap.Height;
        }
        private void RotationToTheRight(object sender, EventArgs e)
        {
            try
            {
                ratioOfAngle += float.Parse(txtb_setAngleOfImageRotation.Text);
            }
            catch(Exception)
            {
                MessageBox.Show(@"Proszę podać poprawne dane");
            }
            pb_inputImage.Image = imageTransformations.RotatingOfImage(new Bitmap(pb_inputImage.Image), ratioOfAngle);
            cutedFragmentOfImageBitmap = new Bitmap(pb_inputImage.Image);
        }
        private void RotationToTheLeft(object sender, EventArgs e)
        {
            try
            {
                ratioOfAngle -= float.Parse(txtb_setAngleOfImageRotation.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Proszę podać poprawne dane");
            }
            pb_inputImage.Image = imageTransformations.RotatingOfImage(new Bitmap(pb_inputImage.Image), ratioOfAngle);
            cutedFragmentOfImageBitmap = new Bitmap(pb_inputImage.Image);
        }
        private void ConfirmOperations(object sender, EventArgs e)
        {
            mainWindow.pb_entranceImage.Image = imageTransformations.CutImage(new Bitmap(pb_inputImage.Image), pb_inputImage.Width, pb_inputImage.Height);
            mainWindow.Bitmap = new Bitmap(mainWindow.pb_entranceImage.Image);
            mainWindow.CollectionOfBitmapTransformations.Add(mainWindow.Bitmap);
            mainWindow.HistoryOfImageTransformation += "Przekształcenie geometryczne," + Environment.NewLine;

            Close();
        }

        private void SetZoomPosition(object sender, EventArgs e)
        {
            const double scale = 1.1;
            if(trackb_imageZoomManipulator.Value > zoomPosition)
            {
                pb_inputImage.Image = imageTransformations.ApproximateDistanceToImage(new Bitmap(pb_inputImage.Image), scale);
                operationalBitmap = new Bitmap(pb_inputImage.Image);
            }
            if(trackb_imageZoomManipulator.Value < zoomPosition)
            {
                pb_inputImage.Image = imageTransformations.IncreaseDistanceToImage(new Bitmap(pb_inputImage.Image), scale);
                operationalBitmap = new Bitmap(pb_inputImage.Image);
            }

            zoomPosition = trackb_imageZoomManipulator.Value;
        }

        private void SetHeightOfInputImage(object sender, EventArgs e)
        {
            outputHeight = trackb_setHeight.Value;

            pb_inputImage.Image = imageTransformations.ChangeSizeOfImage(operationalBitmap, outputWidth, outputHeight);
        }

        private void SetWidthOfInputImage(object sender, EventArgs e)
        {
            outputWidth = trackb_setWidth.Value;
            pb_inputImage.Image = imageTransformations.ChangeSizeOfImage(operationalBitmap, outputWidth, outputHeight);
        }

        private void numericUD_szerPocz_ValueChanged(object sender, EventArgs e)
        {
            inputWidthFragmentToCut = int.Parse(numericUD_inputWidth.Text);
            pb_inputImage.Image = imageTransformations.CutAreaFromImage(cutedFragmentOfImageBitmap, inputWidthFragmentToCut, inputHeightFragmentToCut, outputWidthFragmentToCut, outputHeightFragmentToCut);
        }

        private void numericUD_wysPocz_ValueChanged(object sender, EventArgs e)
        {
            inputHeightFragmentToCut = int.Parse(numericUD_inputHeight.Text);
            pb_inputImage.Image = imageTransformations.CutAreaFromImage(cutedFragmentOfImageBitmap, inputWidthFragmentToCut, inputHeightFragmentToCut, outputWidthFragmentToCut, outputHeightFragmentToCut);
        }
        private void numericUD_szerPrzyc_ValueChanged(object sender, EventArgs e)
        {
            outputWidthFragmentToCut = int.Parse(numericUD_widthToCut.Text);
            pb_inputImage.Image = imageTransformations.CutAreaFromImage(cutedFragmentOfImageBitmap, inputWidthFragmentToCut, inputHeightFragmentToCut, outputWidthFragmentToCut, outputHeightFragmentToCut);
            numericUD_inputWidth.Maximum = operationalBitmap.Width - outputWidthFragmentToCut;
        }
        private void numericUD_wysPrzyc_ValueChanged(object sender, EventArgs e)
        {
            outputHeightFragmentToCut = int.Parse(numericUD_heightToCut.Text);
            pb_inputImage.Image = imageTransformations.CutAreaFromImage(cutedFragmentOfImageBitmap, inputWidthFragmentToCut, inputHeightFragmentToCut, outputWidthFragmentToCut, outputHeightFragmentToCut);

            numericUD_inputHeight.Maximum = operationalBitmap.Height - outputHeightFragmentToCut;

        }
        private void ConfirmCuttingImage(object sender, EventArgs e)
        {
            pb_inputImage.Image = imageTransformations.CutFragmentOfImage(cutedFragmentOfImageBitmap, inputWidthFragmentToCut, inputHeightFragmentToCut, outputWidthFragmentToCut, outputHeightFragmentToCut);
            cutedFragmentOfImageBitmap = new Bitmap(pb_inputImage.Image);
        }

        private void pb_obrazWeTransGeo_Click(object sender, EventArgs e)
        {

        }
    }
}
