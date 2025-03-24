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
    public partial class frmPago : Form
    {
        private string IdAnt;
        public frmPago()
        {
            InitializeComponent();
            txtBuscarPago.TextChanged += txtBuscarPago_TextChanged;
            txtIdAlumnoPago.TextChanged += txtIdAlumnoPago_TextChanged;
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Value = DateTime.Now;
        }


        private void Listar()
        {
            try
            {
                dgvListadoPago.DataSource = NPago.Listar();
                lblTotalPago.Text = "Total Registros: " + Convert.ToString(dgvListadoPago.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void dgvListadoPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListadoPago.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)dgvListadoPago.Rows[e.RowIndex].Cells["seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void dgvListadoPago_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListadoPago.Columns.Contains("Id_Alumno"))
                txtIdAlumnoPago.Text = Convert.ToString(dgvListadoPago.CurrentRow.Cells["Id_Alumno"].Value);

            if (dgvListadoPago.Columns.Contains("FechaPago"))
            {
                var FechaPago = dgvListadoPago.CurrentRow.Cells["FechaPago"].Value;
                if (FechaPago != DBNull.Value)
                    dtpFechaPago.Value = Convert.ToDateTime(FechaPago);
            }
            if (dgvListadoPago.Columns.Contains("Monto"))
                txtMontoPago.Text = Convert.ToString(dgvListadoPago.CurrentRow.Cells["Monto"].Value);

            if (dgvListadoPago.Columns.Contains("Mora"))
                txtMoraPago.Text = Convert.ToString(dgvListadoPago.CurrentRow.Cells["Mora"].Value);

            btn_ActualizarPago.Visible = true;
            btn_InsertarPago.Visible = false;
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            this.Listar();
            btn_ActualizarPago.Visible = false;

            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Value = DateTime.Now;
        }

        private void txtIdAlumnoPago_TextChanged(object sender, EventArgs e)
        {
            int letras = txtIdAlumnoPago.TextLength;
            lblLetras2Pago.Text = letras.ToString();
        }


        //Método mensaje de error
        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Pagos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Método Mensaje OK
        private void MensajeOK(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Método Limpiar
        private void Limpiar()
        {
            txtIdAlumnoPago.Clear();
            txtIdPago.Clear();
            txtMontoPago.Clear();
            txtMoraPago.Clear();
            Erroricono.Clear();
        }

        //Método Buscar
        private void Buscar()
        {
            try
            {
                dgvListadoPago.DataSource = NPago.Buscar(txtBuscarPago.Text);
                lblTotalPago.Text = "Total Registro: " + Convert.ToString(dgvListadoPago.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }//Fin private void Buscar()

        private void btnEliminar_Click(object sender, EventArgs e)
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
                    foreach (DataGridViewRow row in dgvListadoPago.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NPago.Eliminar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se eliminó el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }//Fin de if
                    }//Fin de foreach
                    this.Listar();
                }//Fin del if
            }//Fin del try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }//Fin private void btnEliminar_Click(object sender, EventArgs e)

        private void txtBuscarPago_TextChanged(object sender, EventArgs e)
        {
            int letras = txtBuscarPago.TextLength;
            lblLetrasPago.Text = letras.ToString();

            if (letras == 0)
            {
                this.Listar();
            }
            else
            {
                this.Buscar();
            }
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Realmente desea eliminar el (los) registro(s)?",
                    "Sistema de Pagos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";
                    foreach (DataGridViewRow row in dgvListadoPago.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = NPago.Eliminar(Codigo);

                            if (Rpta.Equals("OK"))
                            {
                                this.MensajeOK("Se eliminó el registro: " + Convert.ToString(row.Cells[2].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);
                            }
                        }//Fin de if
                    }//Fin de foreach
                    this.Listar();
                }//Fin del if
            }//Fin del try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void lblLetras2Pago_Click(object sender, EventArgs e)
        {
            int letras = txtIdAlumnoPago.TextLength;
            lblLetras2Pago.Text = letras.ToString();
        }

        private void btn_ActualizarPago_Click(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";
                if (string.IsNullOrWhiteSpace(txtIdAlumnoPago.Text) || !int.TryParse(txtIdAlumnoPago.Text.Trim(), out int IdAlumnoPago))
                {
                    this.MensajeError("Falta ingresar un ID de alumno válido. El campo será remarcado.");
                    Erroricono.SetError(txtIdAlumnoPago, "Ingrese un ID de alumno válido");
                    txtIdAlumnoPago.Select();
                    return;
                }
                DateTime FechaPago = dtpFechaPago.Value;

                if (string.IsNullOrWhiteSpace(txtMontoPago.Text) || !decimal.TryParse(txtMontoPago.Text.Trim(), out decimal Monto))
                {
                    this.MensajeError("El campo Monto debe ser un número válido.");
                    Erroricono.SetError(txtMontoPago, "Ingrese un número válido para Monto");
                    txtMontoPago.Select();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMoraPago.Text) || !decimal.TryParse(txtMoraPago.Text.Trim(), out decimal Mora))
                {
                    this.MensajeError("El campo Mora debe ser un número válido.");
                    Erroricono.SetError(txtMoraPago, "Ingrese un número válido para Mora");
                    txtMoraPago.Select();
                    return;
                }

                Resp = NPago.Actualizar(
                    Convert.ToInt32(txtIdPago.Text), // Asegúrate de que Id_Pago esté siendo capturado correctamente
                    IdAlumnoPago,
                    FechaPago,
                    Monto,
                    Mora
                );
                if (Resp.Equals("OK"))
                {
                    this.MensajeOK("El registro se actualizó exitosamente.");
                    this.Limpiar();
                    this.Listar();
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

        private void btn_InsertarPago_Click(object sender, EventArgs e)
        {
            try
            {
                string Resp = "";
                if (string.IsNullOrWhiteSpace(txtIdAlumnoPago.Text) || !int.TryParse(txtIdAlumnoPago.Text.Trim(), out int IdAlumnoPago))
                {
                    this.MensajeError("Falta ingresar un ID de alumno válido. El campo será remarcado.");
                    Erroricono.SetError(txtIdAlumnoPago, "Ingrese un ID de alumno válido");
                    txtIdAlumnoPago.Select();
                    return;
                }
                DateTime FechaPago = dtpFechaPago.Value;

                if (string.IsNullOrWhiteSpace(txtMontoPago.Text) || !decimal.TryParse(txtMontoPago.Text.Trim(), out decimal Monto))
                {
                    this.MensajeError("El campo Monto debe ser un número válido.");
                    Erroricono.SetError(txtMontoPago, "Ingrese un número válido para Monto");
                    txtMontoPago.Select();
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtMoraPago.Text) || !decimal.TryParse(txtMoraPago.Text.Trim(), out decimal Mora))
                {
                    this.MensajeError("El campo Mora debe ser un número válido.");
                    Erroricono.SetError(txtMoraPago, "Ingrese un número válido para Mora");
                    txtMoraPago.Select();
                    return;
                }

                Resp = NPago.Insertar(
                    IdAlumnoPago,
                    FechaPago,
                    Monto,
                    Mora
                );
                if (Resp.Equals("OK"))
                {
                    this.MensajeOK("El registro se insertó exitosamente.");
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
    }

}
