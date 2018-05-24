using System;

namespace Classes
{
    public class Vehicle
    {
        public int speed { get; set; }

        public int Engine { get; set; }

        public void StartEngine()
        {

        }
    }

    public class Motorcycle:Vehicle
    {
        public int wheels { get; set; }
    }

    public class Car:Vehicle
    {
        public int wheels { get; set; }
    }

    public class DieselCar : Car
    {
        public int loud { get; set; }

        public void EngineCrash()
        {
            speed = 0;
        }
    }

    public class BenyaCar : Car
    {

    }

    public class ElectricCar :Car
    {

    }

    public class Ship : Vehicle
    {
        public int MoveonWater { get; set; }
    }

    public class Truck: Vehicle
    {

    }

    public class Bus : Vehicle
    {

    }


}
