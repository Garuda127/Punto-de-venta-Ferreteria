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
            string CBCat = CBCatego.Text;
            
            int cb = 0;
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
                                if (!CBCat.Equals(""))
                                {
                                    if (CBCat.Equals("Herramientas"))
                                    {
                                        tf = true;
                                        cb = 1;
                                    }
                                    else
                                    {
                                        if (CBCat.Equals("Material electrico"))
                                        {
                                            tf = true;
                                            cb = 2;
                                        }
                                        else
                                        {
                                            if (CBCat.Equals("Material para plomeria"))
                                            {
                                                tf = true;
                                                cb = 3;
                                            }
                                            else
                                            {
                                                if (CBCat.Equals("Hogar"))
                                                {
                                                    tf = true;
                                                    cb = 4;
                                                }
                                                else
                                                {
                                                    if (CBCat.Equals("Jardin"))
                                                    {
                                                        tf = true;
                                                        cb = 5;
                                                    }
                                                    else
                                                    {
                                                        if (CBCat.Equals("Proteccion"))
                                                        {
                                                            tf = true;
                                                            cb = 6;
                                                        }
                                                        else
                                                        {
                                                            tf = false;
                                                            MessageBox.Show("Ingresa una categoria valida", "Error al ingresar los datos", BTN);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                tf = false;
                                MessageBox.Show("Ingresa un valor entero en Stock", "Error al ingresar los datos", BTN);
                            }
                        }
                        else
                        {
                            tf = false;
                            MessageBox.Show("Ingresa un valor valido en el espacio de la Descripción", "Error al ingresar los datos", BTN);
                        }
                    }
                    else
                    {
                        tf = false;
                        MessageBox.Show("Ingresa un valor decimal o entero en el espacio de Precio", "Error al ingresar los datos", BTN);
                    }
                }
                else
                {
                    tf = false;
                    MessageBox.Show("Ingresa un valor valido en el espacio de Marca", "Error al ingresar los datos", BTN);
                }
            }
            else
            {
                tf = false;
                MessageBox.Show("Ingresa un valor valido en el espacio de nombre", "Error al ingresar los datos", BTN);
            }
            if (tf)

            {
                DP.Reg(name,marc,cb,prec,desc,stoc);

                MessageBox.Show("Los datos se han agregado a la base de datos", "Correcto", BTN);
                this.Close();
            
            }
        }
    }
    
}
