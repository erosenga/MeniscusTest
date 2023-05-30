using System;
using MeniscusTracking;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var start = args.Length > 1 ? Convert.ToInt32(args[1]) : 0;
            var end = args.Length > 2 ? Convert.ToInt32(args[2]): 0;
            var c = new Class1();
            c.MeniscusTop(args[0], start, end);
        }
    }
}
