using BLLRobot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Robot unRobot;
        private void Form1_Load(object sender, EventArgs e)
        {
            unRobot = new Robot();
            unRobot.setSensorIzquierdo(chkLeft);
            unRobot.setSensorDerecho(chkRight);
            unRobot.setMotorIzquierdo(lblLeft);
            unRobot.setMotorDerecho(lblRight);
            unRobot.setSpeaker(lblSpeaker);
            unRobot.Comenzar();
            
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            List<object> todosLosEventos = unRobot.MostrarBitacora();
            List<EventoSeguirLinea> eventosFiltrados = unRobot.FiltrarBitacora(DateTime.Now.AddHours(-1), DateTime.Now.AddMinutes(-1));
            this.dataGridView1.DataSource = eventosFiltrados;
        }
    }
}
