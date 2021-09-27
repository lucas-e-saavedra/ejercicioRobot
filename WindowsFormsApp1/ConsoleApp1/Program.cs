using BLLRobot;
using BLLRobot.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Robot unRobot = new Robot();
            unRobot.setSensorIzquierdo(new SensorConsola("sensor1"));
            unRobot.setSensorDerecho(new SensorConsola("sensor2"));
            unRobot.setMotorIzquierdo(new MotorConsola("motor1"));
            unRobot.setMotorDerecho(new MotorConsola("motor2"));
            unRobot.setSpeaker(new ParlanteConsola());
            unRobot.Comenzar();

            Console.ReadLine();
            unRobot.Detenerse();
            List<object> todosLosEventos = unRobot.MostrarBitacora();
            List<EventoSeguirLinea> eventosFiltrados = unRobot.FiltrarBitacora(DateTime.Now.AddHours(-1), DateTime.Now.AddMinutes(-1));
            eventosFiltrados.ForEach(
                item => Console.WriteLine("Fecha:{0} Sensor1: {1} Sensor2: {2}", item.timeStamp, item.sensor1, item.sensor2)
                );
            Console.ReadLine();
        }
    }
}
