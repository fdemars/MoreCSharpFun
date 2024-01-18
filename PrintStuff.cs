using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharpFun
{
    internal class PrintStuff

    {
        private string language; 

        // Constructor
        public PrintStuff()
        {
            language = "EN"; 
        }
        public PrintStuff(string temp)
        {
            language = temp;
        }
    
        public void PrintName(string n)
        {
            if (language == "EN")
            {
                System.Console.WriteLine("Hello, " + n + "!");
            }

            if (language == "PT")
            {
                System.Console.WriteLine("Oi, " + n + "!");
            }
        }
    }
}
