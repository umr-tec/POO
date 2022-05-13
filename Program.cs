using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2D_Ejemplo1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipos de dato: string, int, double, float....
            //Tipos de acceso: public, private, portected ...
            //Clases (depende del proyecto): Alumno, Calculadora, Program

            #region OldCode
            // //Instanciar un objeto
            // //tipoDeClase nombreObjeto = new   tipoDeClase();                    

            // // Crear un objeto de clase Alumno
            // Alumno objetoUno = new Alumno("Adrián Pedro","Ortiz", Convert.ToDateTime( "04-04-2022"));//llmar el constructor
            //// objetoUno.NombreAlumno = "Ezequiel";
            // Console.WriteLine("El alumno es: {0}", objetoUno.NombreAlumno);
            // objetoUno.FechaNacimiento = Convert.ToDateTime("07-12-2003");
            // Console.WriteLine(objetoUno.CalcularEdadAlumno1());           
            // Console.WriteLine("\n");
            // //
            // Alumno objetoDos = new Alumno("Yolanda Elizabth","Zapata", DateTime.Now);
            //// objetoDos.NombreAlumno = "Yolanda";
            // Console.WriteLine("El alumno es: {0}", objetoDos.NombreAlumno);
            // Console.WriteLine(objetoDos.CalcularEdadAlumno1());
            // //if (objetoDos.CalcularEdadAlumno()==0)
            // //{
            // //    Console.WriteLine("Edad no asignada");
            // //}
            // //objetoDos.FechaNacimiento = Convert.ToDateTime( "26-09-2003 07:30:21");


            // Console.WriteLine("\n");
            // //Nuevo objeto
            // Alumno objetoTres = new Alumno("Evelin Michel","Chávez", Convert.ToDateTime("03-04-2022"));
            // //objetoTres.NombreAlumno = "Evelin";
            // Console.WriteLine("El alumno es: {0}", objetoTres.NombreAlumno);
            //// objetoTres.FechaNacimiento = Convert.ToDateTime("13-02-1956 07:30:21");
            // Console.WriteLine(objetoTres.CalcularEdadAlumno2(Convert.ToDateTime( "13-02-2002")));
            // Console.WriteLine(objetoTres.FechaNacimiento);
            #endregion          

            // 1. Crear un objeto (intancia)
            Alumno alumno1 = new Alumno("Daniela Ailyn", "Rodriguez", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2003"));
            Alumno alumno2 = new Alumno("Amador", "Rivera", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2002"));
            Alumno alumno3 = new Alumno("Ezequiel", "Sandoval", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2003"));
            Alumno alumno4 = new Alumno("Daniela Ailyn", "Rodriguez", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2001"));
            Alumno alumno5 = new Alumno("Yolanda Elizabeth", "Zapata", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2004"));
            Alumno alumno6 = new Alumno("Sonia", "Huerta", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2002"));
            //
            Alumno alumno7 = new Alumno("Daniela Ailyn", "Rodriguez", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2003"));
            Alumno alumno8 = new Alumno("Amador", "Rivera", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2002"));
            Alumno alumno9 = new Alumno("Ezequiel", "Sandoval", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2003"));
            Alumno alumno10 = new Alumno("Daniela Ailyn", "Rodriguez", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2001"));
            Alumno alumno11 = new Alumno("Yolanda Elizabeth", "Zapata", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2004"));
            Alumno alumno12 = new Alumno("Sonia", "Huerta", Convert.ToDateTime("25-06-2021"), Convert.ToDateTime("25-06-2002"));


            // 2. Mandar llamar algun miembro                     
            //Console.WriteLine(alumno2.CalcularEdadAlumno1());
            //Console.WriteLine(alumno3.CalcularEdadAlumno1());
            //Console.WriteLine(alumno4.CalcularEdadAlumno1());
            //Console.WriteLine(alumno5.CalcularEdadAlumno1());
            //Console.WriteLine(alumno6.CalcularEdadAlumno1());
            //Console.WriteLine(alumno1.CalcularEdadAlumno1());
            //Console.WriteLine(alumno12.CalcularEdadAlumno1());

           

            if (alumno1.CalcularInscripcion(97) == 0)
            {
                Console.WriteLine("Lo sentimos pero su promedio es menor al valor acpetado");
            }
            else
            {
                Console.WriteLine(alumno1.CalcularInscripcion(97));
            }

            //Implementar el metodo Danuela
            Console.WriteLine( alumno2.InformacionDePago(90));

            Console.ReadKey();
        }
    } 
}
