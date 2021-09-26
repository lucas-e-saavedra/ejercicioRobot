using BLLRobot.Componentes;

namespace BLLRobot.Movements
{
    public abstract class Movimiento
    {
        protected IMotor motorIzquierdo;
        protected IMotor motorDerecho;
        protected IParlante parlante;

        public abstract void Continuar();
        public void Detenerse() {
            motorIzquierdo.Frenar();
            motorDerecho.Frenar();
            parlante.Silenciar();
        }
    }

}