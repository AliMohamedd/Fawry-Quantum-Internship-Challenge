using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum_Car
{
    public enum enEngineType { Gas, Electric, Hybrid };

    public static class clsCarFactory
    {
        private static IEngine CreateEngine(enEngineType Type)
        {
            switch (Type)
            {
                case enEngineType.Gas:
                    return new clsGasEngine();
                case enEngineType.Electric:
                    return new clsElectricEngine();
                case enEngineType.Hybrid:
                    return new clsHybridEngine();
                default:
                    throw new ArgumentException("Invalid Engine Type");
            }
            //return Type switch
            //{
            //    enEngineType.Gas => new clsGasEngine(),
            //    enEngineType.Electric => new clsElectricEngine(),
            //    enEngineType.Hybrid => new clsHybridEngine(),
            //    _ => throw new ArgumentException("Invalid Engine Type")
            //};
        }

        public static void InstallEngine(clsCar Car, enEngineType Type)
        {
            Car.SetEngine(CreateEngine(Type));
        }

        public static clsCar CreateCar(enEngineType Type)
        {
            clsCar Car = new clsCar();
            InstallEngine(Car, Type);
            return Car;
        }
    }
}
