using System;
using System.Collections.Generic;
using jogodaforca.libs.Entities;
using jogodaforca.libs.Utils;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            string path = @"C:\temp\bancodedados.txt";
            var commander = new Commander(args, path);
            commander.Run();          
        }
    }
}