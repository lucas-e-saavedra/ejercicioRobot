using BLLRobot.Componentes;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class MotorVirtual : Label, IMotor
    {
        public MotorVirtual() { }

        public void Avanzar()
        {
            Text = Name + "\nAvanzando";
        }

        public void Frenar()
        {
            Text = Name + "\nFrenado";
        }

        public void Retroceder()
        {
            Text = Name + "\nRetrocediendo";
        }

    }
}
