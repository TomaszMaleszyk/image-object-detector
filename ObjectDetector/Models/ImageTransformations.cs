using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;

namespace ObjectDetector
{
    public class ImageTransformations
    {
        #region Binarization
        public double OtsuThreshold(Bitmap inputBitmap)
        {
            double pob = 0, pb, mob, mb, s2b;
            Color pixelColor;
            var histogram = new double[256];
            histogram[0] = 0;
            double pixelsQuantity = inputBitmap.Width * inputBitmap.Height;
            for(var y = 0; y < inputBitmap.Height; y++)
                for(var x = 0; x < inputBitmap.Width; x++)
                {
                    pixelColor = inputBitmap.GetPixel(x, y);
                    var r = pixelColor.R;
                    var g = pixelColor.G;
                    var b = pixelColor.B;
                    var k = (byte)((r + g + b) / 3);
                    histogram[k] = histogram[k] + 1;
                }

            for(var i = 0; i < 256; i++)
                histogram[i] = histogram[i] / pixelsQuantity;

            var t = 0;
            double maxs2 = 0, progBinaryzacjiOtsu = 0;
            for(t = 1; t < 255; t++)
            {
                pob = pb = mob = mb = s2b = 0;
                for(var k = 0; k <= t; k++)
                    pob += histogram[k];
                for(var k = t + 1; k < 256; k++)
                    pb += histogram[k];
                for(var k = 0; k < t; k++)
                    mob += k * histogram[k];
                if(pob != 0)
                    mob = mob / pob;
                for(var k = t + 1; k < 256; k++)
                    mb += k * histogram[k];
                if(pb != 0)
                    mb = mb / pb;
                s2b = pob * pb * (mob - mb) * (mob - mb);
                if(s2b > maxs2)
                {
                    maxs2 = s2b;
                    progBinaryzacjiOtsu = t;
                }
            }
            return progBinaryzacjiOtsu;
        }
        public Bitmap Binarization(Bitmap inputImage, int binarizationThreshold)
        {
            var inputImageHeight = inputImage.Height;
            var inputImageWidth = inputImage.Width;

            inputImage = GrayScaleTransformation(inputImage);

            var lockBitsInputImage = inputImage.LockBits(new Rectangle(0, 0, inputImageWidth, inputImageHeight),
                ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            var strideOfImageScan = lockBitsInputImage.Stride;
            unsafe
            {
                var readingOfPixelData = (byte*)lockBitsInputImage.Scan0.ToPointer();

                for(var j = 0; j < inputImageHeight; j++)
                {
                    var pWe = &readingOfPixelData[j * strideOfImageScan];
                    for(var i = 0; i < inputImageWidth * 3; i += 3)
                    {
                        pWe[i] = (byte)((pWe[i] > (byte)binarizationThreshold) ? 255 : 0);
                        pWe[i + 1] = (byte)((pWe[i + 1] > (byte)binarizationThreshold) ? 255 : 0);
                        pWe[i + 2] = (byte)((pWe[i + 2] > (byte)binarizationThreshold) ? 255 : 0);
                    }
                }
            }
            inputImage.UnlockBits(lockBitsInputImage);

            return inputImage;
        }
        #endregion
        #region Jasność obrazu
        public Bitmap SetBrightnessOfImage(Bitmap inputImage, int levelOfBrightness)
        {
            var inputImageWidth = inputImage.Width;
            var inputImageHeight = inputImage.Height;

            for(var j = 0; j < inputImageHeight; j++)
            {
                for(var i = 0; i < inputImageWidth; i++)
                {
                    var pixelColorValue = inputImage.GetPixel(i, j);
                    var rColorComponentValue = pixelColorValue.R + levelOfBrightness;
                    var gColorComponentValue = pixelColorValue.G + levelOfBrightness;
                    var bColorComponentValue = pixelColorValue.B + levelOfBrightness;

                    if(rColorComponentValue < 0)
                        rColorComponentValue = 1;
                    if(rColorComponentValue > 255)
                        rColorComponentValue = 255;

                    if(gColorComponentValue < 0)
                        gColorComponentValue = 1;
                    if(gColorComponentValue > 255)
                        gColorComponentValue = 255;

                    if(bColorComponentValue < 0)
                        bColorComponentValue = 1;
                    if(bColorComponentValue > 255)
                        bColorComponentValue = 255;

                    inputImage.SetPixel(i, j, Color.FromArgb((byte)rColorComponentValue, (byte)gColorComponentValue, (byte)bColorComponentValue));
                }
            }
            return inputImage;
        }

        #endregion
        #region Kontrast obrazu
        public Bitmap UstalKontrastObrazu(Bitmap inputImage, double contrastLevel)
        {
            var inputImageWidth = inputImage.Width;
            var inputImageHeight = inputImage.Height;

            if(contrastLevel < -100)
                contrastLevel = -100;
            if(contrastLevel > 100)
                contrastLevel = 100;

            contrastLevel = (100.0 + contrastLevel) / 100.0;
            contrastLevel *= contrastLevel;
            for(var j = 0; j < inputImageHeight; j++)
            {
                for(var i = 0; i < inputImageWidth; i++)
                {
                    var pixelColorValue = inputImage.GetPixel(i, j);
                    var rColorComponentValue = pixelColorValue.R / 255.0;
                    rColorComponentValue -= 0.5;
                    rColorComponentValue *= contrastLevel;
                    rColorComponentValue += 0.5;
                    rColorComponentValue *= 255;
                    if(rColorComponentValue < 0)
                        rColorComponentValue = 0;
                    if(rColorComponentValue > 255)
                        rColorComponentValue = 255;

                    var gColorComponentValue = pixelColorValue.G / 255.0;
                    gColorComponentValue -= 0.5;
                    gColorComponentValue *= contrastLevel;
                    gColorComponentValue += 0.5;
                    gColorComponentValue *= 255;
                    if(gColorComponentValue < 0)
                        gColorComponentValue = 0;
                    if(gColorComponentValue > 255)
                        gColorComponentValue = 255;

                    var bColorComponentValue = pixelColorValue.B / 255.0;
                    bColorComponentValue -= 0.5;
                    bColorComponentValue *= contrastLevel;
                    bColorComponentValue += 0.5;
                    bColorComponentValue *= 255;
                    if(bColorComponentValue < 0)
                        bColorComponentValue = 0;
                    if(bColorComponentValue > 255)
                        bColorComponentValue = 255;

                    inputImage.SetPixel(i, j, Color.FromArgb((byte)rColorComponentValue, (byte)gColorComponentValue, (byte)bColorComponentValue));
                }
            }
            return inputImage;
        }

        #endregion
        #region Odcienie szarości
        public Bitmap GrayScaleTransformation(Bitmap inputImage)
        {
            var inputImageWidth = inputImage.Width;
            var inputImageHeight = inputImage.Height;

            for(var j = 0; j < inputImageHeight; j++)
            {
                for(var i = 0; i < inputImageWidth; i++)
                {
                    var pixelColorValue = inputImage.GetPixel(i, j);

                    var rColorComponentValue = pixelColorValue.R;
                    var gColorComponentValue = pixelColorValue.G;
                    var bColorComponentValue = pixelColorValue.B;
                    var grayScale = (rColorComponentValue + gColorComponentValue + bColorComponentValue) / 3;

                    pixelColorValue = Color.FromArgb(grayScale, grayScale, grayScale);
                    inputImage.SetPixel(i, j, pixelColorValue);
                }
            }
            return inputImage;
        }
        #endregion
        #region Histogram
        public double[] CreateHistogram(Bitmap inputImage, Color histogramChannelColor)
        {
            var rColorComponentValueArray = new double[256];
            var gColorComponentValueArray = new double[256];
            var bColorComponentValueArray = new double[256];
            var grayChannelValue = new double[256];

            Array.Clear(rColorComponentValueArray, 0, rColorComponentValueArray.Length);
            Array.Clear(gColorComponentValueArray, 0, gColorComponentValueArray.Length);
            Array.Clear(bColorComponentValueArray, 0, bColorComponentValueArray.Length);
            Array.Clear(grayChannelValue, 0, grayChannelValue.Length);

            for(var j = 0; j < inputImage.Height; j++)
            {
                for(var i = 0; i < inputImage.Width; i++)
                {
                    var pixelColorValue = inputImage.GetPixel(i, j);

                    rColorComponentValueArray[pixelColorValue.R]++;
                    gColorComponentValueArray[pixelColorValue.G]++;
                    bColorComponentValueArray[pixelColorValue.B]++;
                }
            }

            for(var i = 0; i < rColorComponentValueArray.Length; i++)
            {
                grayChannelValue[i] = (rColorComponentValueArray[i] + gColorComponentValueArray[i] + bColorComponentValueArray[i]) / 3;
            }

            if(histogramChannelColor == Color.Red)
            {
                return rColorComponentValueArray;
            }
            if(histogramChannelColor == Color.Green)
            {
                return gColorComponentValueArray;
            }
            if(histogramChannelColor == Color.Blue)
            {
                return bColorComponentValueArray;
            }
            if(histogramChannelColor == Color.Gray)
            {
                return grayChannelValue;
            }

            return new double[] { 0, 0, 0, 0, 0 };
        }
        private void NormalizationOfHistogramHeight(double[] colorArray, int bitmapHeight)
        {
            var mostQuantitierColor = colorArray.Max();
            for(var i = 0; i < 256; i++)
            {
                colorArray[i] = colorArray[i] / mostQuantitierColor * bitmapHeight;
            }
        }
        private void DrawHistogram(Bitmap inputImage, double[] colorArray, Color colorOfBrush)
        {
            var drawHistogram = Graphics.FromImage(inputImage);
            var brush = new Pen(colorOfBrush, 1);

            for(var i = 0; i < 255; i++)
            {
                var peakOfHistogramBar = inputImage.Height - colorArray[i];
                drawHistogram.DrawLine(brush, i, inputImage.Height, i, (int)peakOfHistogramBar);
            }
        }
        private void DrawLinearHistogram(Bitmap inputImage, double[] colorArray, Color colorOfBrush)
        {
            var drawHistogram = Graphics.FromImage(inputImage);
            var pen = new Pen(colorOfBrush, 1);

            for(var i = 0; i < 255; i++)
            {
                var peakOfHistogramBar = inputImage.Height - colorArray[i];
                var peakOfNextHistogramBar = inputImage.Height - colorArray[i + 1];

                drawHistogram.DrawLine(pen, i, (int)peakOfHistogramBar, i + 1, (int)peakOfNextHistogramBar);
            }
        }
        private void ClearHistogram(Bitmap inputImage)
        {
            var drawHistogram = Graphics.FromImage(inputImage);
            var brush = new SolidBrush(Color.Silver);
            drawHistogram.FillRectangle(brush, 0, 0, inputImage.Width, inputImage.Height);
        }
        #region Histogram poszczególnych kolorów
        public Bitmap CalculateHistogram(Bitmap inputImage, Bitmap outputImage, Color histogramChannelColor)
        {
            var outputImageHeight = outputImage.Height;
            var histogram = CreateHistogram(inputImage, histogramChannelColor);

            NormalizationOfHistogramHeight(histogram, outputImageHeight);
            ClearHistogram(outputImage);
            DrawHistogram(outputImage, histogram, histogramChannelColor);

            return outputImage;
        }
        #endregion
        #region Histogram Liniowy
        public Bitmap CalculateLinearHistogram(Bitmap inputImage, Bitmap outputImage)
        {
            var analizedColor = Color.Red;
            var arrayOfColor = CreateHistogram(inputImage, analizedColor);

            ClearHistogram(outputImage);

            NormalizationOfHistogramHeight(arrayOfColor, outputImage.Height);
            DrawLinearHistogram(outputImage, arrayOfColor, Color.Red);

            analizedColor = Color.Green;
            arrayOfColor = CreateHistogram(inputImage, analizedColor);

            NormalizationOfHistogramHeight(arrayOfColor, outputImage.Height);
            DrawLinearHistogram(outputImage, arrayOfColor, Color.Green);

            analizedColor = Color.Blue;
            arrayOfColor = CreateHistogram(inputImage, analizedColor);

            NormalizationOfHistogramHeight(arrayOfColor, outputImage.Height);
            DrawLinearHistogram(outputImage, arrayOfColor, Color.Blue);

            return outputImage;
        }
        #endregion
        #endregion

        public Bitmap AlignmentOfHistogram(Bitmap inputImage)
        {
            var outputImage = inputImage;

            var inputImageHeight = inputImage.Height;
            var inputImageWidth = inputImage.Width;

            decimal countOfImagePixels = outputImage.Height * outputImage.Width;
            var averageBrightnessPerPixel = 255 / countOfImagePixels;
            var rColorComponentValueArray = CreateHistogram(inputImage, Color.Red);
            var gColorComponentValueArray = CreateHistogram(inputImage, Color.Green);
            var bColorComponentValueArray = CreateHistogram(inputImage, Color.Blue);

            for(var i = 1; i <= 255; i++)
            {
                rColorComponentValueArray[i] = rColorComponentValueArray[i] + rColorComponentValueArray[i - 1];
                gColorComponentValueArray[i] = gColorComponentValueArray[i] + gColorComponentValueArray[i - 1];
                bColorComponentValueArray[i] = bColorComponentValueArray[i] + bColorComponentValueArray[i - 1];
            }

            for(var j = 0; j < inputImageHeight; j++)
            {
                for(var i = 0; i < inputImageWidth; i++)
                {
                    var colorOfAnalizingPixel = outputImage.GetPixel(i, j);

                    var rColorComponentValue = (int)((decimal)rColorComponentValueArray[colorOfAnalizingPixel.R] * averageBrightnessPerPixel);
                    var gColorComponentValue = (int)((decimal)gColorComponentValueArray[colorOfAnalizingPixel.G] * averageBrightnessPerPixel);
                    var bColorComponentValue = (int)((decimal)bColorComponentValueArray[colorOfAnalizingPixel.B] * averageBrightnessPerPixel);

                    var newValueOfColor = Color.FromArgb(rColorComponentValue, gColorComponentValue, bColorComponentValue);
                    outputImage.SetPixel(i, j, newValueOfColor);
                }
            }
            return outputImage;
        }
        public Bitmap MedianFilter(Bitmap inputImage, int sizeOfMask)
        {
            var adjacentPixels = new List<int>();

            var maskRadius = (sizeOfMask - 1) / 2;
            var analizedPixel = 0;
            var numberOfPixel = 0;

            byte[] centerPixelOfMask;

            var inputImageData =
                       inputImage.LockBits(new Rectangle(0, 0,
                       inputImage.Width, inputImage.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            var inputImagePixelsArray = new byte[inputImageData.Stride * inputImageData.Height];

            var outputImagePixelsArray = new byte[inputImageData.Stride * inputImageData.Height];

            Marshal.Copy(inputImageData.Scan0, inputImagePixelsArray, 0,
                                       inputImagePixelsArray.Length);

            inputImage.UnlockBits(inputImageData);

            for(var i = maskRadius; i < inputImage.Height - maskRadius; i++)
            {
                for(var j = maskRadius; j < inputImage.Width - maskRadius; j++)
                {
                    numberOfPixel = i * inputImageData.Stride + j * 4;

                    adjacentPixels.Clear();

                    for(var filterY = -maskRadius; filterY <= maskRadius; filterY++)
                    {
                        for(var filterX = -maskRadius; filterX <= maskRadius; filterX++)
                        {
                            analizedPixel = numberOfPixel + (filterX * 4) + (filterY * inputImageData.Stride);

                            adjacentPixels.Add(BitConverter.ToInt32(inputImagePixelsArray, analizedPixel));
                        }
                    }
                    adjacentPixels.Sort();

                    centerPixelOfMask = BitConverter.GetBytes(adjacentPixels[maskRadius]);

                    outputImagePixelsArray[numberOfPixel] = centerPixelOfMask[0];
                    outputImagePixelsArray[numberOfPixel + 1] = centerPixelOfMask[1];
                    outputImagePixelsArray[numberOfPixel + 2] = centerPixelOfMask[2];
                    outputImagePixelsArray[numberOfPixel + 3] = centerPixelOfMask[3];
                }
            }

            var outputImage = new Bitmap(inputImage.Width,
                                             inputImage.Height);

            var outputImageData =
                       outputImage.LockBits(new Rectangle(0, 0,
                       outputImage.Width, outputImage.Height),
                       ImageLockMode.WriteOnly,
                       PixelFormat.Format32bppArgb);

            Marshal.Copy(outputImagePixelsArray, 0, outputImageData.Scan0, outputImagePixelsArray.Length);

            outputImage.UnlockBits(outputImageData);

            return outputImage;
        }
        public Bitmap RotatingOfImage(Bitmap inputImage, float degreeOfTurnover)
        {
            var outputImage = new Bitmap(inputImage.Width, inputImage.Height);
            var drawImage = Graphics.FromImage(outputImage);

            drawImage.TranslateTransform((float)outputImage.Width / 2, (float)outputImage.Height / 2);
            drawImage.RotateTransform(degreeOfTurnover);
            drawImage.TranslateTransform(-(float)outputImage.Width / 2, -(float)outputImage.Height / 2);

            drawImage.InterpolationMode = InterpolationMode.HighQualityBicubic;
            drawImage.DrawImage(inputImage, new Point(0, 0));

            drawImage.Dispose();
            return outputImage;
        }
        public Bitmap ChangeSizeOfImage(Bitmap inputImage, int outputWidth, int outputHeight)
        {
            var outputBitmap = new Bitmap(outputWidth, outputHeight, inputImage.PixelFormat);

            var widthRatio = inputImage.Width / (double)outputWidth;
            var heightRatio = inputImage.Height / (double)outputHeight;

            double fx, fy, nx, ny;
            int cx, cy, fr_x, fr_y;
            var color1 = new Color();
            var color2 = new Color();
            var color3 = new Color();
            var color4 = new Color();

            byte bp1, bp2;

            for(var j = 0; j < outputBitmap.Height; j++)
            {
                for(var i = 0; i < outputBitmap.Width; i++)
                {
                    fr_x = (int)Math.Floor(i * widthRatio);
                    fr_y = (int)Math.Floor(j * heightRatio);
                    cx = fr_x + 1;
                    if(cx >= inputImage.Width)
                        cx = fr_x;
                    cy = fr_y + 1;
                    if(cy >= inputImage.Height)
                        cy = fr_y;
                    fx = i * widthRatio - fr_x;
                    fy = j * heightRatio - fr_y;
                    nx = 1.0 - fx;
                    ny = 1.0 - fy;

                    color1 = inputImage.GetPixel(fr_x, fr_y);
                    color2 = inputImage.GetPixel(cx, fr_y);
                    color3 = inputImage.GetPixel(fr_x, cy);
                    color4 = inputImage.GetPixel(cx, cy);

                    bp1 = (byte)(nx * color1.R + fx * color2.R);
                    bp2 = (byte)(nx * color3.R + fx * color4.R);
                    var rColorComponentValue = (byte)(ny * bp1 + fy * bp2);

                    bp1 = (byte)(nx * color1.G + fx * color2.G);
                    bp2 = (byte)(nx * color3.G + fx * color4.G);
                    var gColorComponentValue = (byte)(ny * bp1 + fy * bp2);

                    bp1 = (byte)(nx * color1.B + fx * color2.B);
                    bp2 = (byte)(nx * color3.B + fx * color4.B);
                    var bColorComponentValue = (byte)(ny * bp1 + fy * bp2);

                    outputBitmap.SetPixel(i, j, System.Drawing.Color.FromArgb
            (255, rColorComponentValue, gColorComponentValue, bColorComponentValue));
                }
            }
            return outputBitmap;
        }
        public Bitmap IncreaseDistanceToImage(Bitmap inputImage, double ratio)
        {
            var widthRatioOfOperation = inputImage.Width / ratio;
            var heightRatioOfOperation = inputImage.Height / ratio;

            var widthOfOutputBitmap = (int)widthRatioOfOperation;
            var heightOfOutputBitmap = (int)heightRatioOfOperation;

            var destinationRectangle = new Rectangle(0, 0, widthOfOutputBitmap, heightOfOutputBitmap);
            var outputImage = new Bitmap(widthOfOutputBitmap, heightOfOutputBitmap);

            outputImage.SetResolution(inputImage.HorizontalResolution, inputImage.VerticalResolution);

            using(var drawImage = Graphics.FromImage(outputImage))
            {
                drawImage.CompositingMode = CompositingMode.SourceCopy;
                drawImage.CompositingQuality = CompositingQuality.HighQuality;
                drawImage.InterpolationMode = InterpolationMode.HighQualityBicubic;
                drawImage.SmoothingMode = SmoothingMode.HighQuality;
                drawImage.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using(var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    drawImage.DrawImage(inputImage, destinationRectangle, 0, 0, inputImage.Width, inputImage.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return outputImage;
        }
        public Bitmap ApproximateDistanceToImage(Bitmap inputImage, double ratio)
        {
            var widthRatioOfOperation = inputImage.Width * ratio;
            var heightRatioOfOperation = inputImage.Height * ratio;

            var widthOfOutputBitmap = (int)widthRatioOfOperation;
            var heightOfOutputBitmap = (int)heightRatioOfOperation;

            var destinationRectangle = new Rectangle(0, 0, widthOfOutputBitmap, heightOfOutputBitmap);
            var outputImage = new Bitmap(widthOfOutputBitmap, heightOfOutputBitmap);

            outputImage.SetResolution(inputImage.HorizontalResolution, inputImage.VerticalResolution);

            using(var drawImage = Graphics.FromImage(outputImage))
            {
                drawImage.CompositingMode = CompositingMode.SourceCopy;
                drawImage.CompositingQuality = CompositingQuality.HighQuality;
                drawImage.InterpolationMode = InterpolationMode.HighQualityBicubic;
                drawImage.SmoothingMode = SmoothingMode.HighQuality;
                drawImage.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using(var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    drawImage.DrawImage(inputImage, destinationRectangle, 0, 0, inputImage.Width, inputImage.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return outputImage;
        }
        public Bitmap CutImage(Bitmap inputImage, int outputWidth, int outputHeight)
        {
            var destinationRectangle = new Rectangle(0, 0, outputWidth, outputHeight);
            var outputImage = new Bitmap(outputWidth, outputHeight);

            outputImage.SetResolution(inputImage.HorizontalResolution, inputImage.VerticalResolution);

            using(var drawImage = Graphics.FromImage(outputImage))
            {
                drawImage.CompositingMode = CompositingMode.SourceCopy;
                drawImage.CompositingQuality = CompositingQuality.HighQuality;
                drawImage.InterpolationMode = InterpolationMode.HighQualityBicubic;
                drawImage.SmoothingMode = SmoothingMode.HighQuality;
                drawImage.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using(var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    drawImage.DrawImage(inputImage, destinationRectangle, 0, 0, outputWidth, outputHeight, GraphicsUnit.Pixel);
                }
            }
            return outputImage;
        }
        public Bitmap CutAreaFromImage(Bitmap inputImage, int inputWidth, int inputHeight, int areaWidth, int areaHeight)
        {
            var operationalBitmap = (Bitmap)inputImage.Clone();
            var drawImage = Graphics.FromImage(operationalBitmap);
            var pen = new Pen(Color.FromArgb(150, Color.White)).Brush;
            var topRectangle = new Rectangle(0, 0, inputImage.Width, inputHeight);
            var leftRectangle = new Rectangle(0, inputHeight, inputWidth, areaHeight);
            var bottomRectangle = new Rectangle(0, (inputHeight + areaHeight), inputImage.Width, inputImage.Height);
            var rightRectangle = new Rectangle((inputWidth + areaWidth), inputHeight, (inputImage.Width - inputWidth - areaWidth), areaHeight);

            drawImage.FillRectangle(pen, topRectangle);
            drawImage.FillRectangle(pen, leftRectangle);
            drawImage.FillRectangle(pen, bottomRectangle);
            drawImage.FillRectangle(pen, rightRectangle);

            return operationalBitmap;
        }
        public Bitmap CutFragmentOfImage(Bitmap inputImage, int inputWidth, int inputHeight, int areaWidth, int areaHeight)
        {
            if(inputWidth + areaWidth > inputImage.Width)
                areaWidth = inputImage.Width - inputWidth;
            if(inputHeight + areaHeight > inputImage.Height)
                areaHeight = inputImage.Height - inputHeight;
            var fragmentBitmapy = new Rectangle(inputWidth, inputHeight, areaWidth, areaHeight);
            inputImage = inputImage.Clone(fragmentBitmapy, inputImage.PixelFormat);

            return inputImage;
        }

    }
}
