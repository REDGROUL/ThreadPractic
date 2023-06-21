using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank(100, 15, "Frodo");
            Console.WriteLine(b.Money);

            b.Money = 250;
            Console.ReadLine();
            
        }
    }
}
