using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net.Mail;
using System.Data;

namespace ClasesBase
{
    public static class UtilImagen
    {
        /***
         * Cargar Imagen
         * **/
        /* public static string CompleteImagePath(string nombreImg)
         {
             var CurrentDirectory = Directory.GetCurrentDirectory();
             var VistasDirectory = CurrentDirectory.Substring(0, CurrentDirectory.Length - 9);
             return VistasDirectory + "\\Recursos\\" + nombreImg;
         }*/

        public static System.Drawing.Image ByteToImage(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                System.Drawing.Image img = System.Drawing.Image.FromStream(memstr);
                return img;
            }
        }

        public static byte[] ImageToByte(System.Drawing.Image img)
        {
            if (img != null)
            {
                byte[] byteArray = new byte[0];
                using (MemoryStream stream = new MemoryStream())
                {
                    img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    stream.Close();

                    byteArray = stream.ToArray();
                }
                return byteArray;
            }
            return null;
        }
    }
}
