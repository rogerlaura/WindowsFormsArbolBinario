using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsArbolBinario
{
    internal class Arbol
    {
        private Nodo raiz;
        private Nodo aux;
        public Nodo Raiz { set; get; }
        public Nodo Aux { set; get; }

        public Arbol()
        {
            this.Raiz = null;
            this.Aux = null;
        }
        public void Inicar()
        {
            this.Raiz = null;
            this.Aux = null;
        }
        public bool Vacia()
        {
            if (this.Raiz == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void InsertarRaiz(String info)
        {
            if (this.Vacia())
            {
                this.Raiz = new Nodo();
                this.Raiz.Info = info;
                this.Raiz.EI = null;
                this.Raiz.ED = null;
            }
        }
        public void InsertarIzquierdo(Nodo padre, string info)
        {
            Nodo nodo = new Nodo();
            nodo.Info = info;
            nodo.EI = null;
            nodo.ED = null;
            padre.EI = nodo;
        }
        public void InsertarDerecho(Nodo padre, string info)
        {
            Nodo nodo = new Nodo();
            nodo.Info = info;
            nodo.EI = null;
            nodo.ED = null;
            padre.ED = nodo;
        }
        public void PreOrden(Nodo nodo,TextBox text)
        {
            if (nodo != null)
            {
                text.Text+= nodo.Info+" - ";
                //Console.Write(nodo.Info + " ");
                PreOrden(nodo.EI,text);
                PreOrden(nodo.ED,text);
            }
        }
        public void EntreOrden(Nodo nodo, TextBox text)
        {
            if (nodo != null)
            {

                EntreOrden(nodo.EI,text);
                text.Text += nodo.Info + " - ";
                EntreOrden(nodo.ED,text);
            }
        }
        public void PosOrden(Nodo nodo,TextBox text)
        {
            if (nodo != null)
            {

                PosOrden(nodo.EI,text);
                PosOrden(nodo.ED,text);
                text.Text += nodo.Info + " - ";
            }
        }
        public void Buscar(Nodo nodo, String dato)
        {
            if (nodo != null)
            {
                if (nodo.Info == dato)
                {
                    this.Aux = nodo;
                }
                else
                {
                    Buscar(nodo.EI, dato);
                    Buscar(nodo.ED, dato);
                }
            }
        }
    }
}
