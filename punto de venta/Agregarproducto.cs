using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using DataAccess;

namespace punto_de_venta
{
    public partial class AgregarProducto : Form
    {
       
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            String val = "";
            DatosProdu DP = new DatosProdu();
            MessageBoxButtons BTN = MessageBoxButtons.OK;
            String name = texnombre.Text;
            String marc = texMarca.Text;
            double prec = Double.Parse(texprecio.Text);
            String desc = Texarea.Text;
            int stoc = (int)Numst.Value;
            int CBCat = CBCatego.SelectedIndex+1;
            int cb = 0;
            Boolean tf;
            if (!name.Equals(""))
            {
                cb++;
                tf = true;
            }
            else
            {
                 tf = false;
                 val += "Ingresa un valor valido en el espacio de Nombre \n";
            }
            
            if (!marc.Equals("")) {
                cb++;
                tf = true;
        }
            else
            {
                 tf = false;
                 val += "Ingresa un valor valido en el espacio de Marca \n";
            }    
            if (!prec.Equals(""))
            {
                cb++;
                tf = true;
            }
            else
            {
                tf = false;
                val += "Ingresa un valor valido en el espacio de Precio \n";
            }
            

            if (!desc.Equals(""))
            {
                cb++;
                tf = true;
            }
            else
            {
                tf = false;
                val += "Ingresa un valor valido en el espacio de Descripción \n";
            }

            if (!stoc.Equals(""))
            {
                cb++;
                tf = true;
            }
            else
            {
                tf = false;
                val += "Ingresa un valor valido en el espacio de Stock \n";
            }
            
            if (!CBCat.Equals(""))
            {
                cb++;
                tf = true;
                }
            else
                {
                    tf = false;
                    val += "Ingresa un valor valido en el espacio de Categoria \n";
                }
  
      
            if (tf & cb==6)

            {
                DP.Reg(name,marc, CBCat, prec,desc,stoc);

                MessageBox.Show("Los datos se han agregado a la base de datos", "Correcto", BTN);
                this.Close();

            }
            else
            {
                MessageBox.Show("Faltan los siguientes datos \n" + val, "Error", BTN);
            }
        }

        private void texprecio_TextChanged(object sender, EventArgs e)
        {
            
        }
        int cc;
        private void texprecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Numst_KeyPress(object sender, KeyPressEventArgs e)
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
