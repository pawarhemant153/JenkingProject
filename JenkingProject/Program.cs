using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JenkingProject
{
    internal class Program
    {
        void Addition()
        {
            int d, e, f;
            int a=10, b=20, c;
            c = a + b;
            Console.WriteLine("Addition= " + c);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Addition();
            Console.ReadLine();
        }
    }
}
