using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            var _vdata = new VehicleData();
            var _car = new Car("audi");
            var _boat = new Boat("200båt");

            _vdata.PrintVehicle(_car);
            _vdata.PrintVehicle(_boat);

            Console.ReadKey();


        }
    }
}
