using System.IO;
using System.Text;
using System.Threading;

namespace ScreenClient
{
    public class ReiceveManager : Client
    {

        private ASCIIEncoding encoding = new ASCIIEncoding();   
        public void Receive()
        {
            Thread ReceiveThr = new Thread(() =>
            {
                try
                {
                    Stream streamReader = ScreeClient.GetStream();
                    string data = "";
                    while (true)
                    {
                        byte[] byteData = new byte[ScreeClient.ReceiveBufferSize];
                        streamReader.Read(byteData, 0, (int)ScreeClient.ReceiveBufferSize);
                        data = encoding.GetString(byteData);
                        if (data.Contains("DELAY"))
                        {
                            SetDelayTime(data);
                        }
                    }
                }
                catch
                {
                    NotifyMessage.showMessage("Receive was stoped", 2, 1000);
                    BeginConnect();
                }

            });
            ReceiveThr.Start();
        }
    }
}
