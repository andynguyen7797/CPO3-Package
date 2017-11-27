using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ScreenCameraServer
{
    public partial class Camera : UserControl
    {
        #region Properties
        private string indexOfUser;
        public string IndexOfUser
        {
            get
            {
                return indexOfUser;
            }

            set
            {
                indexOfUser = value;
            }
        }
   
        private EnumManager.ModeOfCamera mode;
        public EnumManager.ModeOfCamera Mode
        {
            get
            {
                return mode;
            }

            set
            {
                mode = value;
            }
        }

        private string someInfo;
        public string SomeInfo
        {
            get
            {
                return someInfo;
            }

            set
            {
                someInfo = value;
            }
        }
        #endregion

        public Camera()
        {
            InitializeComponent();
        }

        #region Methods
        public void SetImageToCam(byte[] data)
        {
            Image img = ConvertAnyThing.ConvertByteArraytoImage(data);
            cameraView.BackgroundImage = img;
        }

        public void SetDefault()
        {
            cameraView.BackgroundImage = null;
            this.Tag = "NULL";
            this.Enabled = false;
        }

        public string GetDelayTime()
        {
            int testTimeFormat;
            if(int.TryParse(delay_tb.Text,out testTimeFormat))
            {
                return delay_tb.Text;
            } else
            {
                return null;
            }
        }

        public void SetEvent(EventHandler events)
        {
            setDelayTime.Click += events;
        }

        public void DeleteEventFromOldClient(EventHandler events)
        {
            setDelayTime.Click -= events;
        }
        #endregion

        #region Events
        private void infoOfCamera_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SomeInfo);
        }

        private void zoomOutCamera_Click(object sender, EventArgs e)
        {
            CameraFullScreen cameraViewForm = new CameraFullScreen();
            cameraViewForm.Show();
            Thread screenCaptureThr = new Thread(() => {
                while(!cameraView.IsDisposed)
                {
                    cameraViewForm.GetScreenCapture(cameraView.BackgroundImage);
                }                
            });
            screenCaptureThr.Start();
        }
        #endregion
    }
}
