using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalesWinForms
{
    internal class LogicaDeNegocio
    {
        private AccesoBD _accesoBd;

        public LogicaDeNegocio()
        {
            _accesoBd = new AccesoBD();
        }
        public Alumnos GuardarAlumno(Alumnos alumno)
        {
            if(alumno.Id == 0)
            {
                _accesoBd.AgregarAlumno(alumno);
            }
            else
            _accesoBd.ActualizarAlumno(alumno);
            return alumno;
        }

        public List<Alumnos> ObtenerListaDeAlumnos()
        {
            return _accesoBd.CargarListaDeAlumnos();
        }
    }
}
