using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animalesWinForms
{
    public partial class CargarAlumnos : Form
    {
        private LogicaDeNegocio _logicaDeNegocio;
        public CargarAlumnos()
        {
            InitializeComponent();
            _logicaDeNegocio = new LogicaDeNegocio();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Alumnos alumno = new Alumnos();
            alumno.Dni = textdni.Text;
            alumno.Nombre = textnombre.Text;
            alumno.Apellido = textapellido.Text;
            alumno.Fecha_nacimiento = texfechanac.Text;
            alumno.Provincia = textprovincia.Text;
            alumno.Ciudad = textciudad.Text;
            alumno.Calle = textcalle.Text;
            alumno.Numero_calle = textnumcalle.Text;

            _logicaDeNegocio.Save();
        }

        private void textdni_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
