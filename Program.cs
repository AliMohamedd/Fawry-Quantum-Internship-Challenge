using System;

namespace Quantum_Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gas Car Test");

            clsCar gas = clsCarFactory.CreateCar(enEngineType.Gas);

            gas.Start();
            gas.Accelerate();
            gas.Accelerate();
            gas.Brake();
            gas.Stop();


            Console.WriteLine("\nHybrid Test");

            clsCar hybrid = clsCarFactory.CreateCar(enEngineType.Hybrid);

            hybrid.Start();

            hybrid.Accelerate(); //20
            hybrid.Accelerate(); //40
            hybrid.Accelerate(); //60 switch gas
            hybrid.Brake();      //40 switch electric

            hybrid.Stop();


            Console.WriteLine("\nEngine Replacement Test");

            clsCar car = clsCarFactory.CreateCar(enEngineType.Gas);

            clsCarFactory.InstallEngine(car, enEngineType.Electric);

            car.Start();

            Console.ReadKey();
        }
    }
}
