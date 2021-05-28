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


            if (txt1.Text==""|txt2.Text==""|txt3.Text=="")
            {
                MessageBox.Show("Faltan campos por favor rellene todos");
            }
            else
            {
                String nombre, correo, tel;

                nombre = txt1.Text;
                correo = txt2.Text;
                tel = txt3.Text;

                AgregarProve cc = new AgregarProve();
                cc.Registro(nombre, tel, correo);
                this.Close();
                MessageBox.Show("Agregado");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros en el campo telefono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
