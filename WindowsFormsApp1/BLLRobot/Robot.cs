using BLLRobot.Componentes;
using BLLRobot.Movements;
using DALRobot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLRobot
{
    public class Robot: ISensorObserver
    {
        private ISensor sensor1 = null;
        private ISensor sensor2 = null;
        private IParlante oneSpeaker = null;
        private IMotor motor1 = null;
        private IMotor motor2 = null;
        private Movimiento estadoRobot;
        public Robot(){
        }

        public void setSensorIzquierdo(ISensor sensor){
            sensor1 = sensor;
        }
        public void setSensorDerecho(ISensor sensor){
            sensor2 = sensor;
        }

        public void setSpeaker(IParlante speaker){
            oneSpeaker = speaker;
        }

        public void setMotorIzquierdo(IMotor motor)
        {
            motor1 = motor;
        }
        public void setMotorDerecho(IMotor motor)
        {
            motor2 = motor;
        }

        public void CambioEstadoSensor()
        {
            EventoSeguirLinea evento = new EventoSeguirLinea(sensor1.LeerValor(), sensor2.LeerValor());
            BitacoraRobot.Current.Grabar(evento);
            if(sensor1.LeerValor()){
                if (sensor2.LeerValor()) {
                    estadoRobot = new Avanzar(motor1, motor2, oneSpeaker);
                } else {
                    estadoRobot = new GirarIzquierda(motor1, motor2, oneSpeaker);
                }
            } else {
                if (sensor2.LeerValor()) {
                    estadoRobot = new GirarDerecha(motor1, motor2, oneSpeaker);
                } else {
                    estadoRobot = new Retroceder(motor1, motor2, oneSpeaker);
                }
            }
            estadoRobot.Continuar();
        }

        public void Comenzar() {
            estadoRobot = new Avanzar(motor1, motor2, oneSpeaker);
            estadoRobot.Continuar();
            sensor1.Suscribirse(this);
            sensor2.Suscribirse(this);
        }
        public void Detenerse() {
            sensor1.Desuscribirse();
            sensor2.Desuscribirse();
            estadoRobot.Detenerse();
        }

        public List<object> MostrarBitacora() {
            return BitacoraRobot.Current.ListarTodos();
        }
        public List<EventoSeguirLinea> FiltrarBitacora(DateTime desde, DateTime hasta)
        {
            return BitacoraRobot.Current.ListarSegunFiltroFecha<EventoSeguirLinea>("timeStamp", desde, hasta);
        }
    }
}
