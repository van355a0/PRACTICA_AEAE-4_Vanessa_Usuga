using System;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    partial class frmListaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.btnInfo = new System.Windows.Forms.Button();
            this.bntAñadirCliente = new System.Windows.Forms.Button();
            this.btnBorrarCliente = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.btnClienteEditar = new System.Windows.Forms.Button();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnSalirClientes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(45, 138);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.Size = new System.Drawing.Size(477, 260);
            this.dgClientes.TabIndex = 0;
            this.dgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellClick);
            this.dgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgClientes_CellContentClick);
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(630, 308);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Información";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // bntAñadirCliente
            // 
            this.bntAñadirCliente.Location = new System.Drawing.Point(630, 221);
            this.bntAñadirCliente.Name = "bntAñadirCliente";
            this.bntAñadirCliente.Size = new System.Drawing.Size(75, 23);
            this.bntAñadirCliente.TabIndex = 2;
            this.bntAñadirCliente.Text = "Añadir";
            this.bntAñadirCliente.UseVisualStyleBackColor = true;
            this.bntAñadirCliente.Click += new System.EventHandler(this.bntAñadirCliente_Click);
            // 
            // btnBorrarCliente
            // 
            this.btnBorrarCliente.Location = new System.Drawing.Point(630, 279);
            this.btnBorrarCliente.Name = "btnBorrarCliente";
            this.btnBorrarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarCliente.TabIndex = 4;
            this.btnBorrarCliente.Text = "Borrar";
            this.btnBorrarCliente.UseVisualStyleBackColor = true;
            this.btnBorrarCliente.Click += new System.EventHandler(this.btnBorrarCliente_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(501, 138);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(21, 260);
            this.vScrollBar1.TabIndex = 5;
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(545, 147);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(160, 21);
            this.cboClientes.TabIndex = 6;
            // 
            // btnClienteEditar
            // 
            this.btnClienteEditar.Location = new System.Drawing.Point(630, 250);
            this.btnClienteEditar.Name = "btnClienteEditar";
            this.btnClienteEditar.Size = new System.Drawing.Size(75, 23);
            this.btnClienteEditar.TabIndex = 7;
            this.btnClienteEditar.Text = "Editar";
            this.btnClienteEditar.UseVisualStyleBackColor = true;
            this.btnClienteEditar.Click += new System.EventHandler(this.btnClienteEditar_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(45, 97);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(394, 20);
            this.txtBuscarCliente.TabIndex = 8;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(447, 97);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 9;
            this.btnBuscarCliente.Text = "BUSCAR";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnSalirClientes
            // 
            this.btnSalirClientes.Location = new System.Drawing.Point(630, 375);
            this.btnSalirClientes.Name = "btnSalirClientes";
            this.btnSalirClientes.Size = new System.Drawing.Size(75, 23);
            this.btnSalirClientes.TabIndex = 10;
            this.btnSalirClientes.Text = "SALIR";
            this.btnSalirClientes.UseVisualStyleBackColor = true;
            this.btnSalirClientes.Click += new System.EventHandler(this.btnSalirClientes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(191, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(360, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "ADMINISTRACIÓN DE CLIENTES";
            // 
            // frmListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(170)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalirClientes);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.btnClienteEditar);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btnBorrarCliente);
            this.Controls.Add(this.bntAñadirCliente);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.dgClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListaClientes";
            this.Text = "frmListaClientes";
            this.Load += new System.EventHandler(this.FrmListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void NewMethod()
        {
            this.bntAñadirCliente.Click += new System.EventHandler(this.bntAñadirCliente_Click);
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Button btnInfo;
        private Button bntAñadirCliente;
        private System.Windows.Forms.Button btnAñadirCliente;
        private System.Windows.Forms.Button btnBorrarCliente;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Button btnClienteEditar;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnSalirClientes;
        private Label label5;
    }
}