using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2D_Ejemplo1_
{
    class Alumno
    {
        //Campos (variables)        
        //Variables Daniela
        private int numeroMateriasNoAcreditadas;
        private string matricula, nombreAlumno = string.Empty, apellidoPrimero, apellidoSegundo, domicilioAlumno, carrera;
        string curpAlumno, nombreInstitucion, contrasenaAlumno, grupoAlumno;
        DateTime fechaNacimiento, fechaIncripcion;

        // Miembro de tipo Constante pi
        const string FECHA_CREACION_INSTITUCION = "01-08-2008", NUMERO_TECNOLOGICO = "100";

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
        public string CalcularEdadAlumno2(DateTime fechaNacimientoEntrada)
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
                if (promedio <= 79)
                {
                    valorDeRetorno = 2700;
                }
            }            
            return valorDeRetorno;
        }

    }
}
