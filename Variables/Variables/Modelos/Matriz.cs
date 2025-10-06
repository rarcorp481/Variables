using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Modelos
{
    public class Matriz
    {
        private const int fila = 2, columna = 2;
        private int[,] matrizCuadrada = new int[2, 2];
        public int r {set; get;}
        public int c {set; get;}   

        public void Agregar(int dato)
        {
            if (r == fila) return;
            if (c == columna)
            {
                c = 0; r++;
            }
            matrizCuadrada[r, c] = dato;
            c++;
        }
        public int[,] getMatrizC()
        {
            return this.matrizCuadrada;
        }
    }
}
