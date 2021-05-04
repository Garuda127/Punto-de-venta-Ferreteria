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
        MessageBoxButtons BTN = MessageBoxButtons.OK;
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
            EditarProductos Frm = new EditarProductos();
            Frm.Show();
        }

        private void EliminarBTN_Click(object sender, EventArgs e)
        {
            if (!TBBus.Text.Equals(""))
            {
                DP.eliminar(CBFIL.Text, TBBus.Text);
            }
            else
            {
                MessageBox.Show("Ingresa una palabra clabe o digito", "Error al ingresar los datos", BTN);
            }
        }

        private void BuscarBTN_Click(object sender, EventArgs e)
        {


            if (!TBBus.Text.Equals(""))
            {
                tab.DataSource = DP.busqueda(CBFIL.Text,TBBus.Text);
                
            }
            else
            {
                MessageBox.Show("Ingresa una palabra clabe o digito", "Error al ingresar los datos", BTN);
            }
        }

        private void Actual_Click(object sender, EventArgs e)
        {
            tab.DataSource = DP.mostrar();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }
    }
}
