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
    public partial class Proveedores : Form
    {
        MostrarProve obje = new MostrarProve();
        

        public Proveedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarProv cc = new AgregarProv();
            cc.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
              EliminarV cc = new EliminarV();
              cc.Show();
        }



        private void Proveedores_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obje.mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obje.mostrar();
        }

        private void Buscarbtn_Click(object sender, EventArgs e)
        {
            if (busc.Text == "")
            {
                MessageBox.Show("Campo de busqueda vacío");
            }
            else
            {
                String buscar = busc.Text;
                dataGridView1.DataSource = obje.busqueda(buscar);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditarProve cc = new EditarProve();
            cc.Show();
        }
    }
}
