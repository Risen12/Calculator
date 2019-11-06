using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
namespace Лабиринт
{
    public static class Sound
    {
        static SoundPlayer Fail = new SoundPlayer(Properties.Resources.Fail1);
        static SoundPlayer Key = new SoundPlayer(Properties.Resources.Key1);
        static SoundPlayer Start = new SoundPlayer(Properties.Resources.Start1);
        static SoundPlayer Win = new SoundPlayer(Properties.Resources.Win1);
        static bool sound_enabled = true;
        public static void sound_on() {
            sound_enabled = true;
        }
        public static void sound_off()
        {
            sound_enabled = false;
        }
        public static void play_fail()
        {
            if(sound_enabled)
            Fail.Play();
        }
        public static void play_key()
        {
            if (sound_enabled)
            Key.Play();
        }
        public static void play_start()
        {
            if (sound_enabled)
            Start.Play();
        }
        public static void play_win()
        {
            if (sound_enabled)
            Win.Play();
        }
    }
}