namespace Sistema.Presentacion
{
    partial class frmPago
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblBuscarPago = new System.Windows.Forms.Label();
            this.txtBuscarPago = new System.Windows.Forms.TextBox();
            this.lblLetrasPago = new System.Windows.Forms.Label();
            this.dgvListadoPago = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarPago = new System.Windows.Forms.Button();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.lblIdAlumnoPago = new System.Windows.Forms.Label();
            this.txtIdAlumnoPago = new System.Windows.Forms.TextBox();
            this.lblLetras2Pago = new System.Windows.Forms.Label();
            this.lblFechaPago = new System.Windows.Forms.Label();
            this.lblMontoPago = new System.Windows.Forms.Label();
            this.lblEtiquetaPago = new System.Windows.Forms.Label();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.txtIdPago = new System.Windows.Forms.TextBox();
            this.txtMoraPago = new System.Windows.Forms.TextBox();
            this.lblMoraPago = new System.Windows.Forms.Label();
            this.btn_ActualizarPago = new System.Windows.Forms.Button();
            this.btn_InsertarPago = new System.Windows.Forms.Button();
            this.Erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPago)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(763, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTotalPago);
            this.tabPage1.Controls.Add(this.btnEliminarPago);
            this.tabPage1.Controls.Add(this.dgvListadoPago);
            this.tabPage1.Controls.Add(this.lblLetrasPago);
            this.tabPage1.Controls.Add(this.txtBuscarPago);
            this.tabPage1.Controls.Add(this.lblBuscarPago);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtpFechaPago);
            this.tabPage2.Controls.Add(this.btn_InsertarPago);
            this.tabPage2.Controls.Add(this.btn_ActualizarPago);
            this.tabPage2.Controls.Add(this.lblMoraPago);
            this.tabPage2.Controls.Add(this.txtMoraPago);
            this.tabPage2.Controls.Add(this.txtIdPago);
            this.tabPage2.Controls.Add(this.txtMontoPago);
            this.tabPage2.Controls.Add(this.lblEtiquetaPago);
            this.tabPage2.Controls.Add(this.lblMontoPago);
            this.tabPage2.Controls.Add(this.lblFechaPago);
            this.tabPage2.Controls.Add(this.lblLetras2Pago);
            this.tabPage2.Controls.Add(this.txtIdAlumnoPago);
            this.tabPage2.Controls.Add(this.lblIdAlumnoPago);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblBuscarPago
            // 
            this.lblBuscarPago.AutoSize = true;
            this.lblBuscarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPago.Location = new System.Drawing.Point(62, 38);
            this.lblBuscarPago.Name = "lblBuscarPago";
            this.lblBuscarPago.Size = new System.Drawing.Size(81, 20);
            this.lblBuscarPago.TabIndex = 0;
            this.lblBuscarPago.Text = "Buscar :";
            // 
            // txtBuscarPago
            // 
            this.txtBuscarPago.Location = new System.Drawing.Point(165, 36);
            this.txtBuscarPago.Name = "txtBuscarPago";
            this.txtBuscarPago.Size = new System.Drawing.Size(167, 22);
            this.txtBuscarPago.TabIndex = 1;
            this.txtBuscarPago.TextChanged += new System.EventHandler(this.txtBuscarPago_TextChanged);
            // 
            // lblLetrasPago
            // 
            this.lblLetrasPago.AutoSize = true;
            this.lblLetrasPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetrasPago.Location = new System.Drawing.Point(367, 38);
            this.lblLetrasPago.Name = "lblLetrasPago";
            this.lblLetrasPago.Size = new System.Drawing.Size(19, 20);
            this.lblLetrasPago.TabIndex = 2;
            this.lblLetrasPago.Text = "0";
            // 
            // dgvListadoPago
            // 
            this.dgvListadoPago.AllowUserToAddRows = false;
            this.dgvListadoPago.AllowUserToDeleteRows = false;
            this.dgvListadoPago.AllowUserToOrderColumns = true;
            this.dgvListadoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvListadoPago.Location = new System.Drawing.Point(15, 83);
            this.dgvListadoPago.Name = "dgvListadoPago";
            this.dgvListadoPago.ReadOnly = true;
            this.dgvListadoPago.RowHeadersWidth = 51;
            this.dgvListadoPago.RowTemplate.Height = 24;
            this.dgvListadoPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoPago.Size = new System.Drawing.Size(692, 267);
            this.dgvListadoPago.TabIndex = 3;
            this.dgvListadoPago.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoPago_CellContentClick);
            this.dgvListadoPago.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoPago_CellContentDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.Location = new System.Drawing.Point(66, 371);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(83, 29);
            this.btnEliminarPago.TabIndex = 4;
            this.btnEliminarPago.Text = "Eliminar";
            this.btnEliminarPago.UseVisualStyleBackColor = true;
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPago.Location = new System.Drawing.Point(367, 374);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(51, 20);
            this.lblTotalPago.TabIndex = 5;
            this.lblTotalPago.Text = "Total";
            // 
            // lblIdAlumnoPago
            // 
            this.lblIdAlumnoPago.AutoSize = true;
            this.lblIdAlumnoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAlumnoPago.Location = new System.Drawing.Point(26, 42);
            this.lblIdAlumnoPago.Name = "lblIdAlumnoPago";
            this.lblIdAlumnoPago.Size = new System.Drawing.Size(119, 20);
            this.lblIdAlumnoPago.TabIndex = 0;
            this.lblIdAlumnoPago.Text = "Id Alumno (*)";
            // 
            // txtIdAlumnoPago
            // 
            this.txtIdAlumnoPago.Location = new System.Drawing.Point(151, 42);
            this.txtIdAlumnoPago.Name = "txtIdAlumnoPago";
            this.txtIdAlumnoPago.Size = new System.Drawing.Size(145, 22);
            this.txtIdAlumnoPago.TabIndex = 1;
            this.txtIdAlumnoPago.TextChanged += new System.EventHandler(this.txtIdAlumnoPago_TextChanged);
            // 
            // lblLetras2Pago
            // 
            this.lblLetras2Pago.AutoSize = true;
            this.lblLetras2Pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetras2Pago.Location = new System.Drawing.Point(338, 44);
            this.lblLetras2Pago.Name = "lblLetras2Pago";
            this.lblLetras2Pago.Size = new System.Drawing.Size(19, 20);
            this.lblLetras2Pago.TabIndex = 2;
            this.lblLetras2Pago.Text = "0";
            this.lblLetras2Pago.Click += new System.EventHandler(this.lblLetras2Pago_Click);
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPago.Location = new System.Drawing.Point(26, 108);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(72, 20);
            this.lblFechaPago.TabIndex = 3;
            this.lblFechaPago.Text = "Fecha :";
            // 
            // lblMontoPago
            // 
            this.lblMontoPago.AutoSize = true;
            this.lblMontoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoPago.Location = new System.Drawing.Point(26, 181);
            this.lblMontoPago.Name = "lblMontoPago";
            this.lblMontoPago.Size = new System.Drawing.Size(72, 20);
            this.lblMontoPago.TabIndex = 4;
            this.lblMontoPago.Text = "Monto :";
            // 
            // lblEtiquetaPago
            // 
            this.lblEtiquetaPago.AutoSize = true;
            this.lblEtiquetaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiquetaPago.Location = new System.Drawing.Point(26, 250);
            this.lblEtiquetaPago.Name = "lblEtiquetaPago";
            this.lblEtiquetaPago.Size = new System.Drawing.Size(246, 20);
            this.lblEtiquetaPago.TabIndex = 5;
            this.lblEtiquetaPago.Text = "(*) Indica que es Obligatorio";
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Location = new System.Drawing.Point(113, 181);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Size = new System.Drawing.Size(139, 22);
            this.txtMontoPago.TabIndex = 6;
            // 
            // txtIdPago
            // 
            this.txtIdPago.Location = new System.Drawing.Point(381, 44);
            this.txtIdPago.Name = "txtIdPago";
            this.txtIdPago.Size = new System.Drawing.Size(82, 22);
            this.txtIdPago.TabIndex = 7;
            // 
            // txtMoraPago
            // 
            this.txtMoraPago.Location = new System.Drawing.Point(430, 181);
            this.txtMoraPago.Name = "txtMoraPago";
            this.txtMoraPago.Size = new System.Drawing.Size(94, 22);
            this.txtMoraPago.TabIndex = 8;
            // 
            // lblMoraPago
            // 
            this.lblMoraPago.AutoSize = true;
            this.lblMoraPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoraPago.Location = new System.Drawing.Point(338, 183);
            this.lblMoraPago.Name = "lblMoraPago";
            this.lblMoraPago.Size = new System.Drawing.Size(63, 20);
            this.lblMoraPago.TabIndex = 9;
            this.lblMoraPago.Text = "Mora :";
            // 
            // btn_ActualizarPago
            // 
            this.btn_ActualizarPago.Location = new System.Drawing.Point(337, 320);
            this.btn_ActualizarPago.Name = "btn_ActualizarPago";
            this.btn_ActualizarPago.Size = new System.Drawing.Size(103, 43);
            this.btn_ActualizarPago.TabIndex = 10;
            this.btn_ActualizarPago.Text = "Actualizar";
            this.btn_ActualizarPago.UseVisualStyleBackColor = true;
            this.btn_ActualizarPago.Click += new System.EventHandler(this.btn_ActualizarPago_Click);
            // 
            // btn_InsertarPago
            // 
            this.btn_InsertarPago.Location = new System.Drawing.Point(337, 250);
            this.btn_InsertarPago.Name = "btn_InsertarPago";
            this.btn_InsertarPago.Size = new System.Drawing.Size(103, 43);
            this.btn_InsertarPago.TabIndex = 11;
            this.btn_InsertarPago.Text = "Insertar";
            this.btn_InsertarPago.UseVisualStyleBackColor = true;
            this.btn_InsertarPago.Click += new System.EventHandler(this.btn_InsertarPago_Click);
            // 
            // Erroricono
            // 
            this.Erroricono.ContainerControl = this;
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.Location = new System.Drawing.Point(104, 108);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(122, 22);
            this.dtpFechaPago.TabIndex = 12;
            // 
            // frmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPago";
            this.Text = "frmPago";
            this.Load += new System.EventHandler(this.frmPago_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Erroricono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtBuscarPago;
        private System.Windows.Forms.Label lblBuscarPago;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvListadoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seleccionar;
        private System.Windows.Forms.Label lblLetrasPago;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.Button btnEliminarPago;
        private System.Windows.Forms.Label lblLetras2Pago;
        private System.Windows.Forms.TextBox txtIdAlumnoPago;
        private System.Windows.Forms.Label lblIdAlumnoPago;
        private System.Windows.Forms.Button btn_InsertarPago;
        private System.Windows.Forms.Button btn_ActualizarPago;
        private System.Windows.Forms.Label lblMoraPago;
        private System.Windows.Forms.TextBox txtMoraPago;
        private System.Windows.Forms.TextBox txtIdPago;
        private System.Windows.Forms.TextBox txtMontoPago;
        private System.Windows.Forms.Label lblEtiquetaPago;
        private System.Windows.Forms.Label lblMontoPago;
        private System.Windows.Forms.Label lblFechaPago;
        private System.Windows.Forms.ErrorProvider Erroricono;
        private System.Windows.Forms.DateTimePicker dtpFechaPago;
    }
}