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
        MostrarProve cc = new MostrarProve();

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
            string nombre = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    nombre = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    break;
                }
            }
            cc.borrar(nombre);
            dataGridView1.DataSource = cc.mostrar();
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
