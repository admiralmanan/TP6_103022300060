using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private int playCount = 0;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null, "Judul video tidak boleh null!");
            Debug.Assert(title.Length <= 100, "Judul video tidak boleh lebih dari 100 karakter!");

            this.id = new Random().Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void increasePlayCount(int count) {

            Debug.Assert(count >= 0 && count <= 10_000_000, "Jumlah penambahan play count tidak valid!");

            try
            {
                // Mencegah overflow dengan `checked`
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow terjadi! Play count tidak bisa ditambahkan.");
            }
        }

        public void printVideoDetails()
        {
            Console.WriteLine("Video ID : " + this.id);
            Console.WriteLine("Judul : " + this.title);
            Console.WriteLine("Banyak Pemutaran : " + this.playCount);
        }
    }
}
