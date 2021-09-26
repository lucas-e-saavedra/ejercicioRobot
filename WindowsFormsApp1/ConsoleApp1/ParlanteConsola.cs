using BLLRobot.Componentes;
using System;

namespace ConsoleApp1
{
    class ParlanteConsola : IParlante
    {
        public void ReproducirSonido()
        {
            Console.WriteLine("El parlante está encendido");
        }

        public void Silenciar()
        {
            Console.WriteLine("El parlante está apagado");
        }
    }
}
