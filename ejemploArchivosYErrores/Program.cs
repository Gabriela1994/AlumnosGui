using ejemploArchivosYErrores;
using System;
using System.IO;



/*
try
{ 
    Console.WriteLine("Inicio del try");
    int numero = int.Parse("dasasdadasd");
    string texto = null;
    int tamaño = texto.Length;
    Console.WriteLine("Fin del try");
}
catch (NullReferenceException e)
{
    Console.WriteLine("hay un error de null");
    //la variable e tiene toda la informacion del error
    Console.WriteLine(e.Message);
    Console.WriteLine(e.StackTrace);
}
catch(Exception e)
{
    Console.WriteLine("Hay un error general " + e.Message);
}
Console.WriteLine("Fin del programa");

if (File.Exists(@"C:\Users\teresita\Documents\Adobe\ejemplo.txt"))

{

    StreamWriter sw = new StreamWriter(@"C:\Users\teresita\Documents\Adobe\ejemplo.txt");
    sw.WriteLine("Cree una linea dentro de este documento");
    sw.Close();
}

//metodo split

string texto = "Hola me llamo claudio y me gusta el sushi";
string[] palabras = texto.Split(' ');
foreach (string palabra in palabras)
{
    Console.WriteLine(palabra);
}

*/

/*
//colocamos la variable afuera para que sea global y usarla dentro del finally
StreamReader sr = null;
try
{
    sr = new StreamReader(@"C:\Users\teresita\Documents\SUELDOEJEMPLO.csv");

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
}
catch (Exception e)
{
    Console.WriteLine("error al leer el archivo" + e.Message);
}
finally
{
    try { sr.Close(); } catch { }
}
*/

/*
//propagar errores
ManejadorDeArchivo manejadordearchivo = new ManejadorDeArchivo();
try
{
manejadordearchivo.LeerDatosCSV(@"C:\Users\teresita\Documents\SUELDOEJEMPLO.csv");
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
Console.ReadKey();
*/


//Forma correcta de hacer para captar el error en todos lados
ManejadorDeArchivo manejadordearchivo = new ManejadorDeArchivo();

StreamReader sr = null;
try
{
    manejadordearchivo.LeerDatosCSV(@"C:\Users\teresita\Documents\SUELDOEJEMPLO.csv");

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
}
catch (Exception e)
{
    Console.WriteLine("error al leer el archivo" + e.Message);
}
