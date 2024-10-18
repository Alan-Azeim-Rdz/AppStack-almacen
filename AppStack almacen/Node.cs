using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStack_almacen
{
    internal class Node
    {
        public int Datos { get; set; }
        public Node Next { get; set; } // Apunta al siguiente nodo

        public Node(int datos)
        {
            Datos = datos;
            Next = null; // El siguiente nodo inicialmente es null
        }
    }
}
