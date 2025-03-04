namespace Capa_Presentacion
{
    partial class frmInformes
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
            this.comboBoxSelectInforme = new System.Windows.Forms.ComboBox();
            this.comboBoxOrdenarpor = new System.Windows.Forms.ComboBox();
            this.checkPantalla = new System.Windows.Forms.CheckBox();
            this.checkPdf = new System.Windows.Forms.CheckBox();
            this.checkExcel = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeFechaInicioI = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFechaFinalInf = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenInforme = new System.Windows.Forms.Button();
            this.btnSalirInformes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSelectInforme
            // 
            this.comboBoxSelectInforme.FormattingEnabled = true;
            this.comboBoxSelectInforme.Location = new System.Drawing.Point(217, 119);
            this.comboBoxSelectInforme.Name = "comboBoxSelectInforme";
            this.comboBoxSelectInforme.Size = new System.Drawing.Size(169, 21);
            this.comboBoxSelectInforme.TabIndex = 8;
            // 
            // comboBoxOrdenarpor
            // 
            this.comboBoxOrdenarpor.FormattingEnabled = true;
            this.comboBoxOrdenarpor.Location = new System.Drawing.Point(549, 119);
            this.comboBoxOrdenarpor.Name = "comboBoxOrdenarpor";
            this.comboBoxOrdenarpor.Size = new System.Drawing.Size(169, 21);
            this.comboBoxOrdenarpor.TabIndex = 9;
            // 
            // checkPantalla
            // 
            this.checkPantalla.AutoSize = true;
            this.checkPantalla.Location = new System.Drawing.Point(247, 275);
            this.checkPantalla.Name = "checkPantalla";
            this.checkPantalla.Size = new System.Drawing.Size(80, 17);
            this.checkPantalla.TabIndex = 10;
            this.checkPantalla.Text = "En Pantalla";
            this.checkPantalla.UseVisualStyleBackColor = true;
            // 
            // checkPdf
            // 
            this.checkPdf.AutoSize = true;
            this.checkPdf.Location = new System.Drawing.Point(404, 275);
            this.checkPdf.Name = "checkPdf";
            this.checkPdf.Size = new System.Drawing.Size(42, 17);
            this.checkPdf.TabIndex = 11;
            this.checkPdf.Text = "Pdf";
            this.checkPdf.UseVisualStyleBackColor = true;
            // 
            // checkExcel
            // 
            this.checkExcel.AutoSize = true;
            this.checkExcel.Location = new System.Drawing.Point(515, 275);
            this.checkExcel.Name = "checkExcel";
            this.checkExcel.Size = new System.Drawing.Size(52, 17);
            this.checkExcel.TabIndex = 12;
            this.checkExcel.Text = "Excel";
            this.checkExcel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "SELECCIONE INFORME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ordenar por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha Final";
            // 
            // dateTimeFechaInicioI
            // 
            this.dateTimeFechaInicioI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaInicioI.Location = new System.Drawing.Point(275, 212);
            this.dateTimeFechaInicioI.Name = "dateTimeFechaInicioI";
            this.dateTimeFechaInicioI.Size = new System.Drawing.Size(111, 20);
            this.dateTimeFechaInicioI.TabIndex = 17;
            this.dateTimeFechaInicioI.Value = new System.DateTime(2025, 2, 11, 0, 0, 0, 0);
            // 
            // dateTimeFechaFinalInf
            // 
            this.dateTimeFechaFinalInf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFechaFinalInf.Location = new System.Drawing.Point(614, 212);
            this.dateTimeFechaFinalInf.Name = "dateTimeFechaFinalInf";
            this.dateTimeFechaFinalInf.Size = new System.Drawing.Size(104, 20);
            this.dateTimeFechaFinalInf.TabIndex = 18;
            this.dateTimeFechaFinalInf.Value = new System.DateTime(2025, 2, 14, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(146, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(524, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            // 
            // btnGenInforme
            // 
            this.btnGenInforme.BackColor = System.Drawing.Color.Gray;
            this.btnGenInforme.Location = new System.Drawing.Point(247, 353);
            this.btnGenInforme.Name = "btnGenInforme";
            this.btnGenInforme.Size = new System.Drawing.Size(139, 35);
            this.btnGenInforme.TabIndex = 20;
            this.btnGenInforme.Text = "GENERAR INFORME";
            this.btnGenInforme.UseVisualStyleBackColor = false;
            // 
            // btnSalirInformes
            // 
            this.btnSalirInformes.BackColor = System.Drawing.Color.Gray;
            this.btnSalirInformes.Location = new System.Drawing.Point(438, 353);
            this.btnSalirInformes.Name = "btnSalirInformes";
            this.btnSalirInformes.Size = new System.Drawing.Size(93, 35);
            this.btnSalirInformes.TabIndex = 21;
            this.btnSalirInformes.Text = "SALIR";
            this.btnSalirInformes.UseVisualStyleBackColor = false;
            // 
            // frmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(170)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalirInformes);
            this.Controls.Add(this.btnGenInforme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeFechaFinalInf);
            this.Controls.Add(this.dateTimeFechaInicioI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkExcel);
            this.Controls.Add(this.checkPdf);
            this.Controls.Add(this.checkPantalla);
            this.Controls.Add(this.comboBoxOrdenarpor);
            this.Controls.Add(this.comboBoxSelectInforme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInformes";
            this.Text = "frmInformes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSelectInforme;
        private System.Windows.Forms.ComboBox comboBoxOrdenarpor;
        private System.Windows.Forms.CheckBox checkPantalla;
        private System.Windows.Forms.CheckBox checkPdf;
        private System.Windows.Forms.CheckBox checkExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeFechaInicioI;
        private System.Windows.Forms.DateTimePicker dateTimeFechaFinalInf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenInforme;
        private System.Windows.Forms.Button btnSalirInformes;
    }
}