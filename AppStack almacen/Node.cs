using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStack_almacen
{
    internal class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; } // Apunta al siguiente nodo

        public Node()
        {
            Data = 0;
            Next = null; // El siguiente nodo inicialmente es null
        }

        public Node(int data)
        {
            Data = data;
            Next = null; // El siguiente nodo inicialmente es null
        }

        public override string ToString() 
        {
            return Data.ToString();
        }
    }
}
