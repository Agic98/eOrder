using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace eOrder.Win.Helpers
{
    public static class Extensions
    {
        public static Image AsImage(this byte[] data)
        {
            using (var inStream = new MemoryStream(data))
            using (var outStream = new MemoryStream())
            {
                return Image.FromStream(inStream);
            }
        }

        public static ImageFormat GetImageFormat(this string imageFileType)
        {
            if (imageFileType == ".JPG")
            {
                return ImageFormat.Jpeg;
            }

            if (imageFileType == ".PNG")
            {
                return ImageFormat.Png;
            }

            if (imageFileType == ".GIF")
            {
                return ImageFormat.Gif;
            }

            return ImageFormat.Jpeg;
        }
    }
}
