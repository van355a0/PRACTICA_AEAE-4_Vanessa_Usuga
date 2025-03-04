namespace Capa_Presentacion
{
    partial class frmAdminSeguridad
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
            this.cmbBoxEmpl = new System.Windows.Forms.ComboBox();
            this.txtClaveSeguridad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalirCliente = new System.Windows.Forms.Button();
            this.txtUsuarioSeguridad = new System.Windows.Forms.TextBox();
            this.btnActualizarAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbBoxEmpl
            // 
            this.cmbBoxEmpl.FormattingEnabled = true;
            this.cmbBoxEmpl.Location = new System.Drawing.Point(256, 122);
            this.cmbBoxEmpl.Name = "cmbBoxEmpl";
            this.cmbBoxEmpl.Size = new System.Drawing.Size(348, 21);
            this.cmbBoxEmpl.TabIndex = 9;
            this.cmbBoxEmpl.SelectedIndexChanged += new System.EventHandler(this.cmbBoxEmpl_SelectedIndexChanged);
            // 
            // txtClaveSeguridad
            // 
            this.txtClaveSeguridad.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveSeguridad.Location = new System.Drawing.Point(256, 269);
            this.txtClaveSeguridad.Name = "txtClaveSeguridad";
            this.txtClaveSeguridad.Size = new System.Drawing.Size(232, 22);
            this.txtClaveSeguridad.TabIndex = 11;
            this.txtClaveSeguridad.Text = "Clave";
            this.txtClaveSeguridad.Enter += new System.EventHandler(this.txtClaveSeguridad_Enter);
            this.txtClaveSeguridad.Leave += new System.EventHandler(this.txtClaveSeguridad_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "EMPLEADO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSalirCliente
            // 
            this.btnSalirCliente.BackColor = System.Drawing.Color.Gray;
            this.btnSalirCliente.Location = new System.Drawing.Point(368, 345);
            this.btnSalirCliente.Name = "btnSalirCliente";
            this.btnSalirCliente.Size = new System.Drawing.Size(93, 35);
            this.btnSalirCliente.TabIndex = 14;
            this.btnSalirCliente.Text = "SALIR";
            this.btnSalirCliente.UseVisualStyleBackColor = false;
            this.btnSalirCliente.Click += new System.EventHandler(this.btnSalirCliente_Click);
            // 
            // txtUsuarioSeguridad
            // 
            this.txtUsuarioSeguridad.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioSeguridad.Location = new System.Drawing.Point(256, 204);
            this.txtUsuarioSeguridad.Name = "txtUsuarioSeguridad";
            this.txtUsuarioSeguridad.Size = new System.Drawing.Size(232, 22);
            this.txtUsuarioSeguridad.TabIndex = 15;
            this.txtUsuarioSeguridad.Text = "Usuario";
            this.txtUsuarioSeguridad.TextChanged += new System.EventHandler(this.txtUsuarioSeguridad_TextChanged);
            this.txtUsuarioSeguridad.Enter += new System.EventHandler(this.txtUsuarioSeguridad_Enter);
            this.txtUsuarioSeguridad.Leave += new System.EventHandler(this.txtUsuarioSeguridad_Leave);
            // 
            // btnActualizarAdmin
            // 
            this.btnActualizarAdmin.BackColor = System.Drawing.Color.Gray;
            this.btnActualizarAdmin.Location = new System.Drawing.Point(256, 345);
            this.btnActualizarAdmin.Name = "btnActualizarAdmin";
            this.btnActualizarAdmin.Size = new System.Drawing.Size(93, 35);
            this.btnActualizarAdmin.TabIndex = 16;
            this.btnActualizarAdmin.Text = "ACTUALIZAR";
            this.btnActualizarAdmin.UseVisualStyleBackColor = false;
            this.btnActualizarAdmin.Click += new System.EventHandler(this.btnActualizarAdmin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(241, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "ADMINISTRACION DE SEGURIDAD";
            // 
            // frmAdminSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(170)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnActualizarAdmin);
            this.Controls.Add(this.txtUsuarioSeguridad);
            this.Controls.Add(this.btnSalirCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClaveSeguridad);
            this.Controls.Add(this.cmbBoxEmpl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminSeguridad";
            this.Text = "frmAdminSeguridad";
            this.Load += new System.EventHandler(this.frmAdminSeguridad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxEmpl;
        private System.Windows.Forms.TextBox txtClaveSeguridad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirCliente;
        private System.Windows.Forms.TextBox txtUsuarioSeguridad;
        private System.Windows.Forms.Button btnActualizarAdmin;
        private System.Windows.Forms.Label label2;
    }
}