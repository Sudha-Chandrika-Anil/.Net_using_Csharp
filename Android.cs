using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileApp
{
    public class Android:Mobile,icamera,igps
    {
        public string os;
        public Android(string brand,string model,string os):base(brand,model)
        {
            this.os = os;
        }
        public void printDetails()
        {
            Console.WriteLine(base.brand);
            Console.WriteLine(base.model);
            Console.WriteLine(base.battery_level);
            Console.WriteLine(os);
            Console.ReadLine();
        }

        void takePhoto()
        {

        }
        void getLocation()
        {

        }
    }
}
