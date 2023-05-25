using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETOOGenerics
{
    public class MyStack<T>
    {
        public T[] stackArray;
        public int top; 

        public MyStack(int longArray)
        {
            stackArray = new T[longArray];
            top = -1; // Initialise l'indice du sommet de la pile
        }

        public void Push(T item)
        {
            top++; 
            stackArray[top] = item; // Ajoute l'élément au sommet de la pile
        }

        public T Pop()
        {
            T item = stackArray[top]; // Récupère l'élément du sommet de la pile
            top--;  
            return item;  
        }

        public T Peek()
        {
            return stackArray[top]; // Récupère le dernier élément de la pile ajouté
        }
    }
}