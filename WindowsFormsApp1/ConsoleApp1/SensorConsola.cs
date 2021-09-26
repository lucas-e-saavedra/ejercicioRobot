using BLLRobot.Componentes;
using System;
using System.Configuration;
using System.Reflection;
using System.Timers;

namespace ConsoleApp1
{
    class SensorConsola : ISensor
    {
        public string nombre { get; private set; }
        private bool ultimoValor;
        private ISensorObserver observer;
        Timer timer;
        public SensorConsola(string unNombre) {
            timer = new Timer();
            this.nombre = unNombre;
            var appSettings = ConfigurationManager.OpenExeConfiguration(Assembly.GetEntryAssembly().Location).AppSettings;
            ultimoValor = Boolean.Parse(appSettings.Settings[key: nombre].Value);
        }
        public void Desuscribirse()
        {
            observer = null;
            timer.Stop();
        }

        public bool LeerValor()
        {
            return ultimoValor;
        }

        public void Suscribirse(ISensorObserver sensorObserver)
        {
            observer = sensorObserver;
            timer.Interval = 3000;
            timer.Elapsed += timer_Elapsed;
            timer.Start();

        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var appSettings = ConfigurationManager.OpenExeConfiguration(Assembly.GetEntryAssembly().Location).AppSettings;
            bool nuevoValor = Boolean.Parse(appSettings.Settings[key: nombre].Value);

            if (nuevoValor != ultimoValor)
            {
                ultimoValor = nuevoValor;
                observer.CambioEstadoSensor();
            }
        }
    }
}
