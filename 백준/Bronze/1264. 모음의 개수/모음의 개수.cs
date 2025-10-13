using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine().ToUpper();

                int cnt = 0;

                if (s.Equals("#"))
                {
                    return;
                }
                else
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i].Equals('A') || s[i].Equals('E') || s[i].Equals('I') || s[i].Equals('U') || s[i].Equals('O'))
                        {
                            cnt++;
                        }
                    }

                    Console.WriteLine(cnt);
                }
            }
        }
    }
}