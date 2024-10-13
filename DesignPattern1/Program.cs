using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1= Singleton.GetInstance();
            s1.getDatabaseObject().stringSet("Cricketer", "Rohit Sharma");

            Singleton s2= Singleton.GetInstance();

            Console.WriteLine("Hello");

            
            Console.ReadLine();
        }
    }
}
