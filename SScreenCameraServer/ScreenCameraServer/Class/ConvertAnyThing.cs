using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenCameraServer
{
    public class ConvertAnyThing
    {

        public static Image ConvertByteArraytoImage(byte[] data)
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                Image img = (Image)converter.ConvertFrom(data);
                return img;
            } catch
            {
                return null;
            }
        }

    }
}
