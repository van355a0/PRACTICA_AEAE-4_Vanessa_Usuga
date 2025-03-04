namespace Capa_Presentacion
{
    partial class frmCategoriaProductos
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
            this.btnActualizarCategoria = new System.Windows.Forms.Button();
            this.btnSalirCategoria = new System.Windows.Forms.Button();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnActualizarCategoria
            // 
            this.btnActualizarCategoria.BackColor = System.Drawing.Color.Gray;
            this.btnActualizarCategoria.Location = new System.Drawing.Point(153, 308);
            this.btnActualizarCategoria.Name = "btnActualizarCategoria";
            this.btnActualizarCategoria.Size = new System.Drawing.Size(93, 35);
            this.btnActualizarCategoria.TabIndex = 7;
            this.btnActualizarCategoria.Text = "ACTUALIZAR";
            this.btnActualizarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnSalirCategoria
            // 
            this.btnSalirCategoria.BackColor = System.Drawing.Color.Gray;
            this.btnSalirCategoria.Location = new System.Drawing.Point(283, 308);
            this.btnSalirCategoria.Name = "btnSalirCategoria";
            this.btnSalirCategoria.Size = new System.Drawing.Size(93, 35);
            this.btnSalirCategoria.TabIndex = 8;
            this.btnSalirCategoria.Text = "SALIR";
            this.btnSalirCategoria.UseVisualStyleBackColor = false;
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCategoria.Location = new System.Drawing.Point(144, 201);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(232, 22);
            this.txtNombreCategoria.TabIndex = 9;
            this.txtNombreCategoria.Text = "Nombre Categoria";
            this.txtNombreCategoria.TextChanged += new System.EventHandler(this.txtNombreCategoria_TextChanged);
            this.txtNombreCategoria.Enter += new System.EventHandler(this.txtNombreCategoria_Enter);
            this.txtNombreCategoria.Leave += new System.EventHandler(this.txtNombreCategoria_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(61, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "CATEGORIA DE PRODUCTOS";
            // 
            // frmCategoriaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(170)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(480, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombreCategoria);
            this.Controls.Add(this.btnSalirCategoria);
            this.Controls.Add(this.btnActualizarCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCategoriaProductos";
            this.Text = "frmCategoriaProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarCategoria;
        private System.Windows.Forms.Button btnSalirCategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label label3;
    }
}