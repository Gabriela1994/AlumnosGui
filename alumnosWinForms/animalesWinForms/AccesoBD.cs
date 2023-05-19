using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalesWinForms
{
    internal class AccesoBD
    {
        private SqlConnection conexion = new SqlConnection(";Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BdMatricula;Data Source=GabrielaPC");
        public void AgregarAlumno(Alumnos alumno)
        {
            try
            {
                conexion.Open();
                string query = @"

                                ";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
