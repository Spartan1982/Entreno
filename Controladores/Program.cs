using Entreno.Servicios;

namespace Entreno.Controladres
{
   /// <sumary>
   /// Clase principal de la aplicacion
   /// 270923 - jrp
   /// </sumary>
   
    class Program
    {
        /// <summary>
        /// Metodo de entrada de la aplicacion
        /// 270923 - jrp
        /// </summary>
        /// <param name="args"></param>
        
        static void Main(string[] args)
        {
            MenuInterfaz up = new MenuImplementacion();
            up.mostrarmensajeBienvenida();

            //variable que controla la entrada del bucle while
            bool cerrarMenu = false;
            //opcion elegida por el usuario
            int opcionSeleccionada;

            //debe cumplirse la condicion
            while (!cerrarMenu)
            {
                opcionSeleccionada = up.mostrarMenuYSeleccion();

                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO]- se ejecuta caso 0");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO]- se ejecuta caso 1");
                        break;

                    case 2:
                        Console.WriteLine("[INFO]- se ejecuta caso 2");
                        break;
                }
            }
        }
    }
    

   

}




