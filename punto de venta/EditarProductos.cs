using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace punto_de_venta
{
    public partial class EditarProductos : Form
    {
        DatosProdu DP = new DatosProdu();
        public EditarProductos()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            string tx = CBColumn.Text;
            string tx2 = TBDato.Text;
            string n =  NUDProd.Value + "";
            
            DP.editar(tx,tx2,n);
            this.Close();
        }
        int cc;
        private void TBDato_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (CBColumn.SelectedIndex <= 5 & CBColumn.SelectedIndex >= 4)
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (Char.IsPunctuation(e.KeyChar) & cc == 0)
                    {
                        cc++;
                        e.Handled = false;

                    }
                    else
                    {
                        if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            //el resto de teclas pulsadas se desactivan
                            e.Handled = true;
                        }
                    }

                }
            }
            if (CBColumn.SelectedIndex == 4)
            {
                if (Char.IsDigit(e.KeyChar) | Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
        if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
            }
        }


        private void CBColumn_MouseClick(object sender, MouseEventArgs e)
        {
           TBDato.Text = "";
        }

        private void NUDProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
     if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
    }
    
}
