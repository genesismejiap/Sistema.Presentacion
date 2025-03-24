using Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Presentacion
{
    public partial class frmBecas : Form
    {
        private string NombreAnt;
        public frmBecas()
        {
            InitializeComponent();
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            txtIdAlumno.TextChanged += txtIdAlumno_TextChanged;
            dgvListado.CellContentDoubleClick += dgvListado_CellContentDoubleClick;
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpiar()
        {
            txtIdAlumno.Clear();
            txtIdTipoBeca.Clear();
            txtMora_Beca.Clear();
            Erroricono.Clear();
        }

        private void Listar()
        {
            try
            {
                dgvListado.DataSource = NCategoriaBeca.Listar();
                lblTotal.Text = "Total Registros: " + Convert.ToString(dgvListado.Rows.Count);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Buscar()
        {
            try
            {
                dgvListado.DataSource = NCategoriaBeca.Buscar(txtBuscar.Text);
                lblTotal.Text = "Total Registro: " + Convert.ToString(dgvListado.Rows.Count); //actualizar listado de cuantos hay

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.Columns.Contains("Id_Alumno"))
                txtIdAlumno.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Id_Alumno"].Value);

            if (dgvListado.Columns.Contains("Id_TipoBeca"))
                txtIdTipoBeca.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Id_TipoBeca"].Value);

            if (dgvListado.Columns.Contains("Monto_Beca"))
                txtMora_Beca.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Monto_Beca"].Value);

            btnActualizar.Visible = true;
            btnInsertar.Visible = false;
        }

        private void frmBecas_Load(object sender, EventArgs e)
        {
            this.Listar();
            btnActualizar.Visible = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            int letras = txtBuscar.TextLength;
            lblLetras.Text = letras.ToString();
            if (letras == 0)
            {
                this.Listar();
            }
            else
            {
                this.Buscar();
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";
                if (string.IsNullOrWhiteSpace(txtIdAlumno.Text) || !int.TryParse(txtIdAlumno.Text.Trim(), out int Id_Alumno))
                {
                    this.MensajeError("Falta ingresar el id de alumno. El campo será remarcado.");
                    Erroricono.SetError(txtIdAlumno, "Ingrese un id de alumno de categoría");
                    txtIdAlumno.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtIdTipoBeca.Text) || !int.TryParse(txtIdTipoBeca.Text.Trim(), out int Id_TipoBeca))
                {
                    this.MensajeError("Falta ingresar el id de tipo de beca. El campo será remarcado.");
                    Erroricono.SetError(txtIdTipoBeca, "Ingrese un id de tipo de beca");
                    txtIdTipoBeca.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMora_Beca.Text) || !int.TryParse(txtMora_Beca.Text.Trim(), out int Mora_Beca))
                {
                    this.MensajeError("Falta ingresar la mora de la beca. El campo será remarcado.");
                    Erroricono.SetError(txtMora_Beca, "Ingrese la mora de la beca");
                    txtMora_Beca.Select();
                    return;
                }

                Resp = NCategoriaBeca.Actualizar(
                    Id_Alumno,
                    Id_TipoBeca,
                    Mora_Beca,
                    Mora_Beca,
                    txtIdTipoBeca.Text.Trim()
                );

                if (Resp.Equals("OK"))
                {
                    this.MensajeOk("El registro se actualizó exitosamente.");
                    this.Limpiar();
                    this.Listar();
                    btnInsertar.Visible = true;
                    btnActualizar.Visible = false;
                }
                else
                {
                    this.MensajeError("Ocurrió un error al actualizar el registro: " + Resp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";
                if (string.IsNullOrWhiteSpace(txtIdAlumno.Text) || !int.TryParse(txtIdAlumno.Text.Trim(), out int Id_Alumno))
                {
                    this.MensajeError("Falta ingresar el id de alumno. El campo será remarcado.");
                    Erroricono.SetError(txtIdAlumno, "Ingrese un id de alumno de categoría");
                    txtIdAlumno.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtIdTipoBeca.Text) || !int.TryParse(txtIdTipoBeca.Text.Trim(), out int Id_TipoBeca))
                {
                    this.MensajeError("Falta ingresar el id de tipo de beca. El campo será remarcado.");
                    Erroricono.SetError(txtIdTipoBeca, "Ingrese un id de tipo de beca");
                    txtIdTipoBeca.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMora_Beca.Text) || !int.TryParse(txtMora_Beca.Text.Trim(), out int Mora_Beca))
                {
                    this.MensajeError("Falta ingresar la mora de la beca. El campo será remarcado.");
                    Erroricono.SetError(txtMora_Beca, "Ingrese la mora de la beca");
                    txtMora_Beca.Select();
                    return;
                }

                Resp = NCategoriaBeca.Insertar(
                    Id_Alumno,
                    Id_TipoBeca,
                    Mora_Beca
                );

                if (Resp.Equals("OK"))
                {
                    this.MensajeOk("El registro se insertó exitosamente.");
                    this.Limpiar();
                    this.Listar();
                }
                else
                {
                    this.MensajeError("Ocurrió un error al insertar el registro: " + Resp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtIdAlumno_TextChanged(object sender, EventArgs e)
        {
            int letras = txtBuscar.TextLength;
            lblLetras.Text = letras.ToString();
            if (letras == 0)
            {
                this.Listar();
            }
            else
            {
                this.Buscar();
            }
        }
    }
}
