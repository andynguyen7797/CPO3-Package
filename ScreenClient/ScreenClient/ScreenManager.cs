using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using WindowsDisplayAPI;

namespace ScreenClient
{
    public class ScreenManager
    {

        public static List<string> DetectScreen()
        {
            List<string> result = new List<string>();
            //  Screen[] screenList = Screen.AllScreens;
            foreach (var display in Display.GetDisplays())
            {

                result.Add(display.DeviceName);
            }
            return result;
        }

        public static byte[] GetByteArrayOfScreenCapture(int index)
        {
            int countOfScreen = Screen.AllScreens.Length;
            if(index >= countOfScreen)
            {
                MessageBox.Show("Màn hình này không tồn tại");
                return null;
            }

            Screen screenCapture = Screen.AllScreens[index];
            Bitmap bmp = new Bitmap(screenCapture.Bounds.Width, screenCapture.Bounds.Height);
            Rectangle rec = screenCapture.Bounds;
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rec.Left, rec.Top, 0, 0, rec.Size);

            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Jpeg);
          //  MessageBox.Show(ms.ToArray().ToString());
            return ms.ToArray();
        }

    }
}
