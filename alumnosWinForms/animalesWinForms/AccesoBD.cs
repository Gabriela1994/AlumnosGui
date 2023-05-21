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
        private SqlConnection conexion = new SqlConnection(";Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BdMatricula;Data Source=localhost");
        public void AgregarAlumno(Alumnos alumno)
        {
            try
            {
                conexion.Open();
                string query = @"
                                    INSERT INTO Persona ([nombre], [apellido], [dni], [fecha_nac], [provincia], [ciudad], [calle], [numero_calle])
                                    VALUES (@Nombre, @Apellido, @Dni, @Fecha_nacimiento, @Provincia, @Ciudad, @Calle, @Numero_calle)";

                SqlParameter nombre = new SqlParameter("@Nombre", alumno.Nombre);
                SqlParameter apellido = new SqlParameter("@Apellido", alumno.Apellido);
                SqlParameter dni = new SqlParameter("@Dni", alumno.Dni);
                //SqlParameter fecha_nacimiento = new SqlParameter("@Fecha_nacimiento", alumno.Fecha_nacimiento);
                SqlParameter provincia = new SqlParameter("@Provincia", alumno.Provincia);
                SqlParameter ciudad = new SqlParameter("@Ciudad", alumno.Ciudad);
                SqlParameter calle = new SqlParameter("@Calle", alumno.Calle);
                SqlParameter numero_calle = new SqlParameter("@Numero_Calle", alumno.Numero_calle);

                //segunda forma de colocar parametros
                SqlParameter fecha_nacimiento = new SqlParameter();
                fecha_nacimiento.ParameterName = "@Fecha_nacimiento";
                fecha_nacimiento.Value = alumno.Fecha_nacimiento;
                fecha_nacimiento.DbType = System.Data.DbType.String;
                
                //los parametros los inserto en una lista dinamica
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.Add(nombre);
                command.Parameters.Add(apellido);
                command.Parameters.Add(dni);
                command.Parameters.Add(fecha_nacimiento);
                command.Parameters.Add(provincia);
                command.Parameters.Add(ciudad);
                command.Parameters.Add(calle);
                command.Parameters.Add(numero_calle);

                //y ejecutamos la consulta (existen varios tipos)
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<Alumnos> CargarListaDeAlumnos()
        {
            //una lista vacia que va a contener toda la informacion de los alumnos de la base de datos
            List<Alumnos> listaAlumnos = new List<Alumnos>();
            try
            {
                conexion.Open();
                string query = @" SELECT id, nombre, apellido, dni, fecha_nac, provincia, ciudad, calle, numero_calle FROM Persona";
                SqlCommand command = new SqlCommand(query, conexion);
                //contiene todas las lineas de los registros existentes
                SqlDataReader reader = command.ExecuteReader();
                //itera leyendo cada linea
                while (reader.Read())
                {
                    listaAlumnos.Add(new Alumnos
                    {
                        Id = int.Parse(reader["id"].ToString()),
                        Nombre = reader["nombre"].ToString(),
                        Apellido = reader["apellido"].ToString(),
                        Dni = reader["dni"].ToString(),
                        Fecha_nacimiento = reader["fecha_nac"].ToString(),
                        Provincia = reader["provincia"].ToString(),
                        Ciudad = reader["ciudad"].ToString(),
                        Calle = reader["calle"].ToString(),
                        Numero_calle = reader["numero_calle"].ToString(),
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
            return listaAlumnos;
        }

        public void ActualizarAlumno(Alumnos alumno)
        {
            try
            {
                conexion.Open();

                string query = @"
                                    UPDATE Persona SET 
                                    nombre = @Nombre
                                    apellido = @Apellido
                                    dni = @Dni
                                    fecha_nac = @Fecha_nacimiento
                                    provincia = @Provincia  
                                    ciudad = @Ciudad
                                    calle = @Calle
                                    numero_calle = @Numero_calle
                                    WHERE id = @Id
                                    ";

                SqlParameter id = new SqlParameter("@Id", alumno.Id);
                SqlParameter nombre = new SqlParameter("@Nombre", alumno.Nombre);
                SqlParameter apellido = new SqlParameter("@Apellido", alumno.Apellido);
                SqlParameter dni = new SqlParameter("@Dni", alumno.Dni);
                SqlParameter fecha_nacimiento = new SqlParameter("@Fecha_nacimiento", alumno.Fecha_nacimiento);
                SqlParameter provincia = new SqlParameter("@Provincia", alumno.Provincia);
                SqlParameter ciudad = new SqlParameter("@Ciudad", alumno.Ciudad);
                SqlParameter calle = new SqlParameter("@Calle", alumno.Calle);
                SqlParameter numero_calle = new SqlParameter("@Numero_Calle", alumno.Numero_calle);


                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.Add(nombre);
                command.Parameters.Add(apellido);
                command.Parameters.Add(dni);
                command.Parameters.Add(fecha_nacimiento);
                command.Parameters.Add(provincia);
                command.Parameters.Add(ciudad);
                command.Parameters.Add(calle);
                command.Parameters.Add(numero_calle);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
