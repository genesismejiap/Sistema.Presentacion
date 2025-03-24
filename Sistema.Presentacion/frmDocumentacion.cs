using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Negocio;

namespace Sistema.Presentacion
{
    public partial class frmDocumentacion : Form
    {
        public frmDocumentacion()
        {
            InitializeComponent();
            dtpFecha_Entrega.Format = DateTimePickerFormat.Short;
            dtpFecha_Entrega.Value = DateTime.Now;
        }

        private void Listar()
        {
            try
            {
                dgvListadoDocumentacion.DataSource = NCategoriaDocumentacion.Listar();
                lblTotalDocumentacion.Text = "Total Registros: " + Convert.ToString(dgvListadoDocumentacion.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvListadoDocumentacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListadoDocumentacion.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvListadoDocumentacion.Rows[e.RowIndex].Cells["seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dgvListadoDocumentacion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListadoDocumentacion.Columns.Contains("Id_Documentacion"))
                txtId_Documentacion.Text = Convert.ToString(dgvListadoDocumentacion.CurrentRow.Cells["Id_Documentacion"].Value);

            if (dgvListadoDocumentacion.Columns.Contains("Id_Beca"))
                txtId_Beca.Text = Convert.ToString(dgvListadoDocumentacion.CurrentRow.Cells["Id_Beca"].Value);

            if (dgvListadoDocumentacion.Columns.Contains("Tipo_Documento"))
                txtTipo_Docuemento.Text = Convert.ToString(dgvListadoDocumentacion.CurrentRow.Cells["Tipo_Documento"].Value);

            if (dgvListadoDocumentacion.Columns.Contains("Fecha_Entrega"))
            {
                var Fecha_Entrega = dgvListadoDocumentacion.CurrentRow.Cells["Fecha_Entrega"].Value;
                if (Fecha_Entrega != DBNull.Value)
                    dtpFecha_Entrega.Value = Convert.ToDateTime(Fecha_Entrega);
            }

            if (dgvListadoDocumentacion.Columns.Contains("Estado"))
                txtEstado.Text = Convert.ToString(dgvListadoDocumentacion.CurrentRow.Cells["Estado"].Value);

            btnActualizarDocumentacion.Visible = true;
        }

        private void frmDocumentacion_Load(object sender, EventArgs e)
        {
            this.Listar();
            btnActualizarDocumentacion.Visible = false;
            dtpFecha_Entrega.Format = DateTimePickerFormat.Short;
            dtpFecha_Entrega.Value = DateTime.Now;
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
            txtId_Documentacion.Clear();
            txtId_Beca.Clear();
            txtTipo_Docuemento.Clear();
            txtEstado.Clear();
            Erroricono.Clear();
        }

        private void Buscar()
        {
            try
            {
                dgvListadoDocumentacion.DataSource = NCategoriaDocumentacion.Buscar(txtBuscar.Text);
                lblTotalDocumentacion.Text = "Total Registro: " + Convert.ToString(dgvListadoDocumentacion.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnInsertarDocumentacion_Click(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";

                if (string.IsNullOrWhiteSpace(txtId_Documentacion.Text))
                {
                    this.MensajeError("Falta ingresar el Id documentacion. El campo será remarcado.");
                    Erroricono.SetError(txtId_Documentacion, "Ingrese un id de documentacion");
                    txtId_Documentacion.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtId_Beca.Text))
                {
                    this.MensajeError("Falta ingresar el Id beca. El campo será remarcado.");
                    Erroricono.SetError(txtId_Beca, "Ingrese un id Beca");
                    txtId_Beca.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTipo_Docuemento.Text))
                {
                    this.MensajeError("Falta ingresar el tipo de documento. El campo será remarcado.");
                    Erroricono.SetError(txtTipo_Docuemento, "Ingrese un Tipo de Documento");
                    txtTipo_Docuemento.Select();
                    return;
                }

                DateTime Fecha_Entrega = dtpFecha_Entrega.Value;

                if (string.IsNullOrWhiteSpace(txtEstado.Text))
                {
                    this.MensajeError("Falta ingresar el Estado. El campo será remarcado.");
                    Erroricono.SetError(txtEstado, "Ingrese el estado");
                    txtEstado.Select();
                    return;
                }

                Resp = NCategoriaDocumentacion.Insertar(
                    Convert.ToInt32(txtId_Beca.Text.Trim()),
                    txtTipo_Docuemento.Text.Trim(),
                    Fecha_Entrega,
                    txtEstado.Text.Trim()
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

        private void btnEliminarDocumentacion_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea eliminar el (los) registro(s)?",
                    "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in dgvListadoDocumentacion.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NCategoriaDocumentacion.Eliminar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActualizarDocumentacion_Click(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";

                if (string.IsNullOrWhiteSpace(txtId_Documentacion.Text))
                {
                    this.MensajeError("Falta ingresar el Id documentacion. El campo será remarcado.");
                    Erroricono.SetError(txtId_Documentacion, "Ingrese un id de documentacion");
                    txtId_Documentacion.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtId_Beca.Text))
                {
                    this.MensajeError("Falta ingresar el Id beca. El campo será remarcado.");
                    Erroricono.SetError(txtId_Beca, "Ingrese un id Beca");
                    txtId_Beca.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTipo_Docuemento.Text))
                {
                    this.MensajeError("Falta ingresar el tipo de documento. El campo será remarcado.");
                    Erroricono.SetError(txtTipo_Docuemento, "Ingrese un Tipo de Documento");
                    txtTipo_Docuemento.Select();
                    return;
                }

                DateTime Fecha_Entrega = dtpFecha_Entrega.Value;

                if (string.IsNullOrWhiteSpace(txtEstado.Text))
                {
                    this.MensajeError("Falta ingresar el Estado. El campo será remarcado.");
                    Erroricono.SetError(txtEstado, "Ingrese el estado");
                    txtEstado.Select();
                    return;
                }

                Resp = NCategoriaDocumentacion.Actualizar(
                    Convert.ToInt32(txtId_Documentacion.Text.Trim()),
                    Convert.ToInt32(txtId_Beca.Text.Trim()),
                    txtTipo_Docuemento.Text.Trim(),
                    Fecha_Entrega,
                    txtEstado.Text.Trim()
                );

                if (Resp.Equals("OK"))
                {
                    this.MensajeOk("El registro se actualizó exitosamente.");
                    this.Limpiar();
                    this.Listar();
                    btnInsertarDocumentacion.Visible = true;
                    btnActualizarDocumentacion.Visible = false;
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
    }
}
