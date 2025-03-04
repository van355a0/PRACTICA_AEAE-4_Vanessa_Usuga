using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Capa_Entidades;

namespace Capa_Presentacion
{
    public partial class frmLogin_D : Form
    {
        public frmLogin_D()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "USUARIO") {
                txtUser.Text = "";
                txtUser.ForeColor = Color.FromArgb(64,64,64) ;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if(txtUser.Text =="")
            { txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "CONTRASEÑA")
            { txtPassword.Text = "";
                txtPassword.ForeColor = Color.FromArgb(64, 64, 64);
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text == "")
            { txtPassword.Text = "CONTRASEÑA";
                txtPassword.ForeColor = Color.DimGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "USUARIO" && txtPassword.Text != "CONTRASEÑA")
            {

                UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
                string Respuesta = usuarioNegocio.Login(txtUser.Text, txtPassword.Text);

                if (Respuesta != "")
                {
                    MessageBox.Show("Bienvenido : " + Respuesta);
                    frmPrincipal frmppal = new frmPrincipal();
                    this.Hide();
                    frmppal.Show();
                }
                else
                {
                    MessageBox.Show("Usuarios y Clave no encontrados");
                    ResetForm();
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar un usuario y una clave");
            }
        }

        private void ResetForm()
        {
            txtUser.Text = "USUARIO";
            txtPassword.Text = "CONTRASEÑA";
            txtPassword.UseSystemPasswordChar = false;
            txtUser.Focus();
        }


        private void btnCancelarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_D_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
