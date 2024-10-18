using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStack_almacen
{
    internal class Stack
    {
        Node head;
        int size;

        public Stack() 
        {
            head = null;
            size = 0;
        }

        // Método para insertar un elemento en la pila
        public void Push(int dato)
        {
            Node newNode = new Node(dato);
            if (IsEmpty())
            {
                head = newNode;
                size++;
            }
            else
            {
                Node current = head;
                newNode.Next = head;
                head = newNode;
                size++;
            }
        }


        // Método para eliminar y devolver el elemento en el tope de la pila
        public string Pop()
        {
            if (IsEmpty())
            {
                return("La pila está vacía.");
            }

            int dato = head.Datos;
            head = head.Next;
            size--;
            return dato.ToString();
        }


        // Método para devolver el elemento en el tope de la pila sin eliminarlo
        public string Peek()
        {
            if (IsEmpty())
            {
                return("La pila está vacía.");
            }

            return head.Datos.ToString();
        }


        // Método para verificar si la pila está vacía
        public bool IsEmpty()
        {
            return head == null;
        }

        public int Size() 
        { 
            return size; 
        }


    }
}
