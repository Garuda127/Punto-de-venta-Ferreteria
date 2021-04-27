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
    public partial class EliminarV : Form
    {
        public EliminarV()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons boton = MessageBoxButtons.YesNo;
            DialogResult dr = MessageBox.Show("¿Desea borrar este registro?","Borrar",boton);


            if (dr==DialogResult.Yes)
            {
                string borr = textBox1.Text;
                MostrarProve cc = new MostrarProve();
                cc.borrar(borr);
                MessageBox.Show("Borrado");
                this.Close();
            }

            if (dr==DialogResult.No)
            {
                this.Close();
            }

        }
    }
}
