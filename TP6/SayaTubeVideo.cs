using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.id = new Random().Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void increasePlayCount(int playCount) {
            this.playCount += playCount;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("Video ID : " + this.id);
            Console.WriteLine("Judul : " + this.title);
            Console.WriteLine("Banyak Pemutaran : " + this.playCount);
        }
    }
}
