using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Vistas
{
    public class vehiculo
    {
        public string telefono { get; set; }
        public string modelo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tiempo { get; set; }
        public double precio { get; set; }
        public string patente { get; set; }
        public string tipovehiculo { get; set; }

        public vehiculo(string telefono, string modelo, string nombre, string apellido, string patente, string tipovehiculo)
        {
            this.telefono = telefono;
            this.modelo = modelo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipovehiculo = tipovehiculo;
            this.patente = patente;
        }
    }

}

