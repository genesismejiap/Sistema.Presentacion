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
    public partial class frmAlumnos : Form
    {
        private string NombreAnt;

        public frmAlumnos()
        {
            InitializeComponent();
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            txtNombre.TextChanged += txtNombre_TextChanged;
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Value = DateTime.Now;

            dtpFechaFinaliza.Format = DateTimePickerFormat.Short;
            dtpFechaFinaliza.Value = DateTime.Now;
        }

        private void Listar()
        {
            try
            {
                dgvListado.DataSource = NCategoriaAlumnos.Listar();
                lblTotal.Text = "Total Registros: " + Convert.ToString(dgvListado.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            int letras = txtNombre.TextLength;
            lblLetras2.Text = letras.ToString();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvListado.Rows[e.RowIndex].Cells["seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.Columns.Contains("Num_Id"))
                txtNum_Id.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Num_Id"].Value);

            if (dgvListado.Columns.Contains("Nombre"))
                this.NombreAnt = Convert.ToString(dgvListado.CurrentRow.Cells["Nombre"].Value);
            txtNombre.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Nombre"].Value);

            if (dgvListado.Columns.Contains("Apellido"))
                txtApellido.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Apellido"].Value);

            if (dgvListado.Columns.Contains("Carrera"))
                txtCarrera.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Carrera"].Value);

            if (dgvListado.Columns.Contains("Estado_Estudio"))
                txtEstado_Estudio.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Estado_Estudio"].Value);

            if (dgvListado.Columns.Contains("FechaIngreso"))
            {
                var fechaIngreso = dgvListado.CurrentRow.Cells["FechaIngreso"].Value;
                if (fechaIngreso != DBNull.Value)
                    dtpFechaIngreso.Value = Convert.ToDateTime(fechaIngreso);
            }

            if (dgvListado.Columns.Contains("FechaFinaliza"))
            {
                var fechaFinaliza = dgvListado.CurrentRow.Cells["FechaFinaliza"].Value;
                if (fechaFinaliza != DBNull.Value)
                    dtpFechaFinaliza.Value = Convert.ToDateTime(fechaFinaliza);
            }

            if (dgvListado.Columns.Contains("Años Carrera"))
                txtAñosCarrera.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Años Carrera"].Value);

            if (dgvListado.Columns.Contains("Promedio"))
                txtPromedio.Text = Convert.ToString(dgvListado.CurrentRow.Cells["Promedio"].Value);

            btnActualizar.Visible = true;
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            this.Listar();
            btnActualizar.Visible = false;

            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Value = DateTime.Now;

            dtpFechaFinaliza.Format = DateTimePickerFormat.Short;
            dtpFechaFinaliza.Value = DateTime.Now;
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
            txtApellido.Clear();
            txtNombre.Clear();
            txtNum_Id.Clear();
            txtCarrera.Clear();
            txtEstado_Estudio.Clear();
            txtAñosCarrera.Clear();
            txtPromedio.Clear();
            Erroricono.Clear();
        }

        private void Buscar()
        {
            try
            {
                dgvListado.DataSource = NCategoriaAlumnos.Buscar(txtBuscar.Text);
                lblTotal.Text = "Total Registro: " + Convert.ToString(dgvListado.Rows.Count); //actualizar listado de cuantos hay
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvListado_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListado.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvListado.Rows[e.RowIndex].Cells["Seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    this.MensajeError("Falta ingresar el nombre. El campo será remarcado.");
                    Erroricono.SetError(txtNombre, "Ingrese un nombre de categoría");
                    txtNombre.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    this.MensajeError("Falta ingresar el apellido. El campo será remarcado.");
                    Erroricono.SetError(txtApellido, "Ingrese un apellido");
                    txtApellido.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNum_Id.Text))
                {
                    this.MensajeError("Falta ingresar el número de identificación. El campo será remarcado.");
                    Erroricono.SetError(txtNum_Id, "Ingrese un número de identificación");
                    txtNum_Id.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCarrera.Text))
                {
                    this.MensajeError("Falta ingresar la carrera. El campo será remarcado.");
                    Erroricono.SetError(txtCarrera, "Ingrese una carrera");
                    txtCarrera.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEstado_Estudio.Text))
                {
                    this.MensajeError("Falta ingresar el estado de estudio. El campo será remarcado.");
                    Erroricono.SetError(txtEstado_Estudio, "Ingrese un estado de estudio");
                    txtEstado_Estudio.Select();
                    return;
                }

                DateTime fechaIngreso = dtpFechaIngreso.Value;
                DateTime fechaFinaliza = dtpFechaFinaliza.Value;

                if (string.IsNullOrWhiteSpace(txtAñosCarrera.Text) || !int.TryParse(txtAñosCarrera.Text.Trim(), out int añosCarrera))
                {
                    this.MensajeError("El campo Años de Carrera debe ser un número válido.");
                    Erroricono.SetError(txtAñosCarrera, "Ingrese un número válido para Años de Carrera");
                    txtAñosCarrera.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPromedio.Text) || !decimal.TryParse(txtPromedio.Text.Trim(), out decimal promedio))
                {
                    this.MensajeError("El campo Promedio debe ser un número válido.");
                    Erroricono.SetError(txtPromedio, "Ingrese un número válido para Promedio");
                    txtPromedio.Select();
                    return;
                }

                Resp = NCategoriaAlumnos.Insertar(
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim(),
                    txtNum_Id.Text.Trim(),
                    txtCarrera.Text.Trim(),
                    txtEstado_Estudio.Text.Trim(),
                    añosCarrera,
                    promedio,
                    fechaIngreso,
                    fechaFinaliza
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

        private void lblLetras_Click_1(object sender, EventArgs e)
        {
            int letras = txtBuscar.TextLength;
            lblLetras.Text = letras.ToString();
        }

        private void lblLetras2_Click_1(object sender, EventArgs e)
        {
            int letras = txtNombre.TextLength;
            lblLetras2.Text = letras.ToString();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
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
                    foreach (DataGridViewRow row in dgvListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NCategoriaAlumnos.Eliminar(Codigo);

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

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    this.MensajeError("Falta ingresar el nombre. El campo será remarcado.");
                    Erroricono.SetError(txtNombre, "Ingrese un nombre de categoría");
                    txtNombre.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    this.MensajeError("Falta ingresar el apellido. El campo será remarcado.");
                    Erroricono.SetError(txtApellido, "Ingrese un apellido");
                    txtApellido.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNum_Id.Text))
                {
                    this.MensajeError("Falta ingresar el número de identificación. El campo será remarcado.");
                    Erroricono.SetError(txtNum_Id, "Ingrese un número de identificación");
                    txtNum_Id.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCarrera.Text))
                {
                    this.MensajeError("Falta ingresar la carrera. El campo será remarcado.");
                    Erroricono.SetError(txtCarrera, "Ingrese una carrera");
                    txtCarrera.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtEstado_Estudio.Text))
                {
                    this.MensajeError("Falta ingresar el estado de estudio. El campo será remarcado.");
                    Erroricono.SetError(txtEstado_Estudio, "Ingrese un estado de estudio");
                    txtEstado_Estudio.Select();
                    return;
                }

                DateTime fechaIngreso = dtpFechaIngreso.Value;
                DateTime fechaFinaliza = dtpFechaFinaliza.Value;

                if (string.IsNullOrWhiteSpace(txtAñosCarrera.Text) || !int.TryParse(txtAñosCarrera.Text.Trim(), out int añosCarrera))
                {
                    this.MensajeError("El campo Años de Carrera debe ser un número válido.");
                    Erroricono.SetError(txtAñosCarrera, "Ingrese un número válido para Años de Carrera");
                    txtAñosCarrera.Select();
                    return;
                }

                if (añosCarrera < int.MinValue || añosCarrera > int.MaxValue)
                {
                    this.MensajeError("El valor de Años de Carrera está fuera de rango.");
                    Erroricono.SetError(txtAñosCarrera, "Ingrese un número dentro del rango válido para Años de Carrera");
                    txtAñosCarrera.Select();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPromedio.Text) || !int.TryParse(txtPromedio.Text.Trim(), out int promedio))
                {
                    this.MensajeError("El campo Promedio debe ser un número válido.");
                    Erroricono.SetError(txtPromedio, "Ingrese un número válido para Promedio");
                    txtPromedio.Select();
                    return;
                }

                if (promedio < int.MinValue || promedio > int.MaxValue)
                {
                    this.MensajeError("El valor de Promedio está fuera de rango.");
                    Erroricono.SetError(txtPromedio, "Ingrese un número dentro del rango válido para Promedio");
                    txtPromedio.Select();
                    return;
                }

                if (!int.TryParse(txtNum_Id.Text.Trim(), out int numId))
                {
                    this.MensajeError("El campo Número de Identificación debe ser un número válido.");
                    Erroricono.SetError(txtNum_Id, "Ingrese un número válido para Número de Identificación");
                    txtNum_Id.Select();
                    return;
                }

                Resp = NCategoriaAlumnos.Actualizar(
                    numId,
                    this.NombreAnt,
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim(),
                    txtNum_Id.Text.Trim(),
                    txtCarrera.Text.Trim(),
                    txtEstado_Estudio.Text.Trim(),
                    añosCarrera,
                    promedio,
                    fechaIngreso,
                    fechaFinaliza
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





        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
