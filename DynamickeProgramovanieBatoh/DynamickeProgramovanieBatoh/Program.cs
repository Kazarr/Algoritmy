using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamickeProgramovanieBatoh
{
    class Program
    {
        private static int kapacita = 5;
        private static int[] hodnoty = new int[4] { 100, 20, 60, 40 };
        private static int[] vahy = new int[] { 3, 2, 4, 1 };
        private static int[] batoh = new int[4];
        static void Main(string[] args)
        {
            //int max = int.MinValue;
            //int maxIndex = 0;
            for(int i = 0; i < batoh.Length; i++)
            {
                int max = FindMaxHodnota();

                if (kapacita >= vahy[max])
                {
                    batoh[i] = hodnoty[max];
                    hodnoty[max] = 0;
                    kapacita -= vahy[max];
                }

                
            }
            WriteBatoh();
            Console.WriteLine();
            WriteKapacitu();

            Console.ReadLine();
        }
        private static int FindMaxHodnota()
        {
            int ret = int.MinValue;
            for (int i = 0; i < hodnoty.Length; i++)
            {
                if (hodnoty[i] > ret)
                {
                    ret = i;
                }
            }
            return ret;
        }
        private static void WriteBatoh()
        {
            foreach(var n in batoh)
            {
                Console.WriteLine(n);
            }
        }
        private static void WriteKapacitu()
        {
            Console.WriteLine(kapacita);
        }
    }
}
