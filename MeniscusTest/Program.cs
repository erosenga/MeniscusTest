﻿using System;
using MeniscusTracking;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main( string[] args )
        {
            var start = args.Length > 1 ? Convert.ToInt32( args[1] ) : 0;
            var end = args.Length > 2 ? Convert.ToInt32( args[2] ) : 0;
            var c = new Class1();
            var path = Environment.GetEnvironmentVariable( "PATH" );
            path = 
                // "C:\\Users\\rosengau\\source\\repos\\MeniscusTest\\MeniscusTest\\bin\\x64\\Debug\\net6.0;" +
                "C:\\Users\\rosengau\\source\\repos\\MeniscusTracking\\MeniscusTracking\\bin\\x64\\Debug;" + path;
            Environment.SetEnvironmentVariable( "PATH", path);
            Console.WriteLine( Environment.GetEnvironmentVariable( "PATH" ) );
            var ret = c.MeniscusTop( args[0], start, end );

            Console.WriteLine( ret );
        }
    }
}
