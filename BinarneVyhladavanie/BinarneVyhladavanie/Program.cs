using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarneVyhladavanie
{
    class Program
    {
        private static int[] field = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private static int pivot;
        private static int userValue = 3;
        static void Main(string[] args)
        {
            DevideAndConquer();
        }
        private static void DevideAndConquer()
        {
            pivot = (int)Math.Round((double)field.Length / 2);
            if(pivot == userValue)
            {
                return;
            }
            if(pivot > userValue)
            {

                field = new int[]
            }
        }
    }
}
