using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploArchivosYErrores
{
    internal class ManejadorDeArchivo
    {

        public void LeerDatosCSV(string ruta)
        {
            StreamReader sr = null;
            {
                sr = new StreamReader(ruta);

                string linea = sr.ReadLine();

                while (linea != null)
                {
                    linea = sr.ReadLine();
                    Console.WriteLine(linea);
                    string[] datos = linea.Split(';');
                    Console.WriteLine(datos[0] + " " + datos[1]);

                    //otra forma de mostrarlo
                    long id = long.Parse(datos[0]);
                    string nombre = datos[1];
                    string apellido = datos[2];
                    double sueldo = double.Parse(datos[3]);

                    Console.WriteLine(nombre + " " + apellido + " " + sueldo);
                    linea = sr.ReadLine();
                }
                sr.Close();
            }
        }
    }
}
