using BLLRobot.Componentes;

namespace BLLRobot.Movements
{
    public class Avanzar : Movimiento
    {
        public Avanzar(IMotor izquierdo, IMotor derecho, IParlante unParlante) {
            motorIzquierdo = izquierdo;
            motorDerecho = derecho;
            parlante = unParlante;
        }
        public override void Continuar()
        {
            motorIzquierdo.Avanzar();
            motorDerecho.Avanzar();
            parlante.Silenciar();
        }
    }

}