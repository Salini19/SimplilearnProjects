using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseAssignmnets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Repos\PracticeProject\student.txt";
            var lines = File.ReadAllText(path);
            Console.WriteLine(lines);


            Console.ReadLine();
        }
    }
}
