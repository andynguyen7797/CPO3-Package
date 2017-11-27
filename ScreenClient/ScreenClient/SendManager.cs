using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenClient
{
    public class SendManager : Client
    {

        public void StartSendImageCapture()
        {
            Thread SendImageCaptureThr = new Thread(() => {

                Stream stream = ScreeClient.GetStream();

                byte[] data;
                try
                {
                    while (true)
                    {
                        data = ScreenManager.GetByteArrayOfScreenCapture(IndexOfscreen);
                        stream.Write(data, 0, data.Length);
                        Thread.Sleep(DelayTimetoCapture);
                    }
                }
                catch
                {
                    //Begin Connect
                    //waiting when client is connected
                    NotifyMessage.showMessage("Send was stoped", 1, 1000);
                }

            });
            SendImageCaptureThr.Start(); 
        }
    }
}
