using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;

namespace Dedale
{
    public static class SoundManager
    {
        public static void playTitleAmbience()
        {
            playSound(@"media\title.wav");
            //Thread.Sleep(4500);
        }

        public static void playSound(string filePath)
        {
            SoundPlayer sp = new SoundPlayer(filePath);
            try
            {
                sp.SoundLocation = filePath;
                sp.Load();
                sp.Play();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Midi File Trouble: {0} \r\n {1} \r\n {2}", filePath, ex.Message, ex.StackTrace));
            }
        }
    }
}
