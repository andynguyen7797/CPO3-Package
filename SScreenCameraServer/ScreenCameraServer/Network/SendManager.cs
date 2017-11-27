using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ScreenCameraServer
{
    public class SendManager
    {
        private Camera camera;
        private Socket client;
        private ASCIIEncoding encoding = new ASCIIEncoding();

        public SendManager(Camera camera,Socket client)
        {
            this.camera = camera;
            this.client = client;
            SetEvents();
        }

        private void SetEvents()
        {
            camera.SetEvent(SendDelayTime);
        }

        private void SendDelayTime(object sender,EventArgs e)
        {
            string delayTime = camera.GetDelayTime();
            if(delayTime == null)
            {
                MessageBox.Show("Định dạng không đúng");
            } else
            {
                client.Send(encoding.GetBytes("DELAY " + delayTime));
            }
          
        }

        public void DeleteEventOfClient()
        {
            camera.DeleteEventFromOldClient(SendDelayTime);
        }
    }
}
