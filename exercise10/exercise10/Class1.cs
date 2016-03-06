using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise10
{
    public class Vehicle
    {
        private string _vehicletyp; 
        public Vehicle (string vehicletyp)
        {
            this._vehicletyp = vehicletyp;

        }
        public Vehicle()
        {
            this._vehicletyp = "Car";

        }


        public string DescribeVehicle()
        {

            return "This vehicle is a " + this._vehicletyp;
        }


    }
    class Car : Vehicle
    {
        private string _carmodell;
        private bool _engineIsRunning;

        public Car(string carmodell) : base ()
            
        {
            this._carmodell = carmodell;
            this._engineIsRunning = false;
        }

        public void StartEngine()
        {
            this._engineIsRunning = true;

        }

        public void StopEngine()
        {
            this._engineIsRunning = false;

        }
    }
        class Boat:Vehicle
    {
        private string _boattype;
        private bool _ankerIsDown = false;

        public Boat(string boattype): base("Boat")
         {
            this._boattype = boattype;
         }

        public void TakedownAnker()
        {
            this._ankerIsDown = true;

        }

        public void TakeupAnker()
        {
            this._ankerIsDown = false;

        }


    }

    class VehicleData 
    {
        


        public void PrintVehicle(Vehicle v)
        {
            Console.WriteLine(v.DescribeVehicle());
        }



    }








}
