using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2D_Ejemplo1_
{
    class ILOG : Alumno
    {
        char seccion;
        //Contructor
        public ILOG() { }

        //segundo constructor
        public ILOG(char seccion, string nombreAlumnoEntrada, string apellidoPrimeroEntrada,
            DateTime fechaIncripcionEntrada, DateTime fechaNacimientoEntrada)
            : base(nombreAlumnoEntrada, apellidoPrimeroEntrada, fechaIncripcionEntrada,
                 fechaNacimientoEntrada)
        {
            this.seccion = seccion;
        }

        public ILOG(string nombreAlumnoEntrada, string apellidoPrimeroEntrada,
            string apellidoSegundoEntrada,
           DateTime fechaIncripcionEntrada, DateTime fechaNacimientoEntrada)
            : base(nombreAlumnoEntrada, apellidoPrimeroEntrada, apellidoSegundoEntrada, fechaIncripcionEntrada, fechaNacimientoEntrada)
        {

        }

        //Sobreescribir
        public override void InformacionDePago()
        {
            base.InformacionDePago();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Seccion: {0}", seccion);
            Console.WriteLine("Parte de codigo modificado");
            Console.WriteLine("Ingeniería en Logistica");
        }
    }
}
