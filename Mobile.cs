using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileApp
{
    public class Mobile
    {
        public string brand;
        public string model;
        public int battery_level;

        public Mobile(string brand,string model)
        {
            this.brand = brand;
            this.model = model;
            this.battery_level = 0;
        }
        public void makeCall(String mobNo)
        {
            Console.WriteLine(mobNo);
            Console.ReadLine();
        }
        public void chargeBattery(int amt)
        {
            if ((battery_level + amt) <= 100)
            
                battery_level += amt;
            
            else
                battery_level = 100;
        }
        public void useBattery(int amt)
        {
            if (battery_level > 0)
            {
                battery_level -= amt;
            }
            else
            { 
                Console.WriteLine("Charge Phone");
                Console.ReadLine();
            }   
        }
        public void printDetails()
        {
            Console.WriteLine("Brand: "+ brand);
            Console.WriteLine("Model: "+ model);
            Console.WriteLine("Battery Level: "+ battery_level);
            Console.ReadLine();
        }
    }
}
