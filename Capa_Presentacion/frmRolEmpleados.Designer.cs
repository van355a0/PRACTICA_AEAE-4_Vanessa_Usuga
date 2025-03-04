namespace Capa_Presentacion
{
    partial class frmRolEmpleados
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
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnActualizarRol = new System.Windows.Forms.Button();
            this.btnSalirRol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRol.Location = new System.Drawing.Point(237, 128);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(232, 22);
            this.txtNombreRol.TabIndex = 10;
            this.txtNombreRol.Text = "Nombre Rol";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(237, 212);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(230, 132);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // btnActualizarRol
            // 
            this.btnActualizarRol.BackColor = System.Drawing.Color.Gray;
            this.btnActualizarRol.Location = new System.Drawing.Point(237, 373);
            this.btnActualizarRol.Name = "btnActualizarRol";
            this.btnActualizarRol.Size = new System.Drawing.Size(93, 35);
            this.btnActualizarRol.TabIndex = 12;
            this.btnActualizarRol.Text = "ACTUALIZAR";
            this.btnActualizarRol.UseVisualStyleBackColor = false;
            // 
            // btnSalirRol
            // 
            this.btnSalirRol.BackColor = System.Drawing.Color.Gray;
            this.btnSalirRol.Location = new System.Drawing.Point(374, 373);
            this.btnSalirRol.Name = "btnSalirRol";
            this.btnSalirRol.Size = new System.Drawing.Size(93, 35);
            this.btnSalirRol.TabIndex = 13;
            this.btnSalirRol.Text = "SALIR";
            this.btnSalirRol.UseVisualStyleBackColor = false;
            this.btnSalirRol.Click += new System.EventHandler(this.btnSalirRol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "DESCRIPCION DETALLADA ROL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(232, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "ROL DE EMPLEADOS";
            // 
            // frmRolEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(170)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirRol);
            this.Controls.Add(this.btnActualizarRol);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtNombreRol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRolEmpleados";
            this.Text = "frmRolEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnActualizarRol;
        private System.Windows.Forms.Button btnSalirRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}