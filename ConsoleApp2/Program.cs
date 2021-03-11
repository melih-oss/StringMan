using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string a = "melihakman07@hotmail.com";
            char[] b = new char[12];
            int i;
            for(i = 0; a[i] !=  '@' ; i++)
            {
                b[i] = a[i];
            }
            Console.WriteLine(i);
            Console.WriteLine(b);
            Console.Read();
        }
    }
}
