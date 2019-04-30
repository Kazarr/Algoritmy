using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrelamovanieHesla
{
    public class Program
    {

        private static string pass = "lol";
        private static StringBuilder sb = new StringBuilder();
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Type your pass");
            pass = Console.ReadLine();
            //CrackPass();
            
            char[] fieldPass = new char[pass.ToCharArray().Length];
            for(int i = 0; i < fieldPass.Length; i++)
            {
                fieldPass[i] = (char)97;
            }
            CrackPassRec(fieldPass);
        }

        private static void CrackPassRec(char[] fieldPass)
        {
            if (pass == new string(fieldPass))
            {
                Console.WriteLine("your pass " + new string(fieldPass));
                return;
                //Console.ReadKey();
            }
            //char[] fieldPass = new char[pass.ToCharArray().Length];
            for (int i = 0; i < fieldPass.Length; i++)
            {
                for (int j = 97; j < 123; j++)
                {
                    fieldPass[i] = (char)j;
                    
                }
            }
        }

        private static void CrackPass()
        {
            char[] fieldPass = new char[3];

            for (int i = 97; i < 123; i++)
            {
                for (int j = 97; j < 123; j++)
                {
                    for (int k = 97; k < 123; k++)
                    {
                        fieldPass[0] = (char)i;
                        fieldPass[1] = (char)j;
                        fieldPass[2] = (char)k;
                        if (pass == new string(fieldPass))
                        {
                            int result = i + j + k;
                            Console.WriteLine("i found it after:" + result + "tries");
                            Console.WriteLine("your pass is:" + new string(fieldPass));
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
