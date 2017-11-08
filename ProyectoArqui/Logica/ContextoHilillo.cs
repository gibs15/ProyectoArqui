using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArqui.Logica
{
    class ContextoHilillo
    {
        //arreglo de registros 0-31
        public int[] Registros = new int[32];

        //proxima instruccion a ejecutar
        public int PC { get; set; }

        //registro de instruccion
        public Utilidades.CodigosInst IR { get; set; }

        //identificador del nucleo donde fue ejecutado
        public int IdNucleo { get; set; }
    }
}
