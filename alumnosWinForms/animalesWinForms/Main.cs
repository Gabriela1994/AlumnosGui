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
    public partial class Main : Form
    {
        private LogicaDeNegocio _logicaDeNegocio;
        public Main()
        {
            InitializeComponent();
            _logicaDeNegocio = new LogicaDeNegocio();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lo que pasa cuando le dan click a el boton de editar
            DataGridViewCell cell = (DataGridViewLinkCell)gridAnimales.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if(cell.Value.ToString() == "Editar")
            {
                CargarAlumnos cargarAlumno = new CargarAlumnos();
                cargarAlumno.CargarInformacionDeAlumno(new Alumnos
                {
                    Id = int.Parse((gridAnimales.Rows[e.RowIndex].Cells[0].Value.ToString())),
                    Dni = gridAnimales.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Nombre = gridAnimales.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Apellido = gridAnimales.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Fecha_nacimiento = gridAnimales.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    Provincia = gridAnimales.Rows[e.RowIndex].Cells[5].Value.ToString(),
                    Ciudad = gridAnimales.Rows[e.RowIndex].Cells[6].Value.ToString(),
                    Calle = gridAnimales.Rows[e.RowIndex].Cells[7].Value.ToString(),
                    Numero_calle = gridAnimales.Rows[e.RowIndex].Cells[8].Value.ToString(),
                });
                cargarAlumno.ShowDialog(this);
            }
            else if(cell.Value.ToString() == "Eliminar")
            {
                BorrarAlumnos(int.Parse(gridAnimales.Rows[e.RowIndex].Cells[0].Value.ToString()));
                VolcarInformacionDeAlumnos();
            }
        }
        private void BorrarAlumnos(int Id)
        {
            _logicaDeNegocio.BorrarAlumno(Id);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AbrirLosDetallesDeLosAlumnos();
        }
        #region PRIVATE METHODS

        private void AbrirLosDetallesDeLosAlumnos()
        {
            CargarAlumnos alumnos = new CargarAlumnos();
            alumnos.ShowDialog(this);
        }

        #endregion

        private void Main_Load_1(object sender, EventArgs e)
        {
            VolcarInformacionDeAlumnos();
        }

        public void VolcarInformacionDeAlumnos(string buscarText = null)
        {
            //obtiene la informacion
            List<Alumnos> alumnos = _logicaDeNegocio.ObtenerListaDeAlumnos(buscarText);

            //la muestra en la grilla
            gridAnimales.DataSource = alumnos;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            VolcarInformacionDeAlumnos(TxtSearch.Text);
            TxtSearch.Text = string.Empty;
        }
    }
}
