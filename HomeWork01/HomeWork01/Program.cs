// A Hello World! program in C#.
// MSDN (2015).  Hello World -- Your First Program (C# Programming Guide).  Retrieved October 5, 2015 from https://msdn.microsoft.com/en-us/library/k1sx6ed2.aspx

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01  // Bisciotti
{
    class Hello
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");  // entry point for code to start
            Console.ReadLine();
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
