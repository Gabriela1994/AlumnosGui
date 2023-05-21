using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
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
        private Alumnos _alumno;
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
            GuardarAlumno();
            this.Close();
            ((Main)this.Owner).VolcarInformacionDeAlumnos();
        }

        private void GuardarAlumno()
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

            alumno.Id = _alumno != null ? _alumno.Id : 0;

            //llamamos al metodo de guardar alumno
            _logicaDeNegocio.GuardarAlumno(alumno);
        }

        internal void CargarInformacionDeAlumno(Alumnos alumno)
        {
            _alumno = alumno;
            if (alumno != null)
            {
                LimpiarFormulario();

                textdni.Text = alumno.Dni;
                textnombre.Text = alumno.Nombre;
                textapellido.Text = alumno.Apellido;
                texfechanac.Text = alumno.Fecha_nacimiento;
                textprovincia.Text = alumno.Provincia;
                textciudad.Text = alumno.Ciudad;
                textcalle.Text = alumno.Calle;
                textnumcalle.Text = alumno.Numero_calle;
            }
        }

        private void LimpiarFormulario()
        {
            textdni.Text = string.Empty;
            textnombre.Text = string.Empty;
            textapellido.Text = string.Empty;
            texfechanac.Text = string.Empty;
            textprovincia.Text = string.Empty;
            textciudad.Text = string.Empty;
            textcalle.Text = string.Empty;
            textnumcalle.Text = string.Empty;
        }
        private void textdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargarAlumnos_Load(object sender, EventArgs e)
        {

        }
    }
}
