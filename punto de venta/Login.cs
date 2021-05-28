using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Common.Cache;

namespace punto_de_venta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string c1 = txtuser.Text;
            //string c2 = txtpass.Text;

            //if (c1 == "adminCEO" && c2 == "contraCEO")
            //{
            //    Menu cc = new Menu();
            //    cc.Show();
            //}

            if (txtuser.Text != "USUARIO" && txtuser.TextLength > 2)
            {
                if (txtpass.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(txtuser.Text, txtpass.Text);
                    if (validLogin == true)
                    {
                        FormModernoPruebas cc = new FormModernoPruebas();
                         cc.Show();
                   
                        this.Hide();
                    }
                    else
                    {
                        msgError("Nombre de usuario y/o contraseña incorrectos. \n   Intenta de nuevo.");
                        txtpass.Text = "CONTRASEÑA";
                        txtpass.UseSystemPasswordChar = false;
                        txtuser.Focus();
                    }
                }
                else msgError("Porfavor Ingresa la contraseña.");
            }
            else msgError("Porfavor Ingresa el nombre de usuario.");
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "    " + msg;
            lblErrorMessage.Visible = true;
        }
    }
}
