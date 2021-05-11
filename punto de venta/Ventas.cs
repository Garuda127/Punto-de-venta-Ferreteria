using System;
using DataAccess;
using System.Collections;
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
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("Cantidad", "Cantidad");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Catalogo cata = new Catalogo(this);
            cata.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.AutoCompleteCustomSource = CargarDatos();
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private AutoCompleteStringCollection CargarDatos()
        {
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();
            VentaDao.VentaDAO vt = new VentaDao.VentaDAO();
            ArrayList myAl = vt.GetProductos();
            for (int i = 0; i < myAl.Count; i++) datos.Add(myAl[i].ToString());



            return datos;
        }

        DatosProdu dp = new DatosProdu();
        int cont = 0;
        double precio = 0;
        public string[,] mat = new string[3,1000];
        public int cc = 0;
        private void button2_Click(object sender, EventArgs e)
        {

            
            string tab = textBox1.Text;
            if (tab != "")
            {


                tablita.DataSource = dp.mostrarventas(tab);
                bool sino = false;
                int n_l = -1;
                for (int i = 0; i < cc; i++)
                {
                    if (mat[0, i] == tablita.Rows[cont].Cells[0].Value.ToString())
                    {
                        sino = true;
                        n_l = i;

                        break;
                    }
                }
                if (sino)
                {
                    mat[2, n_l] = (int.Parse(mat[2, n_l]) + 1).ToString();
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < cc; i++)
                    {
                        if (int.Parse(mat[2, i]) > 0)
                        {
                            dataGridView1.Rows.Add(mat[0, i],
                    mat[1, i], mat[2, i]);
                            /*DataGridViewCell cell = this.dataGridView1.Rows[cc - 1].Cells[0];
                            cell.ToolTipText = "Stock: " + tablita.Rows[cont].Cells[2].Value.ToString();*/

                        }
                    }
                }
                else
                {
                    mat[0, cc] = tablita.Rows[cont].Cells[0].Value.ToString();
                    mat[1, cc] = tablita.Rows[cont].Cells[1].Value.ToString();
                    mat[2, cc] = (1).ToString();
                    cc++;
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < cc; i++)
                    {
                        if (int.Parse(mat[2, i]) > 0)
                        {
                            dataGridView1.Rows.Add(mat[0, i],
                    mat[1, i], mat[2, i]);

                        }
                    }
                }

                lbCantidad.Text = calcularArti() + "";
                lblPrecio.Text = calcularTotal() + "";

                cont++;

                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show("No seleccio nada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombre = "";
            for(int i =0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Selected == true)
                {
                    nombre = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    break;
                }
            }
            if (nombre != "")
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < cc; i++)
                {
                    if (nombre == mat[0, i])
                    {
                        mat[2, i] = (int.Parse(mat[2, i]) - 1).ToString();

                        lbCantidad.Text = calcularArti() + "";
                        lblPrecio.Text = calcularTotal() + "";
                    }
                }
                for (int i = 0; i < cc; i++)
                {
                    if (int.Parse(mat[2, i]) > 0)
                    {
                        dataGridView1.Rows.Add(mat[0, i],
                    mat[1, i], mat[2, i]);
                        /*DataGridViewCell cell = this.dataGridView1.Rows[cc - 1].Cells[0];

                        cell.ToolTipText = "Stock: " + tablita.Rows[cont].Cells[2].Value.ToString();*/
                    }

                }
            }
            else
            {
                MessageBox.Show("No seleccio nada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public double calcularTotal()
        {
            double total = 0;
            for(int i = 0; i < cc; i++)
            {
                total += double.Parse(mat[1, i])*int.Parse(mat[2,i]);
            }
            return total;
        }
        public int calcularArti()
        {
            int total = 0;
            for (int i = 0; i < cc; i++)
            {
                total += int.Parse(mat[2, i]);
            }
            return total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = calcularTotal();
            DateTime myDateTime = DateTime.Now;
            string fecha = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                   
                Random rnd = new Random();
            int id = rnd.Next(1, 10000);
            VentaDao.VentaDAO vt = new VentaDao.VentaDAO();
            if (MessageBox.Show("Desea realizar su compra", "Confirma en Acceptar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                vt.Reg(id, fecha, total);
           }
            for(int i=0;i < cc; i++)
            {
                dp.restador(mat[0, i],int.Parse(mat[2,i]));
            }
            dataGridView1.Rows.Clear();
            mat = new string[3, 1000];
            cc = 0;
            lbCantidad.Text = calcularArti() + "";
            lblPrecio.Text = calcularTotal() + "";
        }

        private void lbCantidad_Click(object sender, EventArgs e)
        {

        }
    }
}
