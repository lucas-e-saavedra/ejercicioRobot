using BLLRobot.Componentes;
using System;

namespace ConsoleApp1
{
    class MotorConsola : IMotor
    {
        public string nombre { get; set; }
        public MotorConsola(string unNombre)
        {
            this.nombre = unNombre;
        }
        public void Avanzar()
        {
            Console.WriteLine("El motor {0} está avanzando", nombre);
        }

        public void Frenar()
        {
            Console.WriteLine("El motor {0} está quieto", nombre);
        }

        public void Retroceder()
        {
            Console.WriteLine("El motor {0} está retrocediendo", nombre);
        }
    }
}
