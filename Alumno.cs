using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2D_Ejemplo1_
{
    class Alumno
    {
        #region Campos
        //Campos (variables)        
        //Variables Daniela
        private int numeroMateriasNoAcreditadas, promedio = 0;
        private string matricula, nombreAlumno = string.Empty, apellidoPrimero, apellidoSegundo, domicilioAlumno, carrera;
        string curpAlumno, nombreInstitucion, contrasenaAlumno, grupoAlumno, nombreMateria;
        DateTime fechaNacimiento, fechaIncripcion;
        double promedioGlobal;

        // Miembro de tipo Constante pi
        const string FECHA_CREACION_INSTITUCION = "01-08-2008", NUMERO_TECNOLOGICO = "100";

        #endregion

        #region Contructores
        // Miembro de tipo Contructor
        /*
            Tipo de acceso  NombreClase (entrada) {}
         */
        public Alumno( string nombreAlumnoEntrada, string apellidoPrimeroEntrada, 
            DateTime fechaIncripcionEntrada, DateTime fechaNacimientoEntrada /*Los valores de entrada*/)
        {  // Explicitas | Implicitas
            nombreAlumno = nombreAlumnoEntrada;
            apellidoPrimero = apellidoPrimeroEntrada;
            fechaIncripcion = fechaIncripcionEntrada;
            fechaNacimiento = fechaNacimientoEntrada;
            //construir la matricula

            if (Folio.numeroFolio >= 1 && Folio.numeroFolio <= 9) {
                matricula = (fechaIncripcion.Year + "" + NUMERO_TECNOLOGICO).Substring(2, 5) + "000" + Folio.numeroFolio;
            }
            if (Folio.numeroFolio >= 10 && Folio.numeroFolio <= 99)
            {
                matricula = (fechaIncripcion.Year + "" + NUMERO_TECNOLOGICO).Substring(2, 5) + "00" + Folio.numeroFolio;
            }
            if (Folio.numeroFolio >= 100 && Folio.numeroFolio <= 999)
            {
                matricula = (fechaIncripcion.Year + "" + NUMERO_TECNOLOGICO).Substring(2, 5) + "0" + Folio.numeroFolio;
            }
            if (Folio.numeroFolio >= 1000 && Folio.numeroFolio <= 9999)
            {
                matricula = (fechaIncripcion.Year + "" + NUMERO_TECNOLOGICO).Substring(2, 5) + "" + Folio.numeroFolio;
            }


            Folio.numeroFolio = Folio.numeroFolio + 1;
        }

        public Alumno(string nombreAlumnoEntrada, string apellidoPrimeroEntrada, string apellidoSegundoEntrada,
           DateTime fechaIncripcionEntrada, DateTime fechaNacimientoEntrada /*Los valores de entrada*/)
        {  // Explicitas | Implicitas
            nombreAlumno = nombreAlumnoEntrada;
            apellidoPrimero = apellidoPrimeroEntrada;
            apellidoSegundo = apellidoSegundoEntrada;
            fechaIncripcion = fechaIncripcionEntrada;
            fechaNacimiento = fechaNacimientoEntrada;
            //construir la matricula

            if (Folio.numeroFolio >= 1 && Folio.numeroFolio <= 9)
            {
                matricula = (fechaIncripcion.Year + "" + NUMERO_TECNOLOGICO).Substring(2, 5) + "000" + Folio.numeroFolio;
            }
            if (Folio.numeroFolio >= 10 && Folio.numeroFolio <= 99)
            {
                matricula = (fechaIncripcion.Year + "" + NUMERO_TECNOLOGICO).Substring(2, 5) + "00" + Folio.numeroFolio;
            }
            if (Folio.numeroFolio >= 100 && Folio.numeroFolio <= 999)
            {
                matricula = (fechaIncripcion.Year + "" + NUMERO_TECNOLOGICO).Substring(2, 5) + "0" + Folio.numeroFolio;
            }
            if (Folio.numeroFolio >= 1000 && Folio.numeroFolio <= 9999)
            {
                matricula = (fechaIncripcion.Year + "" + NUMERO_TECNOLOGICO).Substring(2, 5) + "" + Folio.numeroFolio;
            }


            Folio.numeroFolio = Folio.numeroFolio + 1;
        }

        public Alumno() { }

        #endregion

        #region Propiedades
        // Miembros de tipo Propiedad (proteger algun campo)
        public string NombreAlumno
        {
            get
            {
                if (nombreAlumno != string.Empty)
                {
                    return nombreAlumno;
                }
                else
                {
                    return "No se asigno nombre al objeto";
                }
                 } //get: Leer el contenido de una variable

            //Guardar contenido en una variable
        }

        //Propiedad para la variable fechaNAcimineto
        public DateTime FechaNacimiento {           
            set { fechaNacimiento = value; }
            get { return fechaNacimiento; }
        }

        #endregion

        #region Métodos

        //Mimebro de tipo metodo
        // Tipo acceso Tipo de dato Nombre metodo (entrada){}
        //Tipo acceso: public - private
        //Tipo de dato: int, float, string, char, double...
        public int CalcularEdadAlumno() {
            //Calcular la edad
            int edad;
            //Validar que la fecha de nacimiento se haya asignado por parte del usuario
            if (fechaNacimiento.Year < 1000) {
                edad = 0;
            }
            else
            {
                edad = ((DateTime.Now - fechaNacimiento).Days) / 365;
            }           
            return edad;
        }

        //Miembro de tipo metodo
        //Tipo de acceso Tipo de Dato Nombre del metodo (dominio | entradas){}
        //Tipos de dato: int, string, float, double, byte, short
        //Tipo de acceso: public | private | proyected | internal
        public string CalcularEdadAlumno1() {            
            int edad;
            string valorDeRetorno;
            //Validar que la fecha de nacimiento se haya asignado por parte del usuario
            if (fechaNacimiento.Year < 1960)
            {
                valorDeRetorno = string.Format("La edad no ha sido asignada, " +
                    "por favor asigna la edad al alumno: {0} {1}", nombreAlumno, apellidoPrimero);
            }
            else
            {
                edad = ((DateTime.Now - fechaNacimiento).Days) / 365;
                valorDeRetorno = string.Format("El alumno con matricula: {3}  {0} {2}. " +
                    "Tiene la edad de: {1} años", nombreAlumno, edad, apellidoPrimero,matricula);
            }   
            return valorDeRetorno;
        }

        //Metodo con valores de entrada (dominio)
        public string CalcularEdadAlumno(DateTime fechaNacimientoEntrada)
        {
            int edad;
            string valorDeRetorno;
            fechaNacimiento = fechaNacimientoEntrada;
            //Validar que la fecha de nacimiento se haya asignado por parte del usuario
            if (fechaNacimientoEntrada.Year < 1960)
            {
                valorDeRetorno = string.Format("La edad no ha sido asignada, " +
                    "por favor asigna la edad al alumno: {0}", nombreAlumno);
            }
            else
            {
                edad = ((DateTime.Now - fechaNacimientoEntrada).Days) / 365;
                valorDeRetorno = string.Format("El alumno: {0}. " +
                    "Tiene la edad de: {1} años", nombreAlumno, edad);
            }
            return valorDeRetorno;
        }

        public double CalcularInscripcion(double promedio) {

            double valorDeRetorno = 0;//97
            if (promedio > 100)
            {
                valorDeRetorno = 0;
            }
            else
            {

                if (promedio >= 95 && promedio <= 100)
                {
                    valorDeRetorno = 2700 - 2000;
                    //  return;
                }
                if (promedio >= 80 && promedio <= 94)
                {
                    valorDeRetorno = 2700 - 1000;
                }
                if (promedio >= 70 && promedio <= 79)
                {
                    valorDeRetorno = 2700;
                }
                if (promedio < 70)
                {
                    valorDeRetorno = 0;
                }
            }            
            return valorDeRetorno;
        }

        //Metodo DAniela
        public double CalcularInscripcion1(double promedio)
        {
            promedioGlobal = promedio;
            double valorDeRetorno = 0;//97
            if (promedio > 100)
            {
                valorDeRetorno = 0;
            }
            else
            {

                if (promedio >= 95 && promedio <= 100)
                {
                    valorDeRetorno = 2700 - 2000;
                    //  return;
                }
                if (promedio >= 80 && promedio <= 94)
                {
                    valorDeRetorno = 2700 - 1000;
                }
                if (promedio >= 70 && promedio <= 79)
                {
                    valorDeRetorno = 2700;
                }
                if (promedio < 70)
                {
                    Console.WriteLine("Promedio no admitido");
                    valorDeRetorno = 0;
                    
                }
            }
            return valorDeRetorno;
        }

        public double CalcularInscripcionAlfonso(double promedio)
        {

            double valorDeRetorno = 0;//97

            if (promedio < 70)
            {
                Console.WriteLine("Promedio no admitido");
                valorDeRetorno = 0;
            }
            if (promedio > 100)
            {
                valorDeRetorno = 0;
            }
            else
            {

                if (promedio >= 95 && promedio <= 100)
                {
                    valorDeRetorno = 2700 - 2000;
                    //  return;
                }
                if (promedio >= 80 && promedio <= 94)
                {
                    valorDeRetorno = 2700 - 1000;
                }
                if (promedio >= 70 && promedio <= 79)
                {
                    valorDeRetorno = 2700;
                }
                if (promedio < 70)
                {
                    Console.WriteLine("Promedio no admitido");
                    valorDeRetorno = 0;

                }
            }
            return valorDeRetorno;
        }

        //Metodo para mostrar informacion de pago 
        public string InformacionDePago(int promedio) {

            string valorDeRetorno;
            // valorDeRetorno = "Matricula:" +" "+ matricula + " \n " + "Alumno: " +" "+   nombreAlumno +" "+ apellidoPrimero;

            if (promedio >= 80)
            {
                valorDeRetorno = string.Format("Matricula: {0} \n Alumno: {1} {2}. \n" +
                "Total a pagar: ${3} \n Descuento: SI",
                matricula, nombreAlumno, apellidoPrimero, CalcularInscripcion1(promedio));
            }
            else
            {
                valorDeRetorno = string.Format("Matricula: {0} \n Alumno: {1} {2}. \n" +
               "Total a pagar: ${3} \n Descuento: NO",
               matricula, nombreAlumno, apellidoPrimero, CalcularInscripcion1(promedio));
            }

            return valorDeRetorno;
        }

        //InformacionDePago llamado nuevamente
        //public string InformacionDePago()
        //{
        //    //Codigo ALfonso, Daniela, Eduardo mas los que se acomulen
        //   // int promedio;
        //    string valorDeRetorno;
        //    // valorDeRetorno = "Matricula:" +" "+ matricula + " \n " + "Alumno: " +" "+   nombreAlumno +" "+ apellidoPrimero;

        //    //Codigo ALfonso, Daniela, Eduardo mas los que se acomulen
        //    //Console.WriteLine("Ingresa tu promedio");
        //    //promedio = int.Parse(Console.ReadLine());

        //    if (promedioGlobal >= 80)
        //    {
        //        valorDeRetorno = string.Format("Matricula: {0} \n Alumno: {1} {2}. \n" +
        //        "Total a pagar: ${3} \n Descuento: SI",
        //        matricula, nombreAlumno, apellidoPrimero, promedioGlobal);
        //    }
        //    else
        //    {
        //        valorDeRetorno = string.Format("Matricula: {0} \n Alumno: {1} {2}. \n" +
        //       "Total a pagar: ${3} \n Descuento: NO",
        //       matricula, nombreAlumno, apellidoPrimero, promedioGlobal);
        //    }

        //    return valorDeRetorno;
        //}

        public virtual void InformacionDePago()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            //Codigo ALfonso, Daniela, Eduardo mas los que se acomulen
            // int promedio;
            string valorDeRetorno;
            // valorDeRetorno = "Matricula:" +" "+ matricula + " \n " + "Alumno: " +" "+   nombreAlumno +" "+ apellidoPrimero;

            //Codigo ALfonso, Daniela, Eduardo mas los que se acomulen
            //Console.WriteLine("Ingresa tu promedio");
            //promedio = int.Parse(Console.ReadLine());

            if (promedioGlobal == 0)
            {
                Console.WriteLine("Ingresa el pormedio del alumno: \n");
                promedioGlobal = int.Parse(Console.ReadLine());

                

                valorDeRetorno = string.Format("Matricula: {0} \n Alumno: {1} {2}. \n" +
               "Total a pagar: ${3} \n Descuento: SI",
               matricula, nombreAlumno, apellidoPrimero, CalcularInscripcion1(promedioGlobal));
            }
            else
            {
                if (promedioGlobal >= 80)
                {
                    valorDeRetorno = string.Format("Matricula: {0} \n Alumno: {1} {2}. \n" +
                    "Total a pagar: ${3} \n Descuento: SI",
                    matricula, nombreAlumno, apellidoPrimero, promedioGlobal);
                }
                else
                {
                    valorDeRetorno = string.Format("Matricula: {0} \n Alumno: {1} {2}. \n" +
                   "Total a pagar: ${3} \n Descuento: NO",
                   matricula, nombreAlumno, apellidoPrimero, promedioGlobal);
                }
            }
            
            Console.WriteLine(valorDeRetorno);
        }


        //Metodo para calcular el proemdio de una materia
        public void CalcularPromedio() {          
            //declaramos un areeglo
            int[] calificaciones = new int[3];
            
            Console.WriteLine("Opción para calcular el promedio de una asignatura;");
            Console.WriteLine("Ingresa la materia en la que vas a ingresar las calificaciones");
            nombreMateria = Console.ReadLine();

            for (int i = 0; i <= 2 ; i++)
            {
                Console.WriteLine("Ingresa la calificcion de la unidad número {0}",i+1);
                calificaciones[i] = Convert.ToInt32(Console.ReadLine());
            }
            //for para leer el arreglo
            //for (int i = 0; i <= 2 ; i++)
            //{
            //    promedio += calificaciones[i];
            //}

            //foreach para leer el arreglo
            foreach (int lectura in calificaciones)
            {
                promedio += lectura;
            }


            //promedio = calificaciones[0];
            //promedio = promedio + calificaciones[1];
            //promedio = promedio + calificaciones[2];
            //promedio = promedio / 3;

            Console.WriteLine("Detalles de promedio");
            Console.WriteLine("\n Materia evaluada: {0}. \n Alumno: {1}. \n Promedio alcanzado: {2}", nombreMateria, nombreAlumno, promedio/3);

        }


        #endregion
    }
}
