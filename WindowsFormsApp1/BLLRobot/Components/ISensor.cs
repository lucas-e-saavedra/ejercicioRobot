using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLRobot.Componentes
{
    public interface ISensor
    {
        void Suscribirse(ISensorObserver sensorObserver);
        void Desuscribirse();
        bool LeerValor();
    }

    public interface ISensorObserver
    {
        void CambioEstadoSensor();
    }
}
