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
        // corrobora que los datos no esten vacios y devolver la carga realizada
        public vehiculo Agregar (string telefono, string modelo, string nombre, string apellido, string patente, string tipovehiculo)
        {
            if (telefono != "" || modelo != "" || nombre != "" || apellido != "" || patente != "" || tipovehiculo !="")
            {
                return null;
            }
            else
            { 
                vehiculo aux = new vehiculo(telefono, modelo, nombre, apellido, patente, tipovehiculo);
                return aux;
            }
        }
    }
}
