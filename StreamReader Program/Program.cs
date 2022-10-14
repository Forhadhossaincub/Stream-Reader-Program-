using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReader_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(@"..\..\Program.cs");

            int i = 0;

            for (string line = sr.ReadLine(); line != null; line = sr.ReadLine())
            {
                Console.WriteLine($"{++i:00} {line} ");
            }

            sr.Close();

            Console.ReadKey();



        }
    }
}
