using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void MDelegate();
namespace MutiDelegate
{
    internal class DM
    {
        static public void Display()
        {
            Console.WriteLine("New Delhi");
        }
        static public void Print()
        {
            Console.WriteLine("London");
        }
    }
}
