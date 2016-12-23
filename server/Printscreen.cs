using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;

namespace printscreen
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(bitmap as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            MemoryStream memoryStream = new MemoryStream();
            bitmap.Save(memoryStream, ImageFormat.Jpeg);
            byte[] bitmapRecord = memoryStream.ToArray();
            //bitmap.Save(@"D:\\screenshot.jpeg", ImageFormat.Jpeg);
            Stream stdout = Console.OpenStandardOutput();
            stdout.Write(bitmapRecord, 0, bitmapRecord.Length);
            stdout.Flush();
        }
    }
}
