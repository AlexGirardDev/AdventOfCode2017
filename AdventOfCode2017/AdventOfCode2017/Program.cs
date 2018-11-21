using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AdventOfCode2017.Puzzles.Day1;
using AdventOfCode2017.Puzzles.Day2;

namespace AdventOfCode2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1.Solve();
            Day2.Solve();
            Console.ReadKey();
        }
    }
}
