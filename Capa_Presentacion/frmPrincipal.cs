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

namespace Capa_Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
          
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form fh = Formhijo as Form;
            if (fh != null)
            {
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();
            }
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmListaClientes());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmProductos());
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmInformes());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmEmpleados());
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmAdminSeguridad());
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmPanelPrincipal());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
