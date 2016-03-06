using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise10
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 15. In your Main method, create an instance of the VehicleData class.  
            16. In your Main method, create one instance of every Vehicle sub class (Car, Bicycle and so on).  
            17. Try passing the variable to PrintVehicle and watch the output. Notice that you can send anything that inherits from Vehicle to PrintVehicle. 
            You have now created a relatively simple inheritance hierarchy. We can send any object in the hierarchy to the PrintVehicle - It doesn’t need to know more than the base type. 
            */
            var _vdata = new VehicleData();
            var _car = new Car("audi");
            var _boat = new Boat("200båt");

            _vdata.PrintVehicle(_car);
            _vdata.PrintVehicle(_boat);

            Console.ReadKey();

        }
    }
}
