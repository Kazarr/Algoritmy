using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnihgtMovement
{
    public class Program
    {
        private static int[,] chessBoard = new int[8, 8];
        private static bool[,] visitedChessBoard = new bool[8, 8];
        private static int moves = 0;
        private static List<Tuple<int, int>> possibleMoves = new List<Tuple<int, int>>();
        public static void Main(string[] args)
        {
            possibleMoves.Add(Tuple.Create(2, 1));
            possibleMoves.Add(Tuple.Create(2, -1));
            possibleMoves.Add(Tuple.Create(1, -2));
            possibleMoves.Add(Tuple.Create(-1, -2));
            possibleMoves.Add(Tuple.Create(-2, -1));
            possibleMoves.Add(Tuple.Create(-2, 1));
            possibleMoves.Add(Tuple.Create(-1, +2));
            possibleMoves.Add(Tuple.Create(1, 2));
            Console.WriteLine("Type start position");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            FindNextMove(x, y);

        }

        private static bool ValidateMove(int x, int y)
        {
            if (x >= 8 || y >= 8 || x <= -1 || y <= -1)
            {
                return false;
            }
            else if (!visitedChessBoard[x, y])
            {
                return true; ;
            }
            else { return false; }
                
        }

        private static Tuple<int,int> MoveKnight(int x, int y)
        {
            for(int i = 0; i < possibleMoves.Count; i++)
            {
                Tuple<int, int> temp = possibleMoves[i];
                if (temp.Item1 >= 8 || temp.Item2 >= 8 || temp.Item1 <= -1 || temp.Item2 <= -1)
                {
                    return false;
                }
            }
        }

        private static bool FindNextMove(int x, int y)
        {
            var tuple = MoveKnight(x, y);
            if(chessBoard)
            visitedChessBoard[tuple.Item1, tuple.Item2] = true;
            chessBoard[tuple.Item1, tuple.Item2] = moves;
            moves++;
            if (moves == 64)
            {
                return false;
            }
            FindNextMove(tuple.Item1, tuple.Item2);


            throw new Exception("wrong again");
        }
    }
}
