using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPO3_Remaker
{
    public class Cons
    {
        // Lớp quản lí các hằng số

        public static int PLAYER_COUNT = 4; // số thí sinh

        // special file path
        public static string BACKGROUND_TEMPLATE_PATH = Application.StartupPath + "\\Resource\\Background";
        public static string ALARM_SOUND_PATH = Application.StartupPath + "\\Resource\\Sound\\chuong.wav";
        public static string DEFAULT_USER_LOGO_PATH = Application.StartupPath + "\\Resource\\Default Logo\\user.png";
        public static string LOG_FILE_PATH = Application.StartupPath + "\\Resource\\Data\\Player";
        public static string DATA_OF_MANHINHDIEM = Application.StartupPath + "\\Resource\\Data\\DataOfDiemView.dat";
        public static string DATA_OF_MANHINHTRALOI = Application.StartupPath + "\\Resource\\Data\\DataOfTraLoiView.dat";
        public static string ABOUT_AUTHOR_PAGE_PATH = Application.StartupPath + "\\Resource\\About Author\\about_authot.html";

        //special Color
        public static Color LOCKED = Color.FromArgb(46,204,113);
        public static Color UNLOCKED = Color.FromArgb(27, 32, 40);
        public static Color CPU_USAGE_NORMAL = Color.FromArgb(46,204,113);
        public static Color CPU_USAGE_MEDIUM = Color.FromArgb(241, 196, 15);
        public static Color CPU_USAGE_MAXIUM = Color.FromArgb(192, 57, 43);
    }
}
