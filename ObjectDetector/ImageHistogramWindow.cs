using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using ObjectDetector.Models;

namespace ObjectDetector
{
    public partial class ImageHistogramWindow : Form
    {
        private readonly MainWindow mainWindow;
        private readonly ImageTransformations imageTransformations;
        private readonly StatisticsDataOfImage statisticsDataOfImage;
        private readonly Bitmap operatingBitmap;
        public ImageHistogramWindow(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            operatingBitmap = new Bitmap(this.mainWindow.Bitmap);
            imageTransformations = new ImageTransformations();
            statisticsDataOfImage = new StatisticsDataOfImage();

            InitializeComponent();

            pb_entranceImage.Image = this.mainWindow.Bitmap;
            pb_imageHistogram.Image = new Bitmap(255, pb_imageHistogram.Height);
            cb_histogramChannel.SelectedIndex = 0;
            rb_histogram.Checked = true;
        }
        private void OnChooseKindOfHistogram(object sender, EventArgs e)
        {
            var getChannelColor = cb_histogramChannel.SelectedItem.ToString();
            var setChannelColor = GetChannelColor(getChannelColor);

            ControlComboBoxAvailability();

            if(rb_linearHistogram.Checked)
            {
                pb_imageHistogram.Image = imageTransformations.CalculateLinearHistogram(operatingBitmap, new Bitmap(pb_imageHistogram.Image));
            }
            else if(rb_histogram.Checked)
            {
                pb_imageHistogram.Image = imageTransformations.CalculateHistogram(operatingBitmap, new Bitmap(pb_imageHistogram.Image), setChannelColor);
            }
        }
        private void OnShowStatisticMeasuresValues(object sender, EventArgs e)
        {
            var getChannelColor = cb_histogramChannel.SelectedItem.ToString();
            var setChannelColor = GetChannelColor(getChannelColor);

            pb_imageHistogram.Image = imageTransformations.CalculateHistogram(operatingBitmap, new Bitmap(pb_imageHistogram.Image), setChannelColor);

            lb_averageColorValue.Text = statisticsDataOfImage.GetValueAverageBrightnessOfImage(operatingBitmap, getChannelColor).ToString(CultureInfo.InvariantCulture);
            lb_minColorValue.Text = statisticsDataOfImage.GetValueOfTheDarkestPixelOfPicture(operatingBitmap, getChannelColor).ToString(CultureInfo.InvariantCulture);
            lb_maxColorValue.Text = statisticsDataOfImage.GetValueOfTheBrightestPixelOfPicture(operatingBitmap, getChannelColor).ToString(CultureInfo.InvariantCulture);
            lb_contrastValue.Text = statisticsDataOfImage.GetContrastValue(operatingBitmap, getChannelColor).ToString(CultureInfo.InvariantCulture);
            lb_varianceValue.Text = statisticsDataOfImage.GetVarianceValue(operatingBitmap, getChannelColor).ToString(CultureInfo.InvariantCulture);
            lb_abberationValue.Text = statisticsDataOfImage.GetAbberationValue(operatingBitmap, getChannelColor).ToString(CultureInfo.InvariantCulture);

            lb_analizedColorValue.Text = getChannelColor;

        }
        private void ControlComboBoxAvailability()
        {
            if(rb_linearHistogram.Checked)
            {
                cb_histogramChannel.Enabled = false;
            }
            if(rb_histogram.Checked)
            {
                cb_histogramChannel.Enabled = true;
            }
        }
        public Color GetChannelColor(string channelColorName)
        {
            Color channelColor;
            switch(channelColorName)
            {
                case "Czerwony":
                    channelColor = Color.Red;
                    break;
                case "Zielony":
                    channelColor = Color.Green;
                    break;
                case "Niebieski":
                    channelColor = Color.Blue;
                    break;
                case "Szary":
                    channelColor = Color.Gray;
                    break;
                default:
                    channelColor = Color.Empty;
                    break;
            }
            return channelColor;
        }
        private void AlignHistogram(object sender, EventArgs e)
        {
            pb_entranceImage.Image = imageTransformations.AlignmentOfHistogram(operatingBitmap);
            DrawStatementOnOutputPictureBox();
            SetTextValueOfLabels("0000");
        }
        private void DrawStatementOnOutputPictureBox()
        {
            var histogram = new Bitmap(pb_imageHistogram.Image);
            var drawStatement = Graphics.FromImage(histogram);
            var brushColor = new SolidBrush(Color.Black);
            var statementFont = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);
            var statementText = string.Format("ZOSTAŁA{0}PRZEPROWADZONA{0}OPERACJA{0}WYRÓWNYWANIA{0}HISTOGRAMU{0}---{0}HISTOGRAM{0}NIEAKTUALNY", Environment.NewLine);

            drawStatement.DrawString(statementText, statementFont, brushColor, 10, 10);
            pb_imageHistogram.Image = histogram;
        }
        private void SetTextValueOfLabels(string labelText)
        {
            lb_contrastValue.Text = labelText;
            lb_maxColorValue.Text = labelText;
            lb_minColorValue.Text = labelText;
            lb_abberationValue.Text = labelText;
            lb_averageColorValue.Text = labelText;
            lb_analizedColorValue.Text = labelText;
            lb_varianceValue.Text = labelText;
        }
        private void ConfirmOperation(object sender, EventArgs e)
        {
            mainWindow.pb_entranceImage.Image = pb_entranceImage.Image;
            mainWindow.Bitmap = new Bitmap(mainWindow.pb_entranceImage.Image);
            mainWindow.CollectionOfBitmapTransformations.Add(mainWindow.Bitmap);
            mainWindow.HistoryOfImageTransformation += "Operacja wyrównania histogramu," + Environment.NewLine;

            Close();
        }
        private void OknoHistogramu_Load(object sender, EventArgs e)
        {

        }
    }
}
