using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileApp
{
    class Program
    {
        public void Main(string[] args)
        {
            Android mob = new Android("Apple","IPhone","Android");
            int amt;
            string ph;
            Console.WriteLine("Enter the Phone Number");
            ph = Console.ReadLine();
            mob.makeCall(ph);
            Console.WriteLine("Enter the level to charge battery");
            amt = int.Parse(Console.ReadLine());
            mob.chargeBattery(amt);
            Console.WriteLine("Enter the level to use battery");
            amt = int.Parse(Console.ReadLine());
            mob.useBattery(amt);
            mob.printDetails();
        }
    }
}
