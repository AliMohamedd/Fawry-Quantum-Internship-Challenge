using System;

namespace Quantum_Car
{
    public class clsGasEngine : IEngine
    {
        private short _EngineSpeed;

        public clsGasEngine()
        {
            _EngineSpeed = 0;
        }

        public void Start()
        {
            Console.WriteLine("Gas Engine Started");
        }

        public void Stop()
        {
            _EngineSpeed = 0;
            Console.WriteLine("Gas Engine Stoped");
        }

        public void SetSpeed(short NewSpeed)
        {
            _EngineSpeed = NewSpeed;
            Console.WriteLine($"Speed has changed:{_EngineSpeed} Km/H");
        }

        public void Increase()
        {
            _EngineSpeed += 1;
            Console.WriteLine("Speed Increased By 1");
        }

        public void Decrease()
        {
            _EngineSpeed -= 1;
            Console.WriteLine("Speed Decreased By 1");
        }
    }
}
