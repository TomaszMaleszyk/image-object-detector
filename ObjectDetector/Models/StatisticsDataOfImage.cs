using System;
using System.Drawing;
using System.Linq;

namespace ObjectDetector.Models
{
    public class StatisticsDataOfImage : ImageTransformations
    {
        public double GetValueAverageBrightnessOfImage(Bitmap inputImage, string colorChannelName)
        {
            double countOfPixelsOnImage = inputImage.Width * inputImage.Height;
            double averageBrightnessOfAnalizingPixel = 0;
            var colorChannel = GetChannelColor(colorChannelName);
            var arrayOfAnalizingColor = CreateHistogram(inputImage, colorChannel);

            for(var i = 0; i < 256; i++)
            {
                averageBrightnessOfAnalizingPixel += arrayOfAnalizingColor[i] * i;
            }
            averageBrightnessOfAnalizingPixel /= countOfPixelsOnImage;

            return averageBrightnessOfAnalizingPixel;
        }
        public double GetValueOfTheDarkestPixelOfPicture(Bitmap inputImage, string colorChannelName)
        {
            double wartoscMinJasnosci = 0;
            var colorChannel = GetChannelColor(colorChannelName);
            var arrayOfAnalizingColor = CreateHistogram(inputImage, colorChannel);

            wartoscMinJasnosci = Array.IndexOf(arrayOfAnalizingColor, arrayOfAnalizingColor.First(x => x > 0));
            return wartoscMinJasnosci;
        }
        public double GetValueOfTheBrightestPixelOfPicture(Bitmap inputImage, string colorChannelName)
        {
            double maxBrightnessPixelValue = 0;
            var colorChannel = GetChannelColor(colorChannelName);
            var arrayOfAnalizingColor = CreateHistogram(inputImage, colorChannel);
            for(var i = 0; i < arrayOfAnalizingColor.Length; i++)
            {
                if(arrayOfAnalizingColor[i] > 0)
                {
                    maxBrightnessPixelValue = i;
                }
            }
            return maxBrightnessPixelValue;
        }
        private Color GetChannelColor(string channelColorName)
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
        public int GetContrastValue(Bitmap inputImage, string colorChannel)
        {
            int contrastValue;
            var minBrightness = (int)GetValueOfTheDarkestPixelOfPicture(inputImage, colorChannel);
            var maxBrightness = (int)GetValueOfTheBrightestPixelOfPicture(inputImage, colorChannel);
            const int brightnessRange = 255;

            if(minBrightness == 0)
            {
                minBrightness = 1;
            }
            if(maxBrightness == 0)
            {
                contrastValue = 0;
            }
            else
            {
                contrastValue = maxBrightness / minBrightness / brightnessRange;
            }

            return contrastValue;
        }
        public double GetVarianceValue(Bitmap inputImage, string colorChannelName)
        {
            double pixelCount = inputImage.Width * inputImage.Height;
            var averageBrightnessOfImage = GetValueAverageBrightnessOfImage(inputImage, colorChannelName);
            var colorChannel = GetChannelColor(colorChannelName);
            var histogram = CreateHistogram(inputImage, colorChannel);
            var varianceValue = histogram.Sum(t => (t - averageBrightnessOfImage) * (t - averageBrightnessOfImage));
            varianceValue /= pixelCount;
            return varianceValue;
        }
        public double GetAbberationValue(Bitmap inputImage, string colorChannelName)
        {
            double aberration;
            try
            {
                aberration = Math.Sqrt(GetVarianceValue(inputImage, colorChannelName));
            }
            catch(Exception)
            {
                aberration = 0;
            }
            return aberration;
        }
    }
}
