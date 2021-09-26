using BLLRobot.Componentes;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class SensorVirtual : CheckBox, ISensor
    {
        private ISensorObserver observer;

        public SensorVirtual() { }
        private void this_CheckedChanged(object sender, EventArgs e)
        {
            observer.CambioEstadoSensor();
        }
        public void Suscribirse(ISensorObserver sensorObserver)
        {
            observer = sensorObserver;
            this.CheckedChanged += new System.EventHandler(this.this_CheckedChanged);
        }
        public void Desuscribirse()
        {
            this.CheckedChanged -= new System.EventHandler(this.this_CheckedChanged);
            observer = null;
        }
        public bool LeerValor()
        {
            return Checked;
        }
    }
}
