using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLRobot
{
    [Serializable]
    public class EventoSeguirLinea
    {
        public  DateTime timeStamp;
        public bool sensor1;
        public bool sensor2;
        public EventoSeguirLinea(bool valor1, bool valor2) {
            this.timeStamp = DateTime.Now;
            this.sensor1 = valor1;
            this.sensor2 = valor2;
        }
    }
}
