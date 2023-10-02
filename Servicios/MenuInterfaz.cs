using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entreno.Servicios
{
    /// <summary>
    /// Interfaz con la relacion de metodos de la funcionalidad menu
    /// 270923 - jrp
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra mensaje de bienvenida al entreno.
        /// 270923 - jrp
        /// </summary>

        public void mostrarmensajeBienvenida();
        /// <summary>
        /// Metodo que muestra el menu y recoge la seleccion del usuario
        /// </summary>
        /// <returns>un entero con la opcion seleccionada</returns>
        public int mostrarMenuYSeleccion();



    }
}
