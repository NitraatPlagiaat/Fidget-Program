using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fidget_Program
{
    class Music
    {
        private static int alreadyPlayed = 0;
        private static Random rand = new Random();
        public static string[] rammstein = new string[]
        {
            "https://www.youtube.com/watch?v=YtEWoavDlcM",
            "https://www.youtube.com/watch?v=EOnSh3QlpbQ",
            "https://www.youtube.com/watch?v=NeQM1c-XCDc",
            "https://www.youtube.com/watch?v=W3q8Od5qJio",
            "https://www.youtube.com/watch?v=rrmsJhf89MY"
        };

        public static string[] slipknot = new string[]
        {
            "https://www.youtube.com/watch?v=5abamRO41fE",
            "https://www.youtube.com/watch?v=VpATBBRajP8",
            "https://www.youtube.com/watch?v=wLoYIBEZEfw",
            "https://www.youtube.com/watch?v=6fVE8kSM43I",
            "https://www.youtube.com/watch?v=m3I3-KTJbtY"
        };

        public static string[] behemoth = new string[]
        {
            "https://www.youtube.com/watch?v=mwHng79Scv8",
            "https://www.youtube.com/watch?v=Cx01fOYsc6E",
            "https://www.youtube.com/watch?v=05hAQWiX4F4",
            "https://www.youtube.com/watch?v=Dhfy9TPga-c",
            "https://www.youtube.com/watch?v=g7yxjTcM7Bs"
        };

        public static string[] muse = new string[]
        {
            "https://www.youtube.com/watch?v=UqLRqzTp6Rk",
            "https://www.youtube.com/watch?v=3dm_5qWWDV8",
            "https://www.youtube.com/watch?v=w8KQmps-Sog",
            "https://www.youtube.com/watch?v=G_sBOsh-vyI",
            "https://www.youtube.com/watch?v=6uBK5kvakD8"
        };

        internal static void getRandomSong(string[] songs)
        {
            while (true)
            {
                int index = rand.Next(0, songs.Length);
                if (index != alreadyPlayed)
                {
                    System.Diagnostics.Process.Start(songs[index]);
                    alreadyPlayed = index;
                    break;
                }
            }
        }
    }
}
