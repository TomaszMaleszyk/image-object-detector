using System;
using System.Drawing;
using MathWorks.MATLAB.NET.Arrays;

namespace ObjectDetector.Models
{
    public class ObjectDetectionAlgorithms
    {
        //stworzyć metode do tych array

        private readonly BibliotekaMatlab.WyszukajObiekt searchObjectByMatlabOperations;
        public ObjectDetectionAlgorithms()
        {
            searchObjectByMatlabOperations = new BibliotekaMatlab.WyszukajObiekt();
        }
        public Bitmap ViolaJones(Bitmap inputBitmap, string kindOfObjectToDetect)
        {
            var bitmapHeight = inputBitmap.Height;
            var bitmapWidth = inputBitmap.Width;

            var resultBitmap = new Bitmap(bitmapWidth, bitmapHeight);

            var rgbArray = new byte[3, bitmapHeight, bitmapWidth];
            for(var yPositionOfAnalizingPixel = 0; yPositionOfAnalizingPixel < bitmapHeight; yPositionOfAnalizingPixel++)
            {
                for(var xPositionOfAnalizingPixel = 0; xPositionOfAnalizingPixel < bitmapWidth; xPositionOfAnalizingPixel++)
                {
                    rgbArray[0, yPositionOfAnalizingPixel, xPositionOfAnalizingPixel] =
                        inputBitmap.GetPixel(xPositionOfAnalizingPixel, yPositionOfAnalizingPixel).R;
                    rgbArray[1, yPositionOfAnalizingPixel, xPositionOfAnalizingPixel] =
                        inputBitmap.GetPixel(xPositionOfAnalizingPixel, yPositionOfAnalizingPixel).G;
                    rgbArray[2, yPositionOfAnalizingPixel, xPositionOfAnalizingPixel] =
                        inputBitmap.GetPixel(xPositionOfAnalizingPixel, yPositionOfAnalizingPixel).B;
                }
            }
            MWNumericArray imageMatrix = rgbArray;
            MWArray resultBitmapArray = 0;

            switch(kindOfObjectToDetect)
            {
                case "Twarz":
                    resultBitmapArray = searchObjectByMatlabOperations.ViolaJones(imageMatrix, "Face");
                    break;
                case "Góra ciała":
                    resultBitmapArray = searchObjectByMatlabOperations.ViolaJones(imageMatrix, "UpperBody");
                    break;
                case "Usta":
                    resultBitmapArray = searchObjectByMatlabOperations.ViolaJones(imageMatrix, "Mouth");
                    break;
                case "Nos":
                    resultBitmapArray = searchObjectByMatlabOperations.ViolaJones(imageMatrix, "Nose");
                    break;
            }
            for(var yPositionOfAnalizingPixel = 0; yPositionOfAnalizingPixel < bitmapHeight; yPositionOfAnalizingPixel++)
            {
                for(var xPositionOfAnalizingPixel = 0; xPositionOfAnalizingPixel < bitmapWidth; xPositionOfAnalizingPixel++)
                {
                    resultBitmap.SetPixel(xPositionOfAnalizingPixel, yPositionOfAnalizingPixel,
                        Color.FromArgb(Convert.ToInt32(resultBitmapArray[yPositionOfAnalizingPixel + 1, xPositionOfAnalizingPixel + 1, 1].ToString()),
                        Convert.ToInt32(resultBitmapArray[yPositionOfAnalizingPixel + 1, xPositionOfAnalizingPixel + 1, 2].ToString()),
                        Convert.ToInt32(resultBitmapArray[yPositionOfAnalizingPixel + 1, xPositionOfAnalizingPixel + 1, 3].ToString())));
                }
            }
            return resultBitmap;
        }
        public Bitmap Surf(Bitmap inputBitmap, Bitmap templateOfObjectToDetect)
        {
            var inputBitmapHeight = inputBitmap.Height;
            var inputBitmapWidth = inputBitmap.Width;
            var templateOfObjectToDetectHeight = templateOfObjectToDetect.Height;
            var templateOfObjectToDetectWidth = templateOfObjectToDetect.Width;

            var bitmapaWy = new Bitmap(inputBitmapWidth, inputBitmapHeight);
          
            var rgbArrayOfInputBitmap = new byte[3, inputBitmapHeight, inputBitmapWidth];
            for(var j = 0; j < inputBitmapHeight; j++)
            {
                for(var i = 0; i < inputBitmapWidth; i++)
                {
                    rgbArrayOfInputBitmap[0, j, i] = inputBitmap.GetPixel(i, j).R;
                    rgbArrayOfInputBitmap[1, j, i] = inputBitmap.GetPixel(i, j).G;
                    rgbArrayOfInputBitmap[2, j, i] = inputBitmap.GetPixel(i, j).B;
                }
            }
            MWNumericArray imageMatrix = rgbArrayOfInputBitmap;

            var rgbArrayOfTemplate = new byte[3, templateOfObjectToDetectHeight, templateOfObjectToDetectWidth];
            for(var j = 0; j < templateOfObjectToDetectHeight; j++)
            {
                for(var i = 0; i < templateOfObjectToDetectWidth; i++)
                {
                    rgbArrayOfTemplate[0, j, i] = templateOfObjectToDetect.GetPixel(i, j).R;
                    rgbArrayOfTemplate[1, j, i] = templateOfObjectToDetect.GetPixel(i, j).G;
                    rgbArrayOfTemplate[2, j, i] = templateOfObjectToDetect.GetPixel(i, j).B;
                }
            }
            MWNumericArray templateMatrix = rgbArrayOfTemplate;
            MWArray resultBitmapArray;
            try
            {
                resultBitmapArray = searchObjectByMatlabOperations.SURF(templateMatrix, imageMatrix);
            }
            catch(Exception)
            {
                return inputBitmap;
            }
            for(var i = 0; i < inputBitmapHeight; i++)
            {
                for(var j = 0; j < inputBitmapWidth; j++)
                {
                    bitmapaWy.SetPixel(j, i, Color.FromArgb(Convert.ToInt32(resultBitmapArray[i + 1, j + 1, 1].ToString()), Convert.ToInt32(resultBitmapArray[i + 1, j + 1, 2].ToString()), Convert.ToInt32(resultBitmapArray[i + 1, j + 1, 3].ToString())));
                }
            }
            return bitmapaWy;
        }
        public Bitmap Hog(Bitmap inputBitmap)
        {
            var inputBitmapHeight = inputBitmap.Height;
            var inputBitmapWidth = inputBitmap.Width;

            var resultBitmap = new Bitmap(inputBitmapWidth, inputBitmapHeight);

            var rgbArrayOfInputBitmap = new byte[3, inputBitmapHeight, inputBitmapWidth];
            for(var j = 0; j < inputBitmapHeight; j++)
            {
                for(var i = 0; i < inputBitmapWidth; i++)
                {
                    rgbArrayOfInputBitmap[0, j, i] = inputBitmap.GetPixel(i, j).R;
                    rgbArrayOfInputBitmap[1, j, i] = inputBitmap.GetPixel(i, j).G;
                    rgbArrayOfInputBitmap[2, j, i] = inputBitmap.GetPixel(i, j).B;
                }
            }
            MWNumericArray imageMatrix = rgbArrayOfInputBitmap;
            MWArray resultBitmapMatrix = 0;

            resultBitmapMatrix = searchObjectByMatlabOperations.HOG_SVM(imageMatrix);

            for(var i = 0; i < inputBitmapHeight; i++)
            {
                for(var j = 0; j < inputBitmapWidth; j++)
                {
                    resultBitmap.SetPixel(j, i, Color.FromArgb(Convert.ToInt32(resultBitmapMatrix[i + 1, j + 1, 1].ToString()), Convert.ToInt32(resultBitmapMatrix[i + 1, j + 1, 2].ToString()), Convert.ToInt32(resultBitmapMatrix[i + 1, j + 1, 3].ToString())));
                }
            }
            return resultBitmap;
        }
    }
}
