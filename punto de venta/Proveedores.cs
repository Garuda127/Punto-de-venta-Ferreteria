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

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obje.mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obje.mostrar();
        }
    }
}
