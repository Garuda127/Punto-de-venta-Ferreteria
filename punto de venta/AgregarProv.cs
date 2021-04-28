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
    public partial class AgregarProv : Form
    {
        public AgregarProv()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nombre, correo, tel;

            nombre = txt1.Text;
            correo = txt2.Text;
            tel = txt3.Text;

            AgregarProve cc = new AgregarProve();
            cc.Registro(nombre,tel,correo);
            this.Close();
            MessageBox.Show("Agregado");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
