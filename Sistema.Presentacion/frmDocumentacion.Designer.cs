namespace Sistema.Presentacion
{
    partial class frmDocumentacion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnActualizarDocumentacion = new System.Windows.Forms.Button();
            this.btnInsertarDocumentacion = new System.Windows.Forms.Button();
            this.dtpFecha_Entrega = new System.Windows.Forms.DateTimePicker();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtTipo_Docuemento = new System.Windows.Forms.TextBox();
            this.txtId_Beca = new System.Windows.Forms.TextBox();
            this.txtId_Documentacion = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFecha_Entrega = new System.Windows.Forms.Label();
            this.lblTipo_Documento = new System.Windows.Forms.Label();
            this.lblId_Beca = new System.Windows.Forms.Label();
            this.lblId_Documentacion = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTotalDocumentacion = new System.Windows.Forms.Label();
            this.btnEliminarDocumentacion = new System.Windows.Forms.Button();
            this.dgvListadoDocumentacion = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.Erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDocumentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Erroricono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 507);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnActualizarDocumentacion);
            this.tabPage1.Controls.Add(this.btnInsertarDocumentacion);
            this.tabPage1.Controls.Add(this.dtpFecha_Entrega);
            this.tabPage1.Controls.Add(this.txtEstado);
            this.tabPage1.Controls.Add(this.txtTipo_Docuemento);
            this.tabPage1.Controls.Add(this.txtId_Beca);
            this.tabPage1.Controls.Add(this.txtId_Documentacion);
            this.tabPage1.Controls.Add(this.lblEstado);
            this.tabPage1.Controls.Add(this.lblFecha_Entrega);
            this.tabPage1.Controls.Add(this.lblTipo_Documento);
            this.tabPage1.Controls.Add(this.lblId_Beca);
            this.tabPage1.Controls.Add(this.lblId_Documentacion);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1013, 478);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnActualizarDocumentacion
            // 
            this.btnActualizarDocumentacion.Location = new System.Drawing.Point(479, 163);
            this.btnActualizarDocumentacion.Name = "btnActualizarDocumentacion";
            this.btnActualizarDocumentacion.Size = new System.Drawing.Size(73, 34);
            this.btnActualizarDocumentacion.TabIndex = 12;
            this.btnActualizarDocumentacion.Text = "Actualizar";
            this.btnActualizarDocumentacion.UseVisualStyleBackColor = true;
            this.btnActualizarDocumentacion.Click += new System.EventHandler(this.btnActualizarDocumentacion_Click);
            // 
            // btnInsertarDocumentacion
            // 
            this.btnInsertarDocumentacion.Location = new System.Drawing.Point(479, 117);
            this.btnInsertarDocumentacion.Name = "btnInsertarDocumentacion";
            this.btnInsertarDocumentacion.Size = new System.Drawing.Size(73, 34);
            this.btnInsertarDocumentacion.TabIndex = 11;
            this.btnInsertarDocumentacion.Text = "Insertar";
            this.btnInsertarDocumentacion.UseVisualStyleBackColor = true;
            this.btnInsertarDocumentacion.Click += new System.EventHandler(this.btnInsertarDocumentacion_Click);
            // 
            // dtpFecha_Entrega
            // 
            this.dtpFecha_Entrega.Location = new System.Drawing.Point(263, 235);
            this.dtpFecha_Entrega.Name = "dtpFecha_Entrega";
            this.dtpFecha_Entrega.Size = new System.Drawing.Size(115, 22);
            this.dtpFecha_Entrega.TabIndex = 10;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(263, 297);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(167, 22);
            this.txtEstado.TabIndex = 9;
            // 
            // txtTipo_Docuemento
            // 
            this.txtTipo_Docuemento.Location = new System.Drawing.Point(263, 166);
            this.txtTipo_Docuemento.Name = "txtTipo_Docuemento";
            this.txtTipo_Docuemento.Size = new System.Drawing.Size(167, 22);
            this.txtTipo_Docuemento.TabIndex = 7;
            // 
            // txtId_Beca
            // 
            this.txtId_Beca.Location = new System.Drawing.Point(263, 105);
            this.txtId_Beca.Name = "txtId_Beca";
            this.txtId_Beca.Size = new System.Drawing.Size(167, 22);
            this.txtId_Beca.TabIndex = 6;
            // 
            // txtId_Documentacion
            // 
            this.txtId_Documentacion.Location = new System.Drawing.Point(263, 40);
            this.txtId_Documentacion.Name = "txtId_Documentacion";
            this.txtId_Documentacion.Size = new System.Drawing.Size(167, 22);
            this.txtId_Documentacion.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(52, 297);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(73, 16);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "lblEstado";
            // 
            // lblFecha_Entrega
            // 
            this.lblFecha_Entrega.AutoSize = true;
            this.lblFecha_Entrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha_Entrega.Location = new System.Drawing.Point(52, 235);
            this.lblFecha_Entrega.Name = "lblFecha_Entrega";
            this.lblFecha_Entrega.Size = new System.Drawing.Size(112, 16);
            this.lblFecha_Entrega.TabIndex = 3;
            this.lblFecha_Entrega.Text = "Fecha_Entrega";
            // 
            // lblTipo_Documento
            // 
            this.lblTipo_Documento.AutoSize = true;
            this.lblTipo_Documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo_Documento.Location = new System.Drawing.Point(52, 172);
            this.lblTipo_Documento.Name = "lblTipo_Documento";
            this.lblTipo_Documento.Size = new System.Drawing.Size(125, 16);
            this.lblTipo_Documento.TabIndex = 2;
            this.lblTipo_Documento.Text = "Tipo_Documento";
            // 
            // lblId_Beca
            // 
            this.lblId_Beca.AutoSize = true;
            this.lblId_Beca.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_Beca.Location = new System.Drawing.Point(52, 105);
            this.lblId_Beca.Name = "lblId_Beca";
            this.lblId_Beca.Size = new System.Drawing.Size(64, 16);
            this.lblId_Beca.TabIndex = 1;
            this.lblId_Beca.Text = "Id_Beca";
            // 
            // lblId_Documentacion
            // 
            this.lblId_Documentacion.AutoSize = true;
            this.lblId_Documentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_Documentacion.Location = new System.Drawing.Point(52, 40);
            this.lblId_Documentacion.Name = "lblId_Documentacion";
            this.lblId_Documentacion.Size = new System.Drawing.Size(135, 16);
            this.lblId_Documentacion.TabIndex = 0;
            this.lblId_Documentacion.Text = "Id_Documentacion";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTotalDocumentacion);
            this.tabPage2.Controls.Add(this.btnEliminarDocumentacion);
            this.tabPage2.Controls.Add(this.dgvListadoDocumentacion);
            this.tabPage2.Controls.Add(this.txtBuscar);
            this.tabPage2.Controls.Add(this.lblBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1013, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTotalDocumentacion
            // 
            this.lblTotalDocumentacion.AutoSize = true;
            this.lblTotalDocumentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDocumentacion.Location = new System.Drawing.Point(305, 418);
            this.lblTotalDocumentacion.Name = "lblTotalDocumentacion";
            this.lblTotalDocumentacion.Size = new System.Drawing.Size(43, 16);
            this.lblTotalDocumentacion.TabIndex = 3;
            this.lblTotalDocumentacion.Text = "Total";
            // 
            // btnEliminarDocumentacion
            // 
            this.btnEliminarDocumentacion.Location = new System.Drawing.Point(85, 410);
            this.btnEliminarDocumentacion.Name = "btnEliminarDocumentacion";
            this.btnEliminarDocumentacion.Size = new System.Drawing.Size(104, 32);
            this.btnEliminarDocumentacion.TabIndex = 1;
            this.btnEliminarDocumentacion.Text = "Eliminar";
            this.btnEliminarDocumentacion.UseVisualStyleBackColor = true;
            this.btnEliminarDocumentacion.Click += new System.EventHandler(this.btnEliminarDocumentacion_Click);
            // 
            // dgvListadoDocumentacion
            // 
            this.dgvListadoDocumentacion.AllowUserToAddRows = false;
            this.dgvListadoDocumentacion.AllowUserToDeleteRows = false;
            this.dgvListadoDocumentacion.AllowUserToOrderColumns = true;
            this.dgvListadoDocumentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDocumentacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvListadoDocumentacion.Location = new System.Drawing.Point(49, 73);
            this.dgvListadoDocumentacion.Name = "dgvListadoDocumentacion";
            this.dgvListadoDocumentacion.ReadOnly = true;
            this.dgvListadoDocumentacion.RowHeadersWidth = 51;
            this.dgvListadoDocumentacion.RowTemplate.Height = 24;
            this.dgvListadoDocumentacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoDocumentacion.Size = new System.Drawing.Size(912, 331);
            this.dgvListadoDocumentacion.TabIndex = 2;
            this.dgvListadoDocumentacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoDocumentacion_CellContentClick);
            this.dgvListadoDocumentacion.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoDocumentacion_CellContentDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(107, 32);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(128, 22);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(46, 32);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(55, 16);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar";
            // 
            // Erroricono
            // 
            this.Erroricono.ContainerControl = this;
            // 
            // frmDocumentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 608);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmDocumentacion";
            this.Text = "frmDocumentacion";
            this.Load += new System.EventHandler(this.frmDocumentacion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDocumentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Erroricono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblId_Documentacion;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtTipo_Docuemento;
        private System.Windows.Forms.TextBox txtId_Beca;
        private System.Windows.Forms.TextBox txtId_Documentacion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFecha_Entrega;
        private System.Windows.Forms.Label lblTipo_Documento;
        private System.Windows.Forms.Label lblId_Beca;
        private System.Windows.Forms.DataGridView dgvListadoDocumentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seleccionar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblTotalDocumentacion;
        private System.Windows.Forms.Button btnEliminarDocumentacion;
        private System.Windows.Forms.DateTimePicker dtpFecha_Entrega;
        private System.Windows.Forms.ErrorProvider Erroricono;
        private System.Windows.Forms.Button btnInsertarDocumentacion;
        private System.Windows.Forms.Button btnActualizarDocumentacion;
    }
}