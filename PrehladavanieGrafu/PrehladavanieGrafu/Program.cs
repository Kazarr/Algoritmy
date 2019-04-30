using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrehladavanieGrafu
{
    public class Program
    {
        private static bool[,] _graph = new bool[,]
                                                {
                                                    {false, false, false, true, false, false, false, false},
                                                    {true, false, false, false, false, false, false, false},
                                                    {false, false, false, false, true, false, false, true},
                                                    {false, false, false, false, false, true, true, true},
                                                    {false, true, false, false, false, false, true, false},
                                                    {false, false, false, false, false, false, false, false},
                                                    {false, false, false, false, false, false, false, false},
                                                    {false, false, false, false, false, false, false, false}
                                                };

        private static List<int> _visited = new List<int>();
        private static Stack<int> _toVisitDFS = new Stack<int>();


        public static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Write your starting node");
            x = int.Parse(Console.ReadLine());
            MethodDFS(x);
            Console.ReadLine();
        }
        /// <summary>
        /// Toto som odp9sal od jakuba... ale už mi to čosi robilo... (samozrejme zle)
        /// </summary>
        /// <param name="x"></param>
        private static void MethodDFS(int x)
        {
            if (!_visited.Contains(x))
            {
                _visited.Add(x);
                for(int i = 0; i < 8; i++)
                {
                    if(_graph[x,i] && !_visited.Contains(i))
                    {
                        _toVisitDFS.Push(i);
                    }
                }
                if (_toVisitDFS.Count > 0)
                {
                    MethodDFS(_toVisitDFS.Pop());
                }
            }
        }
           

        //private static void AddNodesDFS(bool userNode)
        //{
        //    for(int i = 0;i<)
        //}

    }
}
