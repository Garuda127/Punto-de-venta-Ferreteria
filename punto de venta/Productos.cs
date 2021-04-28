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
    public partial class Productos : Form
    {
        DatosProdu DP = new DatosProdu();
        public Productos()
        {
            InitializeComponent();
            tab.DataSource = DP.mostrar();
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

        private void tab_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void actualizar(Boolean tf){
            if (tf)
            {
                tab.DataSource = DP.mostrar();
            }
            
        }
    }
}
