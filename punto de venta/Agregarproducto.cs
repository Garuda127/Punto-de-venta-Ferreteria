﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_de_venta
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            MessageBoxButtons BTN = MessageBoxButtons.OK;
            String name = texnombre.Text;
            String marc = texMarca.Text;
            String prec = texPrecio.Text;
            String desc = Texarea.Text;
            String stoc = Numst.Value + "";
            Double cos;
            int can;
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
                                
                                can = Convert.ToInt32(stoc);
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
                            MessageBox.Show("Ingresa un valor valido en el espacio de la Descripción", "Erro al ingresar los datos",BTN);
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
                MessageBox.Show("Los datos se han agregado a la base de datos","Correcto", BTN);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
