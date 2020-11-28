﻿using InterfaceClass.InterfaceClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass.Clases
{
    public class FiltroCodigo : IFiltro
    {
        public bool FiltrarPor(Estudiante estudiante, string parametroFiltrar)
        {
            return estudiante.CodigoEstudiante.Contains(parametroFiltrar);
        }

        public override string ToString()
        {
            return string.Format("Filtrar por codigo");
        }
    }
}
