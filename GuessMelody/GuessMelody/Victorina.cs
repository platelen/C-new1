using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessMelody
{
    static class Victorina
    {
        static public List<string> list = new List<string>();
        static public int gameDuraction = 60;
        static public int musiciDuraction = 10;
        static public bool randomStart = false;
        static public string lastFolder = "";
        static public bool allDirectories = false;


        static public void ReadMusic()
        {
            string[] music_files = Directory.GetFiles(lastFolder, "*.mp3", allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            list.Clear();
            list.AddRange(music_files);
        }

        static string regkeyName = "Software\\platelenCompany\\GuessMelody";

        public static void WriteSetttings()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regkeyName);
                if(rk == null)
                {
                    return;
                }
                rk.SetValue("LastFolder", lastFolder);
                rk.SetValue("RandomStart", randomStart);
                rk.SetValue("GameDuration", gameDuraction);
                rk.SetValue("MusicDuration", musiciDuraction);
                rk.SetValue("AllDirectories", allDirectories);
            }
            finally
            {
                if(rk !=null)
                {
                    rk.Close();
                }
            }
        }

        public static void ReadSettings()
        {
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regkeyName);
                if(rk !=null)
                {
                    lastFolder = (string)rk.GetValue("LastFolder");
                    gameDuraction = (int)rk.GetValue("GameDuraction");
                    randomStart = Convert.ToBoolean(rk.GetValue("RandomStart", false));
                    musiciDuraction = (int)rk.GetValue("MusicDuration");
                    allDirectories = Convert.ToBoolean(rk.GetValue("AllDirectories",false));
                }
            }
            finally
            {
                if (rk !=null)
                {
                    rk.Close();
                }
            }
        }
         
    }
}
