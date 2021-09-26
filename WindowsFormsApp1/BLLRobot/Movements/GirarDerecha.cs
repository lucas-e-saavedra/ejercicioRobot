using BLLRobot.Componentes;

namespace BLLRobot.Movements
{
    class GirarDerecha : Movimiento
    {
        public GirarDerecha(IMotor izquierdo, IMotor derecho, IParlante unParlante)
        {
            motorIzquierdo = izquierdo;
            motorDerecho = derecho;
            parlante = unParlante;
        }
        public override void Continuar()
        {
            motorIzquierdo.Avanzar();
            motorDerecho.Retroceder();
            parlante.Silenciar();
        }
    }

}