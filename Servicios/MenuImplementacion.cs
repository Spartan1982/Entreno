using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entreno.Servicios
{
    internal class MenuImplementacion: MenuInterfaz
    {
        public void mostrarmensajeBienvenida()
        {

            string mensaje = "Entreno";
            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("#########################");
            Console.WriteLine("0. Cerrar aplicacion");
            Console.WriteLine("1. Darse de alta");
            Console.WriteLine("2. Ingresar dinero");           
            Console.WriteLine("############################");
            Console.WriteLine("Seleccione una opcion:");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;


        }
    }
}
