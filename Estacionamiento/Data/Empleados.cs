﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estacionamiento.Modelos;
using Estacionamiento.Vistas;

namespace Estacionamiento.Data
{
    public class Empleados
    {
        List<Empleado> Empleadoslist = new List<Empleado>();

        public void Agregar (Empleado aux)
        {

        }
        public bool Existe(string Doc)
        {
            bool exist = false;

            foreach (Empleado aux in Empleadoslist)
            {
                if (aux.Num_Documento == Doc)
                {
                    exist = true;
                    break;
                }
            }
            return exist;
        }
        VER LISTA
    }
}