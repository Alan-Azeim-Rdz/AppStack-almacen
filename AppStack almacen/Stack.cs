﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStack_almacen
{
    internal class Stack
    {
        private Node top;

        public Stack() 
        {
            top = null;
        }

        // Método para insertar un elemento en la pila
        public void Push(Node newNode)
        {
            if (IsEmpty())
            {
                top = newNode;
                return;
            }

            newNode.Next = top;
            top = newNode;
            return ;
        }


        // Método para eliminar y devolver el elemento en el tope de la pila
        public Node Pop()
        {
            if (!IsEmpty())
            {
                Node current = top;
                top = top.Next;
                current.Next = null;
                return current;
            }
            return null;

        }


        // Método para devolver el elemento en el tope de la pila sin eliminarlo
        public Node Peek()
        {
            if (IsEmpty())
            {
                return null;
            }

            return top; 
        }


        // Método para verificar si la pila está vacía
        public bool IsEmpty()
        {
            return top == null;
        }

        public int Size() 
        {
            int count = 0;
            Node current = top;

            // Recorre la pila desde el frente hasta el final
            while (current != null)
            {
                count++;
                current = current.Next; // Avanza al siguiente nodo
            }

            return count; // Devuelve el número total de elementos Size
        }


    }
}
