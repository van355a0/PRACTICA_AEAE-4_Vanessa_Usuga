using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class frmRolEmpleados : Form
    {
        public frmRolEmpleados()
        {
            InitializeComponent();
        }

        private void btnSalirRol_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
