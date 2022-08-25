using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Vistas
{
    public class estacionamiento
    {
        //Vehiculos vehiculos = new Vehiculos();
        // corrobora que los datos no esten vacios
        public vehiculo corroborardatos (string telefono, string modelo, string nombre, string apellido, string patente, string tipovehiculo)
        {
            if (telefono != ""; modelo != ""; nombre != ""; apellido != ""; patente != ""; tipovehiculo!="")
            {
                vehiculo aux = vehiculo ()
                return ;
            }
            else
            { return false; }
        }
    }
}
