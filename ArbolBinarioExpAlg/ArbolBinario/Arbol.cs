using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Arbol
    {
        /// <summary>
        /// Raiz del arbol
        /// </summary>
        public Nodo raiz { get; private set; }

        /// <summary>
        /// inicio de la lista doblemente enlazada
        /// </summary>
        public Nodo inicio { get; private set; }

        public Stack<Nodo> pila = new Stack<Nodo> { };
        public Queue<Nodo> cola = new Queue<Nodo> { };


        public Arbol()
        {
            raiz = null;
            inicio = null;
            pila.Clear();
            cola.Clear();
        }


        /// <summary>
        /// Agrega el nodo a una lista doblemente enlazada
        /// </summary>
        /// <param name="nuevo">Nodo a agregar</param>
        public void agregar(Nodo nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
                agregar(nuevo, inicio);
        }

        private void agregar(Nodo nuevo, Nodo anterior)
        {
            if (anterior.siguiente == null)
            {
                anterior.siguiente = nuevo;
                nuevo.anterior = anterior;
            }
            else
                agregar(nuevo, anterior.siguiente);
        }

        /// <summary>
        /// Convierte la lista doblemente enlazada a una estructura de tipo arbol
        /// </summary>
        public void hacerArbol()
        {
            Nodo temp = inicio;
            while (temp != null)
            {
                if(temp.dato=='*' || temp.dato == '/')
                {
                    temp.hIzq = temp.anterior;
                    temp.hDer = temp.siguiente;
                    eliminaAnterior(temp);
                    eliminaSiguiente(temp);
                }
                temp = temp.siguiente;
            }
            temp = inicio;
            while (temp != null)
            {
                if(temp.dato=='+' || temp.dato == '-')
                {
                    temp.hIzq = temp.anterior;
                    temp.hDer = temp.siguiente;
                    eliminaAnterior(temp);
                    eliminaSiguiente(temp);
                }
                temp = temp.siguiente;
            }
            raiz = inicio;
        }

        //elimina el nodo anterior
        private void eliminaAnterior(Nodo nodo)
        {
            if (nodo.anterior == inicio)
                inicio = nodo;
            else
            {
                nodo.anterior.anterior.siguiente = nodo;
                nodo.anterior = nodo.anterior.anterior;
            }
        }

        //elimina el nodo siguiente
        private void eliminaSiguiente(Nodo nodo)
        {
            if (nodo.siguiente.siguiente == null)
                nodo.siguiente = null;
            else
            {
                nodo.siguiente.siguiente.anterior = nodo;
                nodo.siguiente = nodo.siguiente.siguiente;
            }
        }

        /// <summary>
        /// Evalua el arbol en modo de PreOrder
        /// </summary>
        /// <returns>Regresa una cadena del arbol en PreOrder</returns>
        public string PreOrder()
        {
            if (raiz == null)
                return "";
            else
                return PreOrder(raiz);
        }

        private string PreOrder(Nodo nodo)
        {
            string res = "";

            res += nodo.ToString();
            pila.Push(nodo);

            if (nodo.hIzq != null)
            {
                res += PreOrder(nodo.hIzq);
            }

            if (nodo.hDer != null)
            {
                res += PreOrder(nodo.hDer);
            }

            return res;
        }

        /// <summary>
        /// Evalua el arbol en modo de PostOrder
        /// </summary>
        /// <returns>Regresa una cadena del arbol en PostOrder</returns>
        public string PostOrder()
        {
            if (raiz == null)
                return "";
            else
                return PostOrder(raiz);
        }

        private string PostOrder(Nodo nodo)
        {
            string res = "";

            if (nodo.hIzq != null)
            {
                res = PostOrder(nodo.hIzq);
            }

            if (nodo.hDer != null)
            {
                res += PostOrder(nodo.hDer);
            }

            res += nodo.ToString();
            cola.Enqueue(nodo);

            return res;
        }
    }
}
