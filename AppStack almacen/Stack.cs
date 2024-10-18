﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStack_almacen
{
    internal class Stack
    {
        Node top;
        int size;

        public Stack() 
        {
            top = null;
            size = 0;
        }

        // Método para insertar un elemento en la pila
        public void Push(int dato)
        {
            Node newNode = new Node(dato);
            if (IsEmpty())
            {
                top = newNode;
                size++;
            }
            else
            {
                Node current = top;
                newNode.Next = top;
                top = newNode;
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

            int dato = top.Datos;
            top = top.Next;
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

            return top.Datos.ToString();
        }


        // Método para verificar si la pila está vacía
        public bool IsEmpty()
        {
            return top == null;
        }

        public int Size() 
        { 
            return size; 
        }


    }
}
