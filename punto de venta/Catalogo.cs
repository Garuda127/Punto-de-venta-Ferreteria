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
    public partial class Catalogo : Form
    {
        private Button reportButton = new Button();
        Ventas vt;
        public Catalogo(Ventas vt)
        {
            InitializeComponent();
            this.vt = vt;
        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            DatosProdu dp = new DatosProdu();
            

                dataGridView1.DataSource = dp.mostrar();
        }
        private void reportButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Task Assignments");
        }
        string nombre = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        int cx = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    nombre = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    x = i;
                    break;
                }
            }
            
            DatosProdu dp = new DatosProdu();
            dataGridView2.DataSource = dp.mostrarventas(nombre);
            //MessageBox.Show(x+"" + nombre, "asd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            vt.dataGridView1.Rows.Add(dataGridView2.Rows[0].Cells[0].Value.ToString(), dataGridView2.Rows[0].Cells[1].Value.ToString(), "1");
            bool sino = false;
            int n_l = 0;
            for (int i = 0; i <vt.cc; i++)
            {
                if (vt.mat[0, i] == dataGridView2.Rows[0].Cells[0].Value.ToString())
                {
                    sino = true;
                    n_l = i;                    
                    break;
                }
            }
            if (sino)
            {
                vt.mat[2, n_l] = (int.Parse(vt.mat[2, n_l]) + 1).ToString();
                vt.dataGridView1.Rows.Clear();
                for (int i = 0; i < vt.cc; i++)
                {
                    if (int.Parse(vt.mat[2, i]) > 0)
                    {
                        vt.dataGridView1.Rows.Add(vt.mat[0, i],
                vt.mat[1, i], vt.mat[2, i]);
                        /*DataGridViewCell cell = this.dataGridView1.Rows[cc - 1].Cells[0];
                        cell.ToolTipText = "Stock: " + tablita.Rows[cont].Cells[2].Value.ToString();*/

                    }
                }
            }
            else
            {
                vt.mat[0, vt.cc] = dataGridView2.Rows[0].Cells[0].Value.ToString();
                vt.mat[1, vt.cc] = dataGridView2.Rows[0].Cells[1].Value.ToString();
                vt.mat[2, vt.cc] = (1).ToString();
                vt.cc++;
                vt.dataGridView1.Rows.Clear();
                for (int i = 0; i < vt.cc; i++)
                {
                    if (int.Parse(vt.mat[2, i]) > 0)
                    {
                        vt.dataGridView1.Rows.Add(vt.mat[0, i],
                vt.mat[1, i], vt.mat[2, i]);

                    }
                }
            }
            vt.lbCantidad.Text = vt.calcularArti() + "";
            vt.lblPrecio.Text = vt.calcularTotal() + "";
            cx++;
        }
    }
}
