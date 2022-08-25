using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Modelos
{
    public class Empleado
    {
        public string Nombre { get; set; }  
        public string Apellido { get; set; }
        public long Num_Documento { get; set; }
        public string Nom_Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Preg_Secreta { get; set; }


        public Empleado (string Nombre, string Apellido, long Num_Documento, string Nom_Usuario, string Contraseña, string Preg_Secreta)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Num_Documento = Num_Documento;
            this.Nom_Usuario = Nom_Usuario;
            this.Contraseña = Contraseña;
            this.Preg_Secreta = Preg_Secreta;
        }
            
    }
}
