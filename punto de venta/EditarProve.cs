﻿using System;
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
    public partial class EditarProve : Form
    {
        public EditarProve()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string c1, c2, c3, c4;

            c1 = busqueda.Text;
            c2 = nombre.Text;
            c3 = tel.Text;
            c4 = mail.Text;

            MessageBoxButtons boton = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Desea editar este registro?", "Editar", boton);


            if (dr == DialogResult.Yes)
            {
                MostrarProve cc = new MostrarProve();
                cc.update(c1,c2,c3,c4);
                MessageBox.Show("Editado");
                this.Close();
            }

            if (dr == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
