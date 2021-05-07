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
            Catalogo cata = new Catalogo();
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

        private void button2_Click(object sender, EventArgs e)
        {
            string tab = textBox1.Text;

            tablita.DataSource = dp.mostrarventas(tab);
            dataGridView1.Rows.Add(tablita.Rows[cont].Cells[0].Value.ToString(),
            tablita.Rows[cont].Cells[1].Value.ToString(), "1");
            lbCantidad.Text = (cont + 1) + "";
            precio += Convert.ToDouble(tablita.Rows[cont].Cells[1].Value.ToString());
            lblPrecio.Text = precio + "";
            DataGridViewCell cell = this.dataGridView1.Rows[cont].Cells[0];
            cell.ToolTipText = "Stock: " + tablita.Rows[cont].Cells[2].Value.ToString();
            cont++;

            textBox1.Text = "";
        }
    }
}
