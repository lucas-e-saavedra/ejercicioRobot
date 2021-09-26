using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLRobot.Componentes
{
    public interface IMotor
    {
        void Avanzar();
        void Retroceder();
        void Frenar();
    }
}
