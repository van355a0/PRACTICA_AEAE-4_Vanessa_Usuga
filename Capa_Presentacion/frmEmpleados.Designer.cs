using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    partial class frmEmpleados
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
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtDocumentoEm = new System.Windows.Forms.TextBox();
            this.txtDireccionEm = new System.Windows.Forms.TextBox();
            this.txtTelefonoEm = new System.Windows.Forms.TextBox();
            this.txtEmailEmp = new System.Windows.Forms.TextBox();
            this.comboBoxRolEmp = new System.Windows.Forms.ComboBox();
            this.dateTimeFechaInicioE = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaRetiroEm = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.btnAnadirEmpl = new System.Windows.Forms.Button();
            this.btnEditarEmpl = new System.Windows.Forms.Button();
            this.btnGuardarEmpl = new System.Windows.Forms.Button();
            this.btnBorrarEmpl = new System.Windows.Forms.Button();
            this.richTxtDatosAD = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Location = new System.Drawing.Point(59, 110);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(268, 22);
            this.txtNombreEmpleado.TabIndex = 2;
            this.txtNombreEmpleado.Text = "Nombre Cliente";
            this.txtNombreEmpleado.Enter += new System.EventHandler(this.txtNombreEmpleado_Enter);
            // 
            // txtDocumentoEm
            // 
            this.txtDocumentoEm.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoEm.Location = new System.Drawing.Point(59, 138);
            this.txtDocumentoEm.Name = "txtDocumentoEm";
            this.txtDocumentoEm.Size = new System.Drawing.Size(214, 22);
            this.txtDocumentoEm.TabIndex = 3;
            this.txtDocumentoEm.Text = "Documento";
            // 
            // txtDireccionEm
            // 
            this.txtDireccionEm.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionEm.Location = new System.Drawing.Point(59, 166);
            this.txtDireccionEm.Name = "txtDireccionEm";
            this.txtDireccionEm.Size = new System.Drawing.Size(268, 22);
            this.txtDireccionEm.TabIndex = 4;
            this.txtDireccionEm.Text = "Dirección";
            // 
            // txtTelefonoEm
            // 
            this.txtTelefonoEm.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoEm.Location = new System.Drawing.Point(59, 196);
            this.txtTelefonoEm.Name = "txtTelefonoEm";
            this.txtTelefonoEm.Size = new System.Drawing.Size(192, 22);
            this.txtTelefonoEm.TabIndex = 5;
            this.txtTelefonoEm.Text = "Teléfono";
            // 
            // txtEmailEmp
            // 
            this.txtEmailEmp.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailEmp.Location = new System.Drawing.Point(59, 228);
            this.txtEmailEmp.Name = "txtEmailEmp";
            this.txtEmailEmp.Size = new System.Drawing.Size(268, 22);
            this.txtEmailEmp.TabIndex = 6;
            this.txtEmailEmp.Text = "Email";
            // 
            // comboBoxRolEmp
            // 
            this.comboBoxRolEmp.FormattingEnabled = true;
            this.comboBoxRolEmp.Location = new System.Drawing.Point(462, 109);
            this.comboBoxRolEmp.Name = "comboBoxRolEmp";
            this.comboBoxRolEmp.Size = new System.Drawing.Size(111, 21);
            this.comboBoxRolEmp.TabIndex = 8;
            this.comboBoxRolEmp.SelectedIndexChanged += new System.EventHandler(this.comboBoxRolEmp_SelectedIndexChanged);
            // 
            // dateTimeFechaInicioE
            // 
            this.dateTimeFechaInicioE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaInicioE.Location = new System.Drawing.Point(462, 140);
            this.dateTimeFechaInicioE.Name = "dateTimeFechaInicioE";
            this.dateTimeFechaInicioE.Size = new System.Drawing.Size(111, 20);
            this.dateTimeFechaInicioE.TabIndex = 18;
            this.dateTimeFechaInicioE.Value = new System.DateTime(2025, 2, 11, 0, 0, 0, 0);
            // 
            // dateTimeFechaRetiroEm
            // 
            this.dateTimeFechaRetiroEm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaRetiroEm.Location = new System.Drawing.Point(462, 168);
            this.dateTimeFechaRetiroEm.Name = "dateTimeFechaRetiroEm";
            this.dateTimeFechaRetiroEm.Size = new System.Drawing.Size(111, 20);
            this.dateTimeFechaRetiroEm.TabIndex = 19;
            this.dateTimeFechaRetiroEm.Value = new System.DateTime(2025, 2, 11, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "F. Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Rol Empleado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "F. Retiro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(183, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Location = new System.Drawing.Point(59, 279);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.Size = new System.Drawing.Size(684, 126);
            this.dgEmpleados.TabIndex = 25;
            this.dgEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpleados_CellClick);
            this.dgEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmpleados_CellContentClick);
            // 
            // btnAnadirEmpl
            // 
            this.btnAnadirEmpl.Location = new System.Drawing.Point(668, 109);
            this.btnAnadirEmpl.Name = "btnAnadirEmpl";
            this.btnAnadirEmpl.Size = new System.Drawing.Size(75, 23);
            this.btnAnadirEmpl.TabIndex = 26;
            this.btnAnadirEmpl.Text = "Añadir";
            this.btnAnadirEmpl.UseVisualStyleBackColor = true;
            this.btnAnadirEmpl.Click += new System.EventHandler(this.btnAnadirEmpl_Click);
            // 
            // btnEditarEmpl
            // 
            this.btnEditarEmpl.Location = new System.Drawing.Point(668, 166);
            this.btnEditarEmpl.Name = "btnEditarEmpl";
            this.btnEditarEmpl.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEmpl.TabIndex = 27;
            this.btnEditarEmpl.Text = "Editar";
            this.btnEditarEmpl.UseVisualStyleBackColor = true;
            this.btnEditarEmpl.Click += new System.EventHandler(this.btnEditarEmpl_Click);
            // 
            // btnGuardarEmpl
            // 
            this.btnGuardarEmpl.Location = new System.Drawing.Point(668, 136);
            this.btnGuardarEmpl.Name = "btnGuardarEmpl";
            this.btnGuardarEmpl.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarEmpl.TabIndex = 28;
            this.btnGuardarEmpl.Text = "Guardar";
            this.btnGuardarEmpl.UseVisualStyleBackColor = true;
            this.btnGuardarEmpl.Click += new System.EventHandler(this.btnGuardarEmpl_Click);
            // 
            // btnBorrarEmpl
            // 
            this.btnBorrarEmpl.Location = new System.Drawing.Point(668, 195);
            this.btnBorrarEmpl.Name = "btnBorrarEmpl";
            this.btnBorrarEmpl.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarEmpl.TabIndex = 29;
            this.btnBorrarEmpl.Text = "Borrar";
            this.btnBorrarEmpl.UseVisualStyleBackColor = true;
            this.btnBorrarEmpl.Click += new System.EventHandler(this.btnBorrarEmpl_Click);
            // 
            // richTxtDatosAD
            // 
            this.richTxtDatosAD.Location = new System.Drawing.Point(392, 216);
            this.richTxtDatosAD.Name = "richTxtDatosAD";
            this.richTxtDatosAD.Size = new System.Drawing.Size(181, 45);
            this.richTxtDatosAD.TabIndex = 30;
            this.richTxtDatosAD.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "DATOS ADICIONALES";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(170)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTxtDatosAD);
            this.Controls.Add(this.btnBorrarEmpl);
            this.Controls.Add(this.btnGuardarEmpl);
            this.Controls.Add(this.btnEditarEmpl);
            this.Controls.Add(this.btnAnadirEmpl);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeFechaRetiroEm);
            this.Controls.Add(this.dateTimeFechaInicioE);
            this.Controls.Add(this.comboBoxRolEmp);
            this.Controls.Add(this.txtEmailEmp);
            this.Controls.Add(this.txtTelefonoEm);
            this.Controls.Add(this.txtDireccionEm);
            this.Controls.Add(this.txtDocumentoEm);
            this.Controls.Add(this.txtNombreEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnAnadirEmpl_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnGuardarEmpl_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBoxRolEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void txtNombreEmpleado_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }




        #endregion

        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtDocumentoEm;
        private System.Windows.Forms.TextBox txtDireccionEm;
        private System.Windows.Forms.TextBox txtTelefonoEm;
        private System.Windows.Forms.TextBox txtEmailEmp;
        private System.Windows.Forms.ComboBox comboBoxRolEmp;
        private System.Windows.Forms.DateTimePicker dateTimeFechaInicioE;
        private System.Windows.Forms.DateTimePicker dateTimeFechaRetiroEm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.Button btnAnadirEmpl;
        private System.Windows.Forms.Button btnEditarEmpl;
        private System.Windows.Forms.Button btnGuardarEmpl;
        private System.Windows.Forms.Button btnBorrarEmpl;
        private System.Windows.Forms.RichTextBox richTxtDatosAD;
        private System.Windows.Forms.Label label4;
    }
}