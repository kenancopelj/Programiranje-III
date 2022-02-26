using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntroWinForms.Ispit190073
{
    public class ImageConventer190073
    {
        public static byte[] FromImageToByte(Image slika)
        {
            MemoryStream ms = new MemoryStream();
            slika.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public static Image FromByteToImage(byte[] slika)
        {
            MemoryStream ms = new MemoryStream(slika);
            return Image.FromStream(ms);
        }
    }
}
