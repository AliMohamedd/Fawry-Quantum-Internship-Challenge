using System;

namespace Quantum_Car
{
    public interface IEngine
    {
        void Start();

        void Stop();

        void SetSpeed(short NewSpeed);

        void Increase();

        void Decrease();
    }
}
