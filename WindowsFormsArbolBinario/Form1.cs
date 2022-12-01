using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsArbolBinario
{
    public partial class Form1 : Form
    {
        Arbol arbol=new Arbol();
        public Form1()
        {
            InitializeComponent();
        }

        private void btncreararbol_Click(object sender, EventArgs e)
        {
            arbol.InsertarRaiz(txtarbol.Text);
        }

        private void btninsertarnodos_Click(object sender, EventArgs e)
        {
            arbol.Buscar(arbol.Raiz, txtpadre.Text);
            if (arbol.Aux == null)
            {
                Console.WriteLine("\tNo existe el padre");
            }
            else
            {
                if (arbol.Aux.EI == null)
                {
                    arbol.InsertarIzquierdo(arbol.Aux, txthijo.Text);

                }
                else
                {
                    if (arbol.Aux.ED == null)
                    {
                        arbol.InsertarDerecho(arbol.Aux, txthijo.Text);
                    }
                    else
                    {
                        MessageBox.Show("\tYA TIENE DOS HIJOS");
                    }
                }
            }
        }

        private void btnpreorden_Click(object sender, EventArgs e)
        {
            txtmotrar.Clear();
            arbol.PreOrden(arbol.Raiz,txtmotrar);
        }

        private void btnentreorden_Click(object sender, EventArgs e)
        {
            txtmotrar.Clear();
            arbol.EntreOrden(arbol.Raiz,txtmotrar);
        }

        private void btnposorden_Click(object sender, EventArgs e)
        {
            txtmotrar.Clear();
            arbol.PosOrden(arbol.Raiz,txtmotrar);
        }
    }
}
