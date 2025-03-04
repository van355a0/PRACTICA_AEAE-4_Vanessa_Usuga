namespace Capa_Presentacion
{
    partial class frmProductos
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
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtCodigoRef = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtCantidadStock = new System.Windows.Forms.TextBox();
            this.cboCategoriaProd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTxtDetallesProd = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTxtRutaImagen = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalirClientes = new System.Windows.Forms.Button();
            this.btnProdEditar = new System.Windows.Forms.Button();
            this.btnBorrarProd = new System.Windows.Forms.Button();
            this.bntAñadirCliente = new System.Windows.Forms.Button();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.btnGuardarProd = new System.Windows.Forms.Button();
            this.dgProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProducto.Location = new System.Drawing.Point(116, 188);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(184, 22);
            this.txtNombreProducto.TabIndex = 2;
            this.txtNombreProducto.Text = "Nombre Producto";
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            this.txtNombreProducto.Enter += new System.EventHandler(this.txtNombreProducto_Enter);
            this.txtNombreProducto.Leave += new System.EventHandler(this.txtNombreProducto_Leave);
            // 
            // txtCodigoRef
            // 
            this.txtCodigoRef.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoRef.Location = new System.Drawing.Point(116, 216);
            this.txtCodigoRef.Name = "txtCodigoRef";
            this.txtCodigoRef.Size = new System.Drawing.Size(151, 22);
            this.txtCodigoRef.TabIndex = 3;
            this.txtCodigoRef.Text = "Codigo Referencia";
            this.txtCodigoRef.Enter += new System.EventHandler(this.txtCodigoRef_Enter);
            this.txtCodigoRef.Leave += new System.EventHandler(this.txtCodigoRef_Leave);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(116, 244);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(151, 22);
            this.txtPrecioCompra.TabIndex = 4;
            this.txtPrecioCompra.Text = "Precio Compra";
            this.txtPrecioCompra.Enter += new System.EventHandler(this.txtPrecioCompra_Enter);
            this.txtPrecioCompra.Leave += new System.EventHandler(this.txtPrecioCompra_Leave);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(116, 272);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(151, 22);
            this.txtPrecioVenta.TabIndex = 5;
            this.txtPrecioVenta.Text = "Precio Venta";
            this.txtPrecioVenta.Enter += new System.EventHandler(this.txtPrecioVenta_Enter);
            this.txtPrecioVenta.Leave += new System.EventHandler(this.txtPrecioVenta_Leave);
            // 
            // txtCantidadStock
            // 
            this.txtCantidadStock.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadStock.Location = new System.Drawing.Point(116, 300);
            this.txtCantidadStock.Name = "txtCantidadStock";
            this.txtCantidadStock.Size = new System.Drawing.Size(151, 22);
            this.txtCantidadStock.TabIndex = 6;
            this.txtCantidadStock.Text = "Cantidad Stock";
            this.txtCantidadStock.Enter += new System.EventHandler(this.txtCantidadStock_Enter);
            this.txtCantidadStock.Leave += new System.EventHandler(this.txtCantidadStock_Leave);
            // 
            // cboCategoriaProd
            // 
            this.cboCategoriaProd.FormattingEnabled = true;
            this.cboCategoriaProd.Location = new System.Drawing.Point(474, 139);
            this.cboCategoriaProd.Name = "cboCategoriaProd";
            this.cboCategoriaProd.Size = new System.Drawing.Size(136, 21);
            this.cboCategoriaProd.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Categoria";
            // 
            // richTxtDetallesProd
            // 
            this.richTxtDetallesProd.Location = new System.Drawing.Point(434, 216);
            this.richTxtDetallesProd.Name = "richTxtDetallesProd";
            this.richTxtDetallesProd.Size = new System.Drawing.Size(176, 106);
            this.richTxtDetallesProd.TabIndex = 9;
            this.richTxtDetallesProd.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Detalles Producto";
            // 
            // richTxtRutaImagen
            // 
            this.richTxtRutaImagen.Location = new System.Drawing.Point(434, 177);
            this.richTxtRutaImagen.Name = "richTxtRutaImagen";
            this.richTxtRutaImagen.Size = new System.Drawing.Size(176, 22);
            this.richTxtRutaImagen.TabIndex = 11;
            this.richTxtRutaImagen.Text = "Ruta Imagen";
            this.richTxtRutaImagen.Enter += new System.EventHandler(this.richTextBox2_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(126, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "ADMINISTRACIÓN DE PRODUCTOS";
            // 
            // btnSalirClientes
            // 
            this.btnSalirClientes.Location = new System.Drawing.Point(631, 294);
            this.btnSalirClientes.Name = "btnSalirClientes";
            this.btnSalirClientes.Size = new System.Drawing.Size(75, 23);
            this.btnSalirClientes.TabIndex = 17;
            this.btnSalirClientes.Text = "SALIR";
            this.btnSalirClientes.UseVisualStyleBackColor = true;
            this.btnSalirClientes.Click += new System.EventHandler(this.btnSalirClientes_Click);
            // 
            // btnProdEditar
            // 
            this.btnProdEditar.Location = new System.Drawing.Point(631, 198);
            this.btnProdEditar.Name = "btnProdEditar";
            this.btnProdEditar.Size = new System.Drawing.Size(75, 23);
            this.btnProdEditar.TabIndex = 16;
            this.btnProdEditar.Text = "Editar";
            this.btnProdEditar.UseVisualStyleBackColor = true;
            this.btnProdEditar.Click += new System.EventHandler(this.btnProdEditar_Click_1);
            // 
            // btnBorrarProd
            // 
            this.btnBorrarProd.Location = new System.Drawing.Point(631, 227);
            this.btnBorrarProd.Name = "btnBorrarProd";
            this.btnBorrarProd.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarProd.TabIndex = 15;
            this.btnBorrarProd.Text = "Borrar";
            this.btnBorrarProd.UseVisualStyleBackColor = true;
            this.btnBorrarProd.Click += new System.EventHandler(this.btnBorrarProd_Click_1);
            // 
            // bntAñadirCliente
            // 
            this.bntAñadirCliente.Location = new System.Drawing.Point(631, 140);
            this.bntAñadirCliente.Name = "bntAñadirCliente";
            this.bntAñadirCliente.Size = new System.Drawing.Size(75, 23);
            this.bntAñadirCliente.TabIndex = 14;
            this.bntAñadirCliente.Text = "Añadir";
            this.bntAñadirCliente.UseVisualStyleBackColor = true;
            this.bntAñadirCliente.Click += new System.EventHandler(this.bntAñadirCliente_Click);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(116, 160);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(89, 22);
            this.txtIdProducto.TabIndex = 18;
            this.txtIdProducto.Text = "ID";
            this.txtIdProducto.Enter += new System.EventHandler(this.txtIdProducto_Enter);
            this.txtIdProducto.Leave += new System.EventHandler(this.txtIdProducto_Leave);
            // 
            // btnGuardarProd
            // 
            this.btnGuardarProd.Location = new System.Drawing.Point(631, 169);
            this.btnGuardarProd.Name = "btnGuardarProd";
            this.btnGuardarProd.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarProd.TabIndex = 19;
            this.btnGuardarProd.Text = "Guardar";
            this.btnGuardarProd.UseVisualStyleBackColor = true;
            this.btnGuardarProd.Click += new System.EventHandler(this.btnGuardarProd_Click_1);
            // 
            // dgProductos
            // 
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(116, 337);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.Size = new System.Drawing.Size(590, 182);
            this.dgProductos.TabIndex = 20;
            this.dgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellClick_1);
            this.dgProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProductos_CellContentClick_1);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(170)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(801, 556);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.btnGuardarProd);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.btnSalirClientes);
            this.Controls.Add(this.btnProdEditar);
            this.Controls.Add(this.btnBorrarProd);
            this.Controls.Add(this.bntAñadirCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTxtRutaImagen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTxtDetallesProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboCategoriaProd);
            this.Controls.Add(this.txtCantidadStock);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtCodigoRef);
            this.Controls.Add(this.txtNombreProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtCodigoRef;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtCantidadStock;
        private System.Windows.Forms.ComboBox cboCategoriaProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTxtDetallesProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTxtRutaImagen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalirClientes;
        private System.Windows.Forms.Button btnProdEditar;
        private System.Windows.Forms.Button btnBorrarProd;
        private System.Windows.Forms.Button bntAñadirCliente;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.Button btnGuardarProd;
        private System.Windows.Forms.DataGridView dgProductos;
    }
}