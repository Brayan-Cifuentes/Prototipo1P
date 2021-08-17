namespace Protoripo1P
{
    partial class Inventario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.lblIdBodega = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtIdInventario = new System.Windows.Forms.TextBox();
            this.lblInventario = new System.Windows.Forms.Label();
            this.cbxIdBodega = new System.Windows.Forms.ComboBox();
            this.cbxIdProducto = new System.Windows.Forms.ComboBox();
            this.ordenExistenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csInventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csInventarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(364, 88);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(107, 13);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar ID Inventario:";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(55, 275);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Location = new System.Drawing.Point(55, 183);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(67, 13);
            this.lblCodigoProducto.TabIndex = 7;
            this.lblCodigoProducto.Text = "ID Producto:";
            // 
            // lblIdBodega
            // 
            this.lblIdBodega.AutoSize = true;
            this.lblIdBodega.Location = new System.Drawing.Point(55, 144);
            this.lblIdBodega.Name = "lblIdBodega";
            this.lblIdBodega.Size = new System.Drawing.Size(61, 13);
            this.lblIdBodega.TabIndex = 9;
            this.lblIdBodega.Text = "ID Bodega:";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(146, 225);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(100, 20);
            this.txtExistencia.TabIndex = 12;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(55, 225);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(58, 13);
            this.lblcantidad.TabIndex = 11;
            this.lblcantidad.Text = "Existencia:";
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(359, 321);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(112, 23);
            this.btnLlenar.TabIndex = 13;
            this.btnLlenar.Text = "Llenar Campos";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(146, 275);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(488, 88);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(184, 20);
            this.txtBuscar.TabIndex = 15;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(55, 321);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 16;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoGenerateColumns = false;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordenExistenciaDataGridViewTextBoxColumn,
            this.codigoBodegaDataGridViewTextBoxColumn,
            this.codigoProductoDataGridViewTextBoxColumn,
            this.existenciaDataGridViewTextBoxColumn});
            this.dgvDatos.DataSource = this.csInventarioBindingSource;
            this.dgvDatos.Location = new System.Drawing.Point(360, 125);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(102)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatos.RowHeadersWidth = 45;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(102)))), ((int)(((byte)(107)))));
            this.dgvDatos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatos.Size = new System.Drawing.Size(393, 173);
            this.dgvDatos.TabIndex = 25;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBodega_CellContentClick);
            // 
            // txtIdInventario
            // 
            this.txtIdInventario.Location = new System.Drawing.Point(146, 102);
            this.txtIdInventario.Name = "txtIdInventario";
            this.txtIdInventario.Size = new System.Drawing.Size(44, 20);
            this.txtIdInventario.TabIndex = 1;
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Location = new System.Drawing.Point(55, 105);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(53, 13);
            this.lblInventario.TabIndex = 5;
            this.lblInventario.Text = "ID Orden:";
            // 
            // cbxIdBodega
            // 
            this.cbxIdBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdBodega.FormattingEnabled = true;
            this.cbxIdBodega.Location = new System.Drawing.Point(146, 141);
            this.cbxIdBodega.Name = "cbxIdBodega";
            this.cbxIdBodega.Size = new System.Drawing.Size(121, 21);
            this.cbxIdBodega.TabIndex = 26;
            // 
            // cbxIdProducto
            // 
            this.cbxIdProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdProducto.FormattingEnabled = true;
            this.cbxIdProducto.Location = new System.Drawing.Point(146, 183);
            this.cbxIdProducto.Name = "cbxIdProducto";
            this.cbxIdProducto.Size = new System.Drawing.Size(121, 21);
            this.cbxIdProducto.TabIndex = 27;
            // 
            // ordenExistenciaDataGridViewTextBoxColumn
            // 
            this.ordenExistenciaDataGridViewTextBoxColumn.DataPropertyName = "OrdenExistencia";
            this.ordenExistenciaDataGridViewTextBoxColumn.HeaderText = "OrdenExistencia";
            this.ordenExistenciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ordenExistenciaDataGridViewTextBoxColumn.Name = "ordenExistenciaDataGridViewTextBoxColumn";
            this.ordenExistenciaDataGridViewTextBoxColumn.Width = 115;
            // 
            // codigoBodegaDataGridViewTextBoxColumn
            // 
            this.codigoBodegaDataGridViewTextBoxColumn.DataPropertyName = "CodigoBodega";
            this.codigoBodegaDataGridViewTextBoxColumn.HeaderText = "CodigoBodega";
            this.codigoBodegaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoBodegaDataGridViewTextBoxColumn.Name = "codigoBodegaDataGridViewTextBoxColumn";
            this.codigoBodegaDataGridViewTextBoxColumn.Width = 115;
            // 
            // codigoProductoDataGridViewTextBoxColumn
            // 
            this.codigoProductoDataGridViewTextBoxColumn.DataPropertyName = "CodigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.HeaderText = "CodigoProducto";
            this.codigoProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codigoProductoDataGridViewTextBoxColumn.Name = "codigoProductoDataGridViewTextBoxColumn";
            this.codigoProductoDataGridViewTextBoxColumn.Width = 115;
            // 
            // existenciaDataGridViewTextBoxColumn
            // 
            this.existenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia";
            this.existenciaDataGridViewTextBoxColumn.HeaderText = "Existencia";
            this.existenciaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.existenciaDataGridViewTextBoxColumn.Name = "existenciaDataGridViewTextBoxColumn";
            this.existenciaDataGridViewTextBoxColumn.Width = 115;
            // 
            // csInventarioBindingSource
            // 
            this.csInventarioBindingSource.DataSource = typeof(Protoripo1P.Clases.csInventario);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(678, 83);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 373);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxIdProducto);
            this.Controls.Add(this.cbxIdBodega);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnLlenar);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.lblIdBodega);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtIdInventario);
            this.Controls.Add(this.label1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csInventarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Label lblIdBodega;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Button btnLlenar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtIdInventario;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.ComboBox cbxIdBodega;
        private System.Windows.Forms.ComboBox cbxIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenExistenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBodegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource csInventarioBindingSource;
        private System.Windows.Forms.Button btnBuscar;
    }
}