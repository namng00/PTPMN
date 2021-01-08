using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace AppSoundN.Utils
{
    class Helpers
    {
        public static byte[] ConvertImageToBinary(BitmapImage image)
        {
            var encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(image));
            var ms = new MemoryStream();
            encoder.Save(ms);
            return ms.ToArray();
        }
        public static BitmapImage ConvertByteToImageBitmap(byte[] array)
        {
            MemoryStream ms = new MemoryStream(array);
            var image = new BitmapImage();
            image.BeginInit();
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }
        public static string ConvertByteToGender(byte a)
        {
            if (a == 1) return "Femaley"; else return "Male";
        }

        public static bool isValidEmail(string Email)
        {
            return Regex.IsMatch(Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        public static void MakeErrorMessage(Window w,string title, string message) => MessageBox.Show(title, message, MessageBoxButton.OK, MessageBoxImage.Error);

    }
}
