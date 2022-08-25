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
        public bool Agregar (string telefono, string modelo, string nombre, string apellido, string patente, string tipovehiculo)
        {
            if (telefono != "" || modelo != "" || nombre != "" || apellido != "" || patente != "" || tipovehiculo !="")
            {
                return false;
            }
            else
            { 
                vehiculo aux = new vehiculo(telefono, modelo, nombre, apellido, patente, tipovehiculo);
                //Vehiculos.add(aux);

                return true;
            }
        }

        //retirar vehiculo de la lista estacionamiento
        public bool Retirar (string patente)
        {
            foreach(var vehiculo in Vehiculos)
            {
                if (vehiculo.patente == patente)
                {
                    //Vehiculos.Remove(aux);
                    break;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
