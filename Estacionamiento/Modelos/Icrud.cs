﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento.Vistas
{
    public interface crud <T>
    {
        void agregar(int T);
        void eliminar(int T);
    }
}