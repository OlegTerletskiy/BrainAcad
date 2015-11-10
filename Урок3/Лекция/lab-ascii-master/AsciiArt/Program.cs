using System;
using System.IO;

namespace AsciiArt
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            using (var image = Properties.Resources.BlackCat)
            {
                var text = ImageConverter.ConvertImage(image);

                Console.Write(text);
            }

            Console.ReadKey();
        }
    }
}