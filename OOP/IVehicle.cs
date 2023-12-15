using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IVehicle
    {
        void Accelerate();
        void Accelerate(int speedValue);
        void Brake(int brakeValue);
    }
}
