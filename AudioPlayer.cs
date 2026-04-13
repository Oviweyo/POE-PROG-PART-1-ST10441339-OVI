using System;
using System.IO;
using System.Runtime.InteropServices;

namespace NetSecureBotChat
{
    public static class AudioPlayer
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string command, string returnString, int returnLength, IntPtr callback);

        public static void PlayGreeting()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav");

                if (!File.Exists(path))
                {
                    Console.WriteLine("Audio file not found: " + path);
                    return;
                }

                string cmd = $"open \"{path}\" type waveaudio alias sound";
                mciSendString(cmd, null, 0, IntPtr.Zero);

                mciSendString("play sound wait", null, 0, IntPtr.Zero);

                mciSendString("close sound", null, 0, IntPtr.Zero);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audio error: " + ex.Message);
            }
        }
    }
}