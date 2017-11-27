using System.Collections.Generic;
using System.Threading;

namespace CPO3_Remaker
{
    public class Backup
    {
        private const string backUpfilePath = "";
        private int timeToBackup = 15000;
        private List<Player_Control> listPlayer = new List<Player_Control>();

        public Backup(List<Player_Control> listPlayer)
        {
            this.listPlayer = listPlayer;
        }

        public void StartBackupProcess()
        {
            Thread backUpThread = new Thread(() => {

                while (true)
                {
                    for(int i = 0; i < Cons.PLAYER_COUNT; i++)
                    {
                        SaveBackupDataToFile(listPlayer[i].Player_name, listPlayer[i].Player_score.ToString(), listPlayer[i].AvatarPath);
                    }
                }          
            });
        }

        public void StopBackup()
        {

        }

        public void SaveBackupDataToFile(string name,string currentScore,string avatarPath)
        {

        }

        public void GetBackupData()
        {

        }

    }
}
