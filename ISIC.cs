using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2D_Ejemplo1_
{
    class ISIC : Alumno
    {
        char seccion;
        //Contructor
        public ISIC() { }

        //segundo constructor
        public ISIC(char seccion, string nombreAlumnoEntrada, string apellidoPrimeroEntrada,
            DateTime fechaIncripcionEntrada, DateTime fechaNacimientoEntrada ) 
            :base(nombreAlumnoEntrada, apellidoPrimeroEntrada,fechaIncripcionEntrada,
                 fechaNacimientoEntrada) {
            this.seccion = seccion;
        }

        public ISIC(string nombreAlumnoEntrada, string apellidoPrimeroEntrada, 
            string apellidoSegundoEntrada,
           DateTime fechaIncripcionEntrada, DateTime fechaNacimientoEntrada)
            :base(nombreAlumnoEntrada,apellidoPrimeroEntrada,apellidoSegundoEntrada,fechaIncripcionEntrada,fechaNacimientoEntrada)
        {
        
        }

        //Sobreescribir
        public override void InformacionDePago()
        {
            base.InformacionDePago();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Seccion: {0}",seccion);
            Console.WriteLine("Parte de codigo modificado");
            Console.WriteLine("Ingeniería en Sistemas Computacionales");
        }

    }
}
