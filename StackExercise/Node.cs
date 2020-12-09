using System;
namespace StackExercise
{
    public class Node
    {
        //Colocamos el dato a guardar en el nodo
        private int item;

        //Variable de referencia para apuntar al siguiente nodo
        private Node nextNode = null;

        //Para utlizar las propiedades item y nodo
        internal int Item
        {
            get { return item; }
            set { item = value; }
        }

        internal Node NextNode
        {
            get { return nextNode; }
            set { nextNode = value; }
        }
    }
}
