using System;
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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            AgregarProducto Frm = new AgregarProducto();
            Frm.Show();
        }

        private void EditarBTN_Click(object sender, EventArgs e)
        {

        }

        private void EliminarBTN_Click(object sender, EventArgs e)
        {

        }

        private void BuscarBTN_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
