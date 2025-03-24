namespace Sistema.Presentacion
{
    partial class frmAlumnos
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
            this.dtpFechaFinaliza = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinaliza = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.txtEstado_Estudio = new System.Windows.Forms.TextBox();
            this.lblEstado_Estudio = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.txtAñosCarrera = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.txtNum_Id = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblAñosCarrera = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblNum_Id = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLetras = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblLetras2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.Erroricono = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Erroricono)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1224, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtpFechaFinaliza);
            this.tabPage1.Controls.Add(this.dtpFechaIngreso);
            this.tabPage1.Controls.Add(this.lblFechaFinaliza);
            this.tabPage1.Controls.Add(this.lblFechaIngreso);
            this.tabPage1.Controls.Add(this.txtEstado_Estudio);
            this.tabPage1.Controls.Add(this.lblEstado_Estudio);
            this.tabPage1.Controls.Add(this.btnActualizar);
            this.tabPage1.Controls.Add(this.btnInsertar);
            this.tabPage1.Controls.Add(this.txtPromedio);
            this.tabPage1.Controls.Add(this.txtAñosCarrera);
            this.tabPage1.Controls.Add(this.txtCarrera);
            this.tabPage1.Controls.Add(this.txtNum_Id);
            this.tabPage1.Controls.Add(this.txtApellido);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.lblPromedio);
            this.tabPage1.Controls.Add(this.lblAñosCarrera);
            this.tabPage1.Controls.Add(this.lblCarrera);
            this.tabPage1.Controls.Add(this.lblNum_Id);
            this.tabPage1.Controls.Add(this.lblApellido);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Controls.Add(this.lblLetras);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1216, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dtpFechaFinaliza
            // 
            this.dtpFechaFinaliza.Location = new System.Drawing.Point(208, 293);
            this.dtpFechaFinaliza.Name = "dtpFechaFinaliza";
            this.dtpFechaFinaliza.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaFinaliza.TabIndex = 21;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(208, 248);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaIngreso.TabIndex = 1;
            // 
            // lblFechaFinaliza
            // 
            this.lblFechaFinaliza.AutoSize = true;
            this.lblFechaFinaliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFinaliza.Location = new System.Drawing.Point(32, 293);
            this.lblFechaFinaliza.Name = "lblFechaFinaliza";
            this.lblFechaFinaliza.Size = new System.Drawing.Size(132, 20);
            this.lblFechaFinaliza.TabIndex = 18;
            this.lblFechaFinaliza.Text = "Fecha Finaliza";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIngreso.Location = new System.Drawing.Point(32, 250);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(128, 20);
            this.lblFechaIngreso.TabIndex = 17;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // txtEstado_Estudio
            // 
            this.txtEstado_Estudio.Location = new System.Drawing.Point(208, 203);
            this.txtEstado_Estudio.Name = "txtEstado_Estudio";
            this.txtEstado_Estudio.Size = new System.Drawing.Size(159, 22);
            this.txtEstado_Estudio.TabIndex = 16;
            // 
            // lblEstado_Estudio
            // 
            this.lblEstado_Estudio.AutoSize = true;
            this.lblEstado_Estudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado_Estudio.Location = new System.Drawing.Point(32, 203);
            this.lblEstado_Estudio.Name = "lblEstado_Estudio";
            this.lblEstado_Estudio.Size = new System.Drawing.Size(140, 20);
            this.lblEstado_Estudio.TabIndex = 15;
            this.lblEstado_Estudio.Text = "Estado_Estudio";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(454, 267);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(102, 46);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(454, 267);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(102, 46);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click_1);
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(208, 398);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(159, 22);
            this.txtPromedio.TabIndex = 11;
            // 
            // txtAñosCarrera
            // 
            this.txtAñosCarrera.Location = new System.Drawing.Point(208, 347);
            this.txtAñosCarrera.Name = "txtAñosCarrera";
            this.txtAñosCarrera.Size = new System.Drawing.Size(159, 22);
            this.txtAñosCarrera.TabIndex = 10;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(208, 153);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(159, 22);
            this.txtCarrera.TabIndex = 9;
            // 
            // txtNum_Id
            // 
            this.txtNum_Id.Location = new System.Drawing.Point(208, 107);
            this.txtNum_Id.Name = "txtNum_Id";
            this.txtNum_Id.Size = new System.Drawing.Size(159, 22);
            this.txtNum_Id.TabIndex = 8;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(208, 67);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(159, 22);
            this.txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(208, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(159, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(30, 400);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(88, 20);
            this.lblPromedio.TabIndex = 5;
            this.lblPromedio.Text = "Promedio";
            // 
            // lblAñosCarrera
            // 
            this.lblAñosCarrera.AutoSize = true;
            this.lblAñosCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñosCarrera.Location = new System.Drawing.Point(30, 347);
            this.lblAñosCarrera.Name = "lblAñosCarrera";
            this.lblAñosCarrera.Size = new System.Drawing.Size(121, 20);
            this.lblAñosCarrera.TabIndex = 4;
            this.lblAñosCarrera.Text = "Años Carrera";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrera.Location = new System.Drawing.Point(32, 155);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(73, 20);
            this.lblCarrera.TabIndex = 3;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblNum_Id
            // 
            this.lblNum_Id.AutoSize = true;
            this.lblNum_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum_Id.Location = new System.Drawing.Point(32, 109);
            this.lblNum_Id.Name = "lblNum_Id";
            this.lblNum_Id.Size = new System.Drawing.Size(72, 20);
            this.lblNum_Id.TabIndex = 2;
            this.lblNum_Id.Text = "Num_Id";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(30, 67);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(76, 20);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(32, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(74, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblLetras
            // 
            this.lblLetras.AutoSize = true;
            this.lblLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetras.Location = new System.Drawing.Point(384, 27);
            this.lblLetras.Name = "lblLetras";
            this.lblLetras.Size = new System.Drawing.Size(19, 20);
            this.lblLetras.TabIndex = 12;
            this.lblLetras.Text = "0";
            this.lblLetras.Click += new System.EventHandler(this.lblLetras_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dgvListado);
            this.tabPage2.Controls.Add(this.lblLetras2);
            this.tabPage2.Controls.Add(this.txtBuscar);
            this.tabPage2.Controls.Add(this.lblBuscar);
            this.tabPage2.Controls.Add(this.lblTotal);
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1216, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "(*Realizar busqueda con id*)";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToOrderColumns = true;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.dgvListado.Location = new System.Drawing.Point(20, 104);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.RowTemplate.Height = 24;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(908, 317);
            this.dgvListado.TabIndex = 5;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            this.dgvListado.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccionar.Width = 125;
            // 
            // lblLetras2
            // 
            this.lblLetras2.AutoSize = true;
            this.lblLetras2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetras2.Location = new System.Drawing.Point(393, 31);
            this.lblLetras2.Name = "lblLetras2";
            this.lblLetras2.Size = new System.Drawing.Size(19, 20);
            this.lblLetras2.TabIndex = 4;
            this.lblLetras2.Text = "0";
            this.lblLetras2.Click += new System.EventHandler(this.lblLetras2_Click_1);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(146, 29);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(209, 22);
            this.txtBuscar.TabIndex = 3;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(58, 29);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(69, 20);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(361, 434);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(62, 427);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 27);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // Erroricono
            // 
            this.Erroricono.ContainerControl = this;
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 634);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmAlumnos";
            this.Text = "frmAlumnos";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Erroricono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtNum_Id;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblAñosCarrera;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblNum_Id;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtAñosCarrera;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ErrorProvider Erroricono;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstado_Estudio;
        private System.Windows.Forms.Label lblFechaFinaliza;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaFinaliza;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.TextBox txtEstado_Estudio;
        private System.Windows.Forms.Label lblLetras;
        private System.Windows.Forms.Label lblLetras2;
    }
}