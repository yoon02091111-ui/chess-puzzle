using System;
using System.Collections.Generic;
using static System.Console;

namespace intergral
{
    class app
    {
        enum abc { yes, no, cancle, confrim, ok }
        static void Main(string[] args)
        {
            abc result = abc.yes;
            Console.WriteLine(result == abc.yes);
            Console.WriteLine(result == abc.no);
            Console.WriteLine(result == abc.cancle);

        }
    }
}