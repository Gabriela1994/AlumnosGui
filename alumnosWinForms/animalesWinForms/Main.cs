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
        public Main()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirLosDetallesDeLosAlumnos();
        }
        #region PRIVATE METHODS

        private void AbrirLosDetallesDeLosAlumnos()
        {
            CargarAlumnos alumnos = new CargarAlumnos();
            alumnos.ShowDialog();
        }

        #endregion
    }
}
