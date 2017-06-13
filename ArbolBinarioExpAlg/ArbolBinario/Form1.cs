using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbolBinario
{
    public partial class Form1 : Form
    {
        Arbol miArbol;
        Nodo miNodo;
        Stack<int> pila = new Stack<int> { };

        public Form1()
        {
            InitializeComponent();
            miArbol = new Arbol();
            pila.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string expresion = txtExpresion.Text;
            for(int i = 0; i < expresion.Length; i++)
            {
                miNodo = new Nodo(expresion[i]);
                miArbol.agregar(miNodo);
            }
            miArbol.hacerArbol();
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            txtPreOrder.Text = miArbol.PreOrder();
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            txtPostOrder.Text = miArbol.PostOrder();
        }

        private void btnResolverPre_Click(object sender, EventArgs e)
        {
            char dato = 'a';
            while (miArbol.pila.Count != 0)
            {
                dato = miArbol.pila.Pop().dato;
                if (dato != '+' && dato != '-' && dato != '*' && dato != '/')
                {
                    pila.Push(int.Parse(dato.ToString()));
                }
                else
                {
                    operacionPre(dato);
                }
            }
            txtResolver.Text = pila.Pop().ToString();
        }

        private void operacionPre(char dato)
        {
            int res = 0;
            int numero1 = pila.Pop();
            int numero2 = pila.Pop();
            switch (dato)
            {
                case '+':
                    res = numero1 + numero2;
                    break;
                case '-':
                    res = numero1 - numero2;
                    break;
                case '*':
                    res = numero1 * numero2;
                    break;
                case '/':
                    res = numero1 / numero2;
                    break;
            }
            pila.Push(res);
        }

        private void btnResolverPost_Click(object sender, EventArgs e)
        {
            while (miArbol.cola.Count != 0)
            {
                char dato = miArbol.cola.Dequeue().dato;
                if (dato != '+' && dato != '-' && dato != '*' && dato != '/')
                {
                    pila.Push(int.Parse(dato.ToString()));
                }
                else
                {
                    operacionPost(dato);
                }
            }
            txtResolver.Text = pila.Pop().ToString();
        }

        private void operacionPost(char dato)
        {
            int res = 0;
            int primero = pila.Pop();
            int segundo = pila.Pop();
            switch (dato)
            {
                case '+':
                    res = segundo + primero;
                    break;
                case '-':
                    res = segundo - primero;
                    break;
                case '*':
                    res = segundo * primero;
                    break;
                case '/':
                    res = segundo / primero;
                    break;
            }
            pila.Push(res);
        }
    }
}
