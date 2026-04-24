using System;

namespace Quantum_Car
{
    public class clsHybridEngine : IEngine
    {
        IEngine _OperatingEngine;
        public clsElectricEngine _Electric;
        public clsGasEngine _Gas;
        private short _EngineSpeed;

        public clsHybridEngine()
        {
            _Gas = new clsGasEngine();
            _Electric = new clsElectricEngine();
        }

        public void Start()
        {
            _EngineSpeed = 0;
            _OperatingEngine = _Electric;
            Console.WriteLine("The electric engine started.");
        }

        public void Stop()
        {
            _OperatingEngine?.Stop();
        }

        private void UpdateOperatingEngine(short NewSpeed)
        {
            if (NewSpeed > 50 && _EngineSpeed <= 50)
            {
                _Gas.Start();
                _Electric.Stop();
                _OperatingEngine = _Gas;
                Console.WriteLine("Engine switched to gas.");
            }
            else if (NewSpeed <= 50 && _EngineSpeed > 50)
            {
                _Electric.Start();
                _Gas.Stop();
                _OperatingEngine = _Electric;
                Console.WriteLine("Engine switched to electric.");
            }
        }

        public void SetSpeed(short NewSpeed)
        {
            UpdateOperatingEngine(NewSpeed);
            _EngineSpeed = NewSpeed;
            _OperatingEngine.SetSpeed(_EngineSpeed);
            Console.WriteLine("The Speed Changes");
        }

        public void Increase()
        {
            _EngineSpeed += 1;
            _OperatingEngine.Increase();
            SetSpeed(_EngineSpeed);
        }

        public void Decrease()
        {
            _EngineSpeed -= 1;
            _OperatingEngine.Decrease();
            SetSpeed(_EngineSpeed);
        }
    }
}
