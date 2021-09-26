using BLLRobot.Componentes;

namespace BLLRobot.Movements
{
    class Retroceder : Movimiento
    {
        public Retroceder(IMotor izquierdo, IMotor derecho, IParlante unParlante)
        {
            motorIzquierdo = izquierdo;
            motorDerecho = derecho;
            parlante = unParlante;
        }
        public override void Continuar()
        {
            motorIzquierdo.Retroceder();
            motorDerecho.Retroceder();
            parlante.ReproducirSonido();
        }
    }
}