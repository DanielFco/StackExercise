using System;
namespace StackExercise
{
    public class Stack
    {
        private Node currentNode;
        private Node node;
        private int maxValue;
        private int flag;
        public int Count = 0;

        public Stack()
        {
            //Se inicia el valor para el encabezado de la pila
            currentNode = new Node();
            //Cómo el stack inica vacío su valor siguiente es null
            currentNode.NextNode = null;
        }

        public void Push(int newItem)
        {
            //Se crea un nodo temporal
            Node temp = new Node();
            temp.Item = newItem;

            //Lo que se hace aquí es agregar el nuevo nodo de manera que siempre quede por encima del nodo anterior
            temp.NextNode = currentNode.NextNode;
            currentNode.NextNode = temp;

            Count++;
        }

        public int Pop()
        {
            //Variable donde se almacenará el valor a extraer
            int value = 0;

            if(currentNode.NextNode != null)
            {
                //Se obtiene el nodo al final de la pila
                node = currentNode.NextNode;
                value = node.Item;

                //Se extrae el nodo del stack
                currentNode.NextNode = node.NextNode;
                node.NextNode = null;
                Count--;
            }

            return value;
        }

        public int Peek()
        {
            //Variable donde se almacena el valor a extraer
            int value = 0;

            if(currentNode.NextNode != null)
            {
                //Se obtiene el nodo al final de la pila
                node = currentNode.NextNode;
                value = node.Item;
            }

            return value;
        }

        public int MaxValue()
        {
            //Se inicializa la bandera para saber la longitud original de la pila
            flag = Count;
            maxValue = 0;
            GetMaxValue();

            return maxValue;
        }

        private void GetMaxValue()
        {
            //Se comprueba que existan valores
            if(Count > 0)
            {
                //Se asigna el valor del último item en la pila y se comprueba si es mayor al anterior
                int value = Pop();
                if (maxValue < value)
                {
                    maxValue = value;
                }

                //Comprueba que aún existan items en la pila y se hace recursión
                if (Count <= flag)
                {
                    GetMaxValue();
                    //Al terminar la recursión se regresa la pila a sus valores originales
                    Push(value);
                }
            }
        }
    }
}
