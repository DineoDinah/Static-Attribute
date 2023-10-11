using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs Holiday = new Songs("Holiday", "Green day", 2);
            Songs Kashmir = new Songs("Kashmir", "Led Zeppelin", 3);

            Console.WriteLine(Songs.songCount);
            Console.ReadLine();
        }
    }
}
