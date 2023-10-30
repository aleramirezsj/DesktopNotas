using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopNotas.Utils
{
    public class Helper
    {
        public static Image convertirBytesAImagen(Byte[] arregloImg)
        {
            MemoryStream imagenStream = new MemoryStream(arregloImg);
            Image imagen = Image.FromStream(imagenStream);
            return imagen;
        }

        public static byte[] convertirImagenABytes(Image img)
        {
            MemoryStream imagenStream = new MemoryStream();
            img.Save(imagenStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imagenBytes = imagenStream.ToArray();
            return imagenBytes;
        }
    }
}
