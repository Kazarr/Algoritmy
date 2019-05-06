using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    class Program
    {
        public static int[,] Dijkstra = new int[11,11]
        {	// BA   BR   KE   LC   MT   NR   PD   PP   RK   ZA   ZV

            { 0,   0,   0,   0,   0,  90,   0,   0,   0, 198,   0 },  // BA

            { 0,   0, 178,  77,   0,   0,   0,  81,   0,   0,  67 },  // BR

            { 0, 178,   0, 163,   0,   0,   0, 118,   0,   0,   0 },  // KE

            { 0,  77, 163,   0,   0, 159,   0,   0,   0,   0,  59 },  // LC

            { 0,   0,   0,   0,   0,   0,  52,   0,  44,  33,  79 },  // MT

            { 90,   0,   0, 159,   0,   0,  87,   0,   0,   0, 102 },  // NR

            { 0,   0,   0,   0,  52,  87,   0,   0,   0,  63,  64 },  // PD

            { 0,  81, 118,   0,   0,   0,   0,   0,  79,   0,   0 },  // PP

            { 0,   0,   0,   0,  44,   0,   0,  79,   0,   0,  76 },  // RK

            { 198,   0,   0,   0,  33,   0,  63,   0,   0,   0,   0 },  // ZA

            { 0,  67,   0,  59,  79, 102,  64,   0,  76,   0,   0 }   // ZV
        };
        public static int[] distances = new int[11]

            { int.MaxValue,   int.MaxValue,   int.MaxValue,   int.MaxValue,   int.MaxValue,  int.MaxValue,   int.MaxValue,   int.MaxValue,   int.MaxValue, int.MaxValue,   int.MaxValue };  // BA

        public static List<int> ShortestPath = new List<int>();
        public static int x = 0, y = 0;
        static void Main(string[] args)
        {
            distances[x] = 0;
            DijsktraAlgorythm();
            WriteDijsktra();
            Console.ReadKey();


        }

        private static void DijsktraAlgorythm()
        {
            int u = 0;
            if(ShortestPath.Count == 11)
            {
                return;
            }
            for(int i = 0; i < 11; i++)
            {
                if(distances[i] < distances[u] && !ShortestPath.Contains(i))
                {
                    u = i;
                }
            }
            ShortestPath.Add(u);
            for( int v = 0; v < 11; v++)
            {
                int distanceU = distances[u];
                int distanceV = distances[v];
                int distanceUV = Dijkstra[u, v];
                if(distanceUV > 0 && !ShortestPath.Contains(v) && distanceU + distanceUV < distanceV)
                {
                    distanceV = distanceU + distanceUV;
                }
            }
            DijsktraAlgorythm();
        }
        private static void WriteDijsktra()
        {
            foreach(int i in distances)
            {
                Console.Write(i + " ");
            }
        }
    }
}
