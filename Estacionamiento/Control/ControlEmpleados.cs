using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Data;
using Estacionamiento.Modelos;


namespace Estacionamiento.Control
{
    public class ControlEmpleados
    {
        Empleados empleados;
        public bool Existe(string Doc)
        {
            bool exist = false;

            foreach (Empleado aux in empleados.VerLista())
            {
                if (aux.Num_Documento == Doc)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }

        public bool Agregar (Empleado aux)
        {
            if(!Existe(aux.Num_Documento))
            {
                empleados.Agregar(aux);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
