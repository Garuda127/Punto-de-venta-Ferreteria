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
            DatosProdu DP = new DatosProdu();
            MessageBoxButtons BTN = MessageBoxButtons.OK;
            String name = texnombre.Text;
            String marc = texMarca.Text;
            double prec = Double.Parse(texprecio.Text);
            String desc = Texarea.Text;
            int stoc = (int)Numst.Value;
            Double cos;
            Boolean tf;
            if (!name.Equals(""))
            {
                if (!marc.Equals(""))
                {
                    if (!prec.Equals(""))
                    {
                        cos = Convert.ToDouble(prec);

                        if (!desc.Equals(""))
                        {
                            if (!stoc.Equals(""))
                            {
                                tf = true;
                            }
                            else
                            {
                                tf = false;
                                MessageBox.Show("Ingresa un valor entero en Stock", "Erro al ingresar los datos", BTN);
                            }
                        }
                        else
                        {
                            tf = false;
                            MessageBox.Show("Ingresa un valor valido en el espacio de la Descripción", "Erro al ingresar los datos", BTN);
                        }
                    }
                    else
                    {
                        tf = false;
                        MessageBox.Show("Ingresa un valor decimal o entero en el espacio de Precio", "Erro al ingresar los datos", BTN);
                    }
                }
                else
                {
                    tf = false;
                    MessageBox.Show("Ingresa un valor valido en el espacio de Marca", "Erro al ingresar los datos", BTN);
                }
            }
            else
            {
                tf = false;
                MessageBox.Show("Ingresa un valor valido en el espacio de nombre", "Erro al ingresar los datos", BTN);
            }
            if (tf)

            {
                DP.Reg(name,marc,prec,desc,stoc);

                MessageBox.Show("Los datos se han agregado a la base de datos", "Correcto", BTN);
            }
        }
    }
    
}
