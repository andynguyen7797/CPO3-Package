using System.Net.Sockets;

namespace ScreenCameraServer
{
    public class ReiceverManager
    {

        private Camera camera;
        private Socket client;

        public ReiceverManager(Socket client,Camera camera)
        {
            this.client = client;
            this.camera = camera;
        }

        public void ReceiveData()
        {
            try
            {
                while (true)
                {
                    byte[] ImageData = new byte[Cons.BUFFER_SIZE_IMAGE];
                    client.Receive(ImageData);
                    if(ImageData.Length != 0)
                    {
                        camera.SetImageToCam(ImageData);
                    }
                }
            }
            catch
            {
                this.client.Close();
                camera.SetDefault();
            }
        }
    }
}
