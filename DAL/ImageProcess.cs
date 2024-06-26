using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace DAL
{
    public class ImageProcess
    {
        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        public static Image ByteArrayToImage(byte[] imageBytes)
        {
            if (imageBytes == null || imageBytes.Length == 0)
            {
                throw new ArgumentException("Image bytes cannot be null or empty", nameof(imageBytes));
            }

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
