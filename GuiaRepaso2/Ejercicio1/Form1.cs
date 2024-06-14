using Ejercicio_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        Controlador ejemplo= new Controlador();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            FormRegistro registro = new FormRegistro();

            if (registro.ShowDialog() == DialogResult.OK)
            {
                string nombre = registro.tbnombre.Text;
                int dni = Convert.ToInt32(registro.tbdni.Text);
                double nota = Convert.ToDouble(registro.tbnota.Text);
                ejemplo.AgregarAlumno(nombre, dni, nota);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbpromedio_Click(object sender, EventArgs e)
        {

        }

        private void btpromedio_Click(object sender, EventArgs e)
        {
            ejemplo.CalcularPromedio();
            lbpromedio.Text = Convert.ToString(ejemplo.CalcularPromedio());            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVer formVer = new FormVer();
            ejemplo.AlumnosQueSuperanAlPromedio();
            for (int i = 0; i<ejemplo.Contadorprom; i++)
            {
                string nombre = ejemplo.Nombresprom[i];
                int dni = ejemplo.DNIsprom[i];
                double nota = ejemplo.Notasprom[i];

                formVer.LbxResultados.Items.Add($"{nombre} - {dni} - {nota}");
            }
            formVer.ShowDialog();
        }
    }
}
