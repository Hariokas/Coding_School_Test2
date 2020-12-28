using System;

namespace _4_task
{
    class Program
    {
        static void Main(string[] args)
        {
            BmwCar BMW = new BmwCar();
            AnyOtherCar AnyOtherCar = new AnyOtherCar();

            BMW.Drive();
            BMW.Park();

            AnyOtherCar.Drive();
            AnyOtherCar.Park();

        }
    }
    interface IVehicle
    {
        void Drive();
        void Park();
    }

    class BmwCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving into the bus stop");
        }
        public void Park()
        {
            Console.WriteLine("Parking on as many parking spots as possible at the same time");
        }
    }

    class AnyOtherCar : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving to the destination");
        }
        public void Park()
        {
            Console.WriteLine("Parking on a single parking spot");
        }
    }
}
