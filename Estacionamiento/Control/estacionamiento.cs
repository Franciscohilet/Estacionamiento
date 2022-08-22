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
        public void agregar ()
        {
            vehiculo aux = new vehiculo ();
            this.vehiculos.agregar(aux);
        }

        
      }
}
