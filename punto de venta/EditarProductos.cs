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
    public partial class EditarProductos : Form
    {
        DatosProdu DP = new DatosProdu();
        public EditarProductos()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarBTN_Click(object sender, EventArgs e)
        {
            string tx = CBColumn.Text;
            string tx2 = TBDato.Text;
            string n =  NUDProd.Value + "";
            DP.editar(tx,tx2,n);
        }
    }
}
