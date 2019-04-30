using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ObsahAdresara
{
    public class Program
    {
        public static StringBuilder sb = new StringBuilder();
        public static int i = 0;
        public static void Main(string[] args)
        {
            Console.WriteLine("Cesta k suboru:");
            string path = Console.ReadLine();

            InsideDirectory(path);
            Console.ReadLine();
        }

        private static void InsideDirectory(string path)
        {
            //toto som nedal :(
        }
    }
}
