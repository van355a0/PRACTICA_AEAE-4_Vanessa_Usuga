using System;

namespace Capa_Presentacion
{
    partial class frmEditarCliente
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
            this.txtNombreClienteE = new System.Windows.Forms.TextBox();
            this.btnSalirClienteE = new System.Windows.Forms.Button();
            this.btnActualizarClienteE = new System.Windows.Forms.Button();
            this.txtEmailE = new System.Windows.Forms.TextBox();
            this.txtTelefonoE = new System.Windows.Forms.TextBox();
            this.txtDireccionE = new System.Windows.Forms.TextBox();
            this.txtDocumentoE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreClienteE
            // 
            this.txtNombreClienteE.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreClienteE.Location = new System.Drawing.Point(49, 128);
            this.txtNombreClienteE.Name = "txtNombreClienteE";
            this.txtNombreClienteE.Size = new System.Drawing.Size(311, 22);
            this.txtNombreClienteE.TabIndex = 2;
            this.txtNombreClienteE.Text = "Nombre Cliente";
            this.txtNombreClienteE.TextChanged += new System.EventHandler(this.txtNombreClienteE_TextChanged);
            // 
            // btnSalirClienteE
            // 
            this.btnSalirClienteE.BackColor = System.Drawing.Color.Gray;
            this.btnSalirClienteE.Location = new System.Drawing.Point(220, 364);
            this.btnSalirClienteE.Name = "btnSalirClienteE";
            this.btnSalirClienteE.Size = new System.Drawing.Size(93, 35);
            this.btnSalirClienteE.TabIndex = 13;
            this.btnSalirClienteE.Text = "SALIR";
            this.btnSalirClienteE.UseVisualStyleBackColor = false;
            this.btnSalirClienteE.Click += new System.EventHandler(this.btnSalirClienteE_Click);
            // 
            // btnActualizarClienteE
            // 
            this.btnActualizarClienteE.BackColor = System.Drawing.Color.Gray;
            this.btnActualizarClienteE.Location = new System.Drawing.Point(74, 364);
            this.btnActualizarClienteE.Name = "btnActualizarClienteE";
            this.btnActualizarClienteE.Size = new System.Drawing.Size(93, 35);
            this.btnActualizarClienteE.TabIndex = 12;
            this.btnActualizarClienteE.Text = "ACTUALIZAR";
            this.btnActualizarClienteE.UseVisualStyleBackColor = false;
            this.btnActualizarClienteE.Click += new System.EventHandler(this.btnActualizarClienteE_Click);
            // 
            // txtEmailE
            // 
            this.txtEmailE.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailE.Location = new System.Drawing.Point(49, 312);
            this.txtEmailE.Name = "txtEmailE";
            this.txtEmailE.Size = new System.Drawing.Size(311, 22);
            this.txtEmailE.TabIndex = 11;
            this.txtEmailE.Text = "Email";
            // 
            // txtTelefonoE
            // 
            this.txtTelefonoE.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoE.Location = new System.Drawing.Point(49, 268);
            this.txtTelefonoE.Name = "txtTelefonoE";
            this.txtTelefonoE.Size = new System.Drawing.Size(214, 22);
            this.txtTelefonoE.TabIndex = 10;
            this.txtTelefonoE.Text = "Teléfono";
            // 
            // txtDireccionE
            // 
            this.txtDireccionE.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionE.Location = new System.Drawing.Point(49, 217);
            this.txtDireccionE.Name = "txtDireccionE";
            this.txtDireccionE.Size = new System.Drawing.Size(311, 22);
            this.txtDireccionE.TabIndex = 9;
            this.txtDireccionE.Text = "Dirección";
            // 
            // txtDocumentoE
            // 
            this.txtDocumentoE.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoE.Location = new System.Drawing.Point(49, 170);
            this.txtDocumentoE.Name = "txtDocumentoE";
            this.txtDocumentoE.Size = new System.Drawing.Size(214, 22);
            this.txtDocumentoE.TabIndex = 8;
            this.txtDocumentoE.Text = "Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(117, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "EDITAR CLIENTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(170)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirClienteE);
            this.Controls.Add(this.btnActualizarClienteE);
            this.Controls.Add(this.txtEmailE);
            this.Controls.Add(this.txtTelefonoE);
            this.Controls.Add(this.txtDireccionE);
            this.Controls.Add(this.txtDocumentoE);
            this.Controls.Add(this.txtNombreClienteE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarCliente";
            this.Text = "frmEditarClientes";
            this.Load += new System.EventHandler(this.frmEditarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreClienteE;
        private System.Windows.Forms.Button btnSalirClienteE;
        private System.Windows.Forms.Button btnActualizarClienteE;
        private System.Windows.Forms.TextBox txtEmailE;
        private System.Windows.Forms.TextBox txtTelefonoE;
        private System.Windows.Forms.TextBox txtDireccionE;
        private System.Windows.Forms.TextBox txtDocumentoE;
        private System.Windows.Forms.Label label1;
    }
}