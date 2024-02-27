using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject
{
    public class ImageB64
    {



        public static Image Base64ToImage(string base64String)
        {
            // Convertir la cadena Base64 a un array de bytes
            byte[] imageBytes = Convert.FromBase64String(base64String);

            // Crear un flujo de memoria a partir del array de bytes
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                // Crear una imagen a partir del flujo de memoria
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        public static string ConvertScreenshotToBase64(Screenshot screenshot)
        {
            byte[] screenshotAsByteArray = Convert.FromBase64String(screenshot.AsBase64EncodedString);
            using (MemoryStream stream = new MemoryStream(screenshotAsByteArray))
            {
                Image screenshotImage = Image.FromStream(stream);
                using (MemoryStream base64Stream = new MemoryStream())
                {
                    screenshotImage.Save(base64Stream, System.Drawing.Imaging.ImageFormat.Png);
                    return Convert.ToBase64String(base64Stream.ToArray());
                }
            }
        }

        public static string ImageToBase64Path(string imagePath)
        {
            // Leer los bytes de la imagen desde el archivo
            byte[] imageBytes = File.ReadAllBytes(imagePath);

            // Convertir el array de bytes a una cadena Base64
            string base64String = Convert.ToBase64String(imageBytes);

            return base64String;
        }
    }
}
