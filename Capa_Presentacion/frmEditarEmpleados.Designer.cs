namespace Capa_Presentacion.Presentacion__Forms_
{
    partial class frmEditarEmpleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalirEmplEdit = new System.Windows.Forms.Button();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.txtEmailEmplEdit = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmplEdit = new System.Windows.Forms.TextBox();
            this.txtDireccionEmplEdit = new System.Windows.Forms.TextBox();
            this.txtDocEmplEdit = new System.Windows.Forms.TextBox();
            this.txtNombreEmplEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTxtDatosADEdit = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dTimeFechaRetiroEdit = new System.Windows.Forms.DateTimePicker();
            this.dTimeFechaInicioEdit = new System.Windows.Forms.DateTimePicker();
            this.cboBoxRolEmpEdit = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(270, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "EDITAR EMPLEADO";
            // 
            // btnSalirEmplEdit
            // 
            this.btnSalirEmplEdit.BackColor = System.Drawing.Color.Gray;
            this.btnSalirEmplEdit.Location = new System.Drawing.Point(403, 302);
            this.btnSalirEmplEdit.Name = "btnSalirEmplEdit";
            this.btnSalirEmplEdit.Size = new System.Drawing.Size(93, 35);
            this.btnSalirEmplEdit.TabIndex = 21;
            this.btnSalirEmplEdit.Text = "SALIR";
            this.btnSalirEmplEdit.UseVisualStyleBackColor = false;
            this.btnSalirEmplEdit.Click += new System.EventHandler(this.btnSalirEmplEdit_Click);
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.BackColor = System.Drawing.Color.Gray;
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(287, 302);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(93, 35);
            this.btnActualizarEmpleado.TabIndex = 20;
            this.btnActualizarEmpleado.Text = "ACTUALIZAR";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = false;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            // 
            // txtEmailEmplEdit
            // 
            this.txtEmailEmplEdit.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailEmplEdit.Location = new System.Drawing.Point(86, 246);
            this.txtEmailEmplEdit.Name = "txtEmailEmplEdit";
            this.txtEmailEmplEdit.Size = new System.Drawing.Size(294, 22);
            this.txtEmailEmplEdit.TabIndex = 19;
            this.txtEmailEmplEdit.Text = "Email";
            // 
            // txtTelefonoEmplEdit
            // 
            this.txtTelefonoEmplEdit.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoEmplEdit.Location = new System.Drawing.Point(86, 209);
            this.txtTelefonoEmplEdit.Name = "txtTelefonoEmplEdit";
            this.txtTelefonoEmplEdit.Size = new System.Drawing.Size(214, 22);
            this.txtTelefonoEmplEdit.TabIndex = 18;
            this.txtTelefonoEmplEdit.Text = "Teléfono";
            // 
            // txtDireccionEmplEdit
            // 
            this.txtDireccionEmplEdit.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionEmplEdit.Location = new System.Drawing.Point(86, 172);
            this.txtDireccionEmplEdit.Name = "txtDireccionEmplEdit";
            this.txtDireccionEmplEdit.Size = new System.Drawing.Size(294, 22);
            this.txtDireccionEmplEdit.TabIndex = 17;
            this.txtDireccionEmplEdit.Text = "Dirección";
            // 
            // txtDocEmplEdit
            // 
            this.txtDocEmplEdit.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocEmplEdit.Location = new System.Drawing.Point(86, 141);
            this.txtDocEmplEdit.Name = "txtDocEmplEdit";
            this.txtDocEmplEdit.Size = new System.Drawing.Size(214, 22);
            this.txtDocEmplEdit.TabIndex = 16;
            this.txtDocEmplEdit.Text = "Documento";
            // 
            // txtNombreEmplEdit
            // 
            this.txtNombreEmplEdit.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmplEdit.Location = new System.Drawing.Point(86, 103);
            this.txtNombreEmplEdit.Name = "txtNombreEmplEdit";
            this.txtNombreEmplEdit.Size = new System.Drawing.Size(294, 22);
            this.txtNombreEmplEdit.TabIndex = 15;
            this.txtNombreEmplEdit.Text = "Nombre Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "DATOS ADICIONALES";
            // 
            // richTxtDatosADEdit
            // 
            this.richTxtDatosADEdit.Location = new System.Drawing.Point(451, 223);
            this.richTxtDatosADEdit.Name = "richTxtDatosADEdit";
            this.richTxtDatosADEdit.Size = new System.Drawing.Size(181, 45);
            this.richTxtDatosADEdit.TabIndex = 38;
            this.richTxtDatosADEdit.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "F. Retiro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Rol Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "F. Inicio";
            // 
            // dTimeFechaRetiroEdit
            // 
            this.dTimeFechaRetiroEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimeFechaRetiroEdit.Location = new System.Drawing.Point(521, 168);
            this.dTimeFechaRetiroEdit.Name = "dTimeFechaRetiroEdit";
            this.dTimeFechaRetiroEdit.Size = new System.Drawing.Size(111, 20);
            this.dTimeFechaRetiroEdit.TabIndex = 34;
            this.dTimeFechaRetiroEdit.Value = new System.DateTime(2025, 2, 11, 0, 0, 0, 0);
            // 
            // dTimeFechaInicioEdit
            // 
            this.dTimeFechaInicioEdit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTimeFechaInicioEdit.Location = new System.Drawing.Point(521, 137);
            this.dTimeFechaInicioEdit.Name = "dTimeFechaInicioEdit";
            this.dTimeFechaInicioEdit.Size = new System.Drawing.Size(111, 20);
            this.dTimeFechaInicioEdit.TabIndex = 33;
            this.dTimeFechaInicioEdit.Value = new System.DateTime(2025, 2, 11, 0, 0, 0, 0);
            // 
            // cboBoxRolEmpEdit
            // 
            this.cboBoxRolEmpEdit.DisplayMember = "RolNombre";
            this.cboBoxRolEmpEdit.FormattingEnabled = true;
            this.cboBoxRolEmpEdit.Location = new System.Drawing.Point(521, 104);
            this.cboBoxRolEmpEdit.Name = "cboBoxRolEmpEdit";
            this.cboBoxRolEmpEdit.Size = new System.Drawing.Size(111, 21);
            this.cboBoxRolEmpEdit.TabIndex = 32;
            this.cboBoxRolEmpEdit.ValueMember = "IdRolEmpleado";
            // 
            // frmEditarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(170)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(751, 376);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTxtDatosADEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dTimeFechaRetiroEdit);
            this.Controls.Add(this.dTimeFechaInicioEdit);
            this.Controls.Add(this.cboBoxRolEmpEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalirEmplEdit);
            this.Controls.Add(this.btnActualizarEmpleado);
            this.Controls.Add(this.txtEmailEmplEdit);
            this.Controls.Add(this.txtTelefonoEmplEdit);
            this.Controls.Add(this.txtDireccionEmplEdit);
            this.Controls.Add(this.txtDocEmplEdit);
            this.Controls.Add(this.txtNombreEmplEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarEmpleados";
            this.Text = "frmEditarEmpleados";
            this.Load += new System.EventHandler(this.frmEditarEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalirEmplEdit;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.TextBox txtEmailEmplEdit;
        private System.Windows.Forms.TextBox txtTelefonoEmplEdit;
        private System.Windows.Forms.TextBox txtDireccionEmplEdit;
        private System.Windows.Forms.TextBox txtDocEmplEdit;
        private System.Windows.Forms.TextBox txtNombreEmplEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTxtDatosADEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dTimeFechaRetiroEdit;
        private System.Windows.Forms.DateTimePicker dTimeFechaInicioEdit;
        private System.Windows.Forms.ComboBox cboBoxRolEmpEdit;
    }
}