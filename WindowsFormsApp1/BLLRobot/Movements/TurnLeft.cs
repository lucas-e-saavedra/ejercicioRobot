using BLLRobot.Componentes;

namespace BLLRobot.Movements
{
    public class GirarIzquierda : Movimiento
    {
        public GirarIzquierda(IMotor izquierdo, IMotor derecho, IParlante unParlante)
        {
            motorIzquierdo = izquierdo;
            motorDerecho = derecho;
            parlante = unParlante;
        }
        public override void Continuar()
        {
            motorIzquierdo.Retroceder();
            motorDerecho.Avanzar();
            parlante.Silenciar();
        }
    }

}