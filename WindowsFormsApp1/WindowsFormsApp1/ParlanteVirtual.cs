using BLLRobot.Componentes;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ParlanteVirtual : Label, IParlante
    {
        public ParlanteVirtual() { }

        public void ReproducirSonido()
        {
            this.Text = this.Name + "\nSonando";
        }

        public void Silenciar()
        {
            this.Text = this.Name + "\nSilencio";
        }

    }
}
