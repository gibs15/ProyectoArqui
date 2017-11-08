using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArqui.Logica
{
    class Nucleo
    {
        public Utilidades.CodigosInst IR { get; set; }
        public int PC { get; set; }
        public int[] Registros { get; set; }
        public int ID = -1;

        public Instruccion[,] CacheInstrucciones = new Instruccion[5, 4];
        public int[,] CacheDatos = new int[6, 4];

        public Nucleo(int id)
        {
            ID = id;
        }
    }
}
