using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenCameraServer
{
    public class NetworkMethod
    {

        public static string[] UnserialzeHEADER(string data)
        {
            //remove header tag
            data = data.Remove(0, 7);
            string[] result = data.Split('/');
            return result;
        }
    }
}
