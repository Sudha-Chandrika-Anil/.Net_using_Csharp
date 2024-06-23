using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp
{
    public abstract class Mobile
    {
        protected String brand;
        protected String model;
        protected int batteryLevel;

        public Mobile(String brand, String model)
        {
            this.brand = brand;
            this.model = model;
            this.batteryLevel = 0;
        }
        public abstract void StartDevice();
        public abstract void UseDevice();
        public virtual void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand + "\nModel: " + model + "\nBattery Level: " + batteryLevel);
        }
    }
}
