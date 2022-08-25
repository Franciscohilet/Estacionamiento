using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Modelos;
using Estacionamiento.Vistas;

namespace Estacionamiento.Data
{
    public class Vehiculos
    {
        List<vehiculo> Vehiculoslist = new List<vehiculo>();

        // agregar vehiculos a la lista
        public void Add(vehiculo aux)
        {
            if (!this.Exist(aux.patente))
            {
                Vehiculoslist.Add(aux);
            }
        }

        public bool Exist(string patente)
        {
            bool exist = false;

            foreach (vehiculo aux in Vehiculoslist)
            {
                if (aux.patente == patente)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }

        public void Remove(vehiculo aux)
        {
            Vehiculoslist.Remove(aux);
        }

        public List<vehiculo> VerLista()
        {
            return Vehiculoslist;
        }

        public vehiculo VerVehiculo(string patente)
        {
            foreach (vehiculo vehiculo in Vehiculoslist)
            {
                if (vehiculo.patente == patente)
                {
                    return vehiculo;

                }
            }
            return null;
        }
    }
}
