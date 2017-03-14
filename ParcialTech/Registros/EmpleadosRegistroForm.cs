using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParcialTech.Registros
{
    public partial class EmpleadosRegistroForm : Form
    {
        Entidades.Empleados Empleado;
        Entidades.EmpleadosEmails Detalle;

        public EmpleadosRegistroForm()
        {
            InitializeComponent();
            Limpiar();

        }

        private void EmpleadosRegistroForm_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        private void Limpiar()
        {
            Empleado = new Empleados();
            Detalle = new EmpleadosEmails();

            empleadoIdMaskedTextBox.Clear();
            nombresTextBox.Clear();
            fechaNacimientoDateTimePicker.Value = DateTime.Today;
            sueldoMaskedTextBox.Clear();
            CamposVacioserrorProvider.Clear();
            RetencionesdataGridView.DataSource = null;
            retencionesComboBox.Text = null;

            TipoIdtextBox.Clear();
            TipotextBox.Clear();
            EmailtextBox.Clear();
            TiposEmailsdataGridView.DataSource = null;

            nombresTextBox.Focus();
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(nombresTextBox.Text))
            {
                CamposVacioserrorProvider.SetError(nombresTextBox, "Llenar campo.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(sueldoMaskedTextBox.Text))
            {
                CamposVacioserrorProvider.SetError(sueldoMaskedTextBox, "Llenar campo.");
                interruptor = false;
            }
            if (RetencionesdataGridView.DataSource == null)
            {
                CamposVacioserrorProvider.SetError(RetencionesdataGridView, "Llenar campo.");
                interruptor = false;
            }
            if (TiposEmailsdataGridView.DataSource == null)
            {
                CamposVacioserrorProvider.SetError(TiposEmailsdataGridView, "Llenar campo.");
                interruptor = false;
            }

            return interruptor;
        }

        private void LlenarCombo()
        {
            List<Entidades.Retenciones> lista = BLL.RetencionesBLL.GetListAll();

            retencionesComboBox.DataSource = lista;
            retencionesComboBox.DisplayMember = "Descripcion";
            retencionesComboBox.ValueMember = "RetencionId";

            if (retencionesComboBox.Items.Count >= 1)
                retencionesComboBox.SelectedIndex = -1;
        }

        private Entidades.Empleados LlenarCampos()
        {
            Empleado.EmpleadoId = Utilidades.TOINT(empleadoIdMaskedTextBox.Text);
            Empleado.Nombres = nombresTextBox.Text;
            Empleado.FechaNacimiento = fechaNacimientoDateTimePicker.Value;
            Empleado.Sueldo = Utilidades.TOINT(sueldoMaskedTextBox.Text);
            Empleado.RetencionId = (int)retencionesComboBox.SelectedValue;

            return Empleado;
        }

        private void LlenarGridRetenciones(Entidades.Empleados empleado)
        {
            RetencionesdataGridView.DataSource = null;
            RetencionesdataGridView.DataSource = empleado.Retenciones;
        }

        private void LlenarGridTiposEmails(Entidades.Empleados empleado)
        {
            TiposEmailsdataGridView.DataSource = null;
            TiposEmailsdataGridView.DataSource = empleado.Relacion.ToList();

            this.TiposEmailsdataGridView.Columns["Id"].Visible = false;
            this.TiposEmailsdataGridView.Columns["EmpleadoId"].Visible = false;
            this.TiposEmailsdataGridView.Columns["TipoEmail"].Visible = false;
            this.TiposEmailsdataGridView.Columns["Empleado"].Visible = false;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                MessageBox.Show("Llenar Campos Vacios");
                Limpiar();
            }
            else
            {
                var empleado = new Empleados();

                empleado = LlenarCampos();

                if (empleado != null)
                {
                    if (BLL.EmpleadosBLL.Guardar(empleado))
                        MessageBox.Show("Guardado.");
                    else
                        MessageBox.Show("No Guardado");

                }

                Limpiar();
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(empleadoIdMaskedTextBox.Text))
            {
                MessageBox.Show("Id Vacio");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(empleadoIdMaskedTextBox.Text);
                var empleado = BLL.EmpleadosBLL.Buscar(p => p.EmpleadoId == id);

                if (empleado != null)
                {
                    nombresTextBox.Text = empleado.Nombres;
                    fechaNacimientoDateTimePicker.Value = empleado.FechaNacimiento;
                    sueldoMaskedTextBox.Text = empleado.Sueldo.ToString();

                    LlenarGridRetenciones(empleado);
                    LlenarGridTiposEmails(empleado);
                }
                else
                {
                    MessageBox.Show("No Existe.");
                    Limpiar();
                }
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
            {
                MessageBox.Show("Campos Vacios.");
                Limpiar();
            }
            else
            {
                int id = Utilidades.TOINT(empleadoIdMaskedTextBox.Text);

                if (BLL.EmpleadosBLL.Eliminar(BLL.EmpleadosBLL.Buscar(p => p.EmpleadoId == id)))
                {
                    Limpiar();
                    MessageBox.Show("Eliminado.");
                }
                else
                {
                    MessageBox.Show("No Eliminado.");
                }
            }
        }

        private void AgregarRetencionesbutton_Click(object sender, EventArgs e)
        {
            Entidades.Retenciones retencion = new Retenciones();

            retencion = (Entidades.Retenciones)retencionesComboBox.SelectedItem;
            Empleado.Retenciones.Add(retencion);

            LlenarGridRetenciones(Empleado);
        }

        private void TipoIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int id = Utilidades.TOINT(TipoIdtextBox.Text);

            if (e.KeyChar == (char)Keys.Enter)
            {
                Detalle.TipoEmail = BLL.TiposEmailBLL.Buscar(p => p.TipoId == id);

                if (Detalle.TipoEmail != null)
                {
                    TipotextBox.Text = Detalle.TipoEmail.Descripcion;
                }

                EmailtextBox.Focus();
            }
        }

        private void AgragarEmailsbutton_Click(object sender, EventArgs e)
        {
            Empleado.AgregarDetalle(Detalle.TipoEmail, EmailtextBox.Text);

            LlenarGridTiposEmails(Empleado);
        }

        private void TipotextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
