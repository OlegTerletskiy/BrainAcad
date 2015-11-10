using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace AsciiArt
{
    public static class ImageConverter
    {
        private const int ColumnWidth = 5;
        private const int RowHeight = 5;

        public static string ConvertImage(Bitmap image)
        {
            var matrix = CreateGrayscaleMatrix();

            var asciiart = new StringBuilder();

            var attributes = new ImageAttributes();
            attributes.SetColorMatrix(matrix);

            using (var gphGrey = Graphics.FromImage(image))
            {
                var bounds = new Rectangle(0, 0, image.Width, image.Height);
                gphGrey.DrawImage(image, bounds, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            }

            for (int h = 0; h < image.Height/RowHeight; h++)
            {
                for (int w = 0; w < image.Width/ColumnWidth; w++)
                {
                    var blockBrightness = GetBlockBrightness(image, h, w);

                    var symbol = SymbolSelector.ChooseSymbol(blockBrightness);
                    asciiart.Append(symbol);
                }

                asciiart.Append("\n");
            }

            return asciiart.ToString();
        }

        private static int GetBlockBrightness(Bitmap image, int rowIndex, int columnIndex)
        {
            var startY = (rowIndex*RowHeight);
            var startX = (columnIndex*ColumnWidth);
            int allBrightness = 0;

            int y = 0;
            for (y = 0; y < RowHeight; y++)
            // y := for each pixel in row [0..RowHeight)
                {
                int x = 0;
                // x := for each pixel in column [0..ColumnWidth)
                for (x = 0; x < ColumnWidth; x++)
                    {
                    int cY = y + startY;
                    int cX = x + startX;

                    var pixelColor = image.GetPixel(cX, cY);
                    var pixelBrightness = (int)(pixelColor.GetBrightness() * 10);

                    allBrightness += pixelBrightness + 8;
                    }
                }

            return allBrightness/10;
        }

        private static ColorMatrix CreateGrayscaleMatrix()
        {
            var matrix = new ColorMatrix();

            matrix[0, 0] = 1/3f;
            matrix[0, 1] = 1/3f;
            matrix[0, 2] = 1/3f;
            matrix[1, 0] = 1/3f;
            matrix[1, 1] = 1/3f;
            matrix[1, 2] = 1/3f;
            matrix[2, 0] = 1/3f;
            matrix[2, 1] = 1/3f;
            matrix[2, 2] = 1/3f;
            return matrix;
        }
    }
}