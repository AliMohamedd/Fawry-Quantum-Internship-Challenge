using System;

namespace Quantum_Car
{
    public class clsCar
    {
        IEngine _EngineType;

        private short _Speed;

        public void SetEngine(IEngine Enigne)
        {
            this._EngineType = Enigne;
        }

        public void Start()
        {
            _Speed = 0;
            _EngineType.Start();
        }

        public void Stop()
        {
            _Speed = 0;
            _EngineType.Stop();
        }


        public void Accelerate()
        {
            if (_Speed < 200)
            {
                _Speed += 20;
                _EngineType.SetSpeed(_Speed);
            }
        }

        public void Brake()
        {
            if (_Speed > 0)
            {
                _Speed -= 20;
                _EngineType.SetSpeed(_Speed);
            }
        }


    }
}
