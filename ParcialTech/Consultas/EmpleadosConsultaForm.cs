using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParcialTech.Consultas
{
    public partial class EmpleadosConsultaForm : Form
    {


        public EmpleadosConsultaForm()
        {
            InitializeComponent();
        }

        private void EmpleadosConsultaForm_Load(object sender, EventArgs e)
        {

        }


        private void Limpiar()
        {
            FiltrarcomboBox.Text = null;
            CamposVacioserrorProvider.Clear();
            FiltrartextBox.Clear();
        }

        public bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(FiltrartextBox.Text))
            {
                CamposVacioserrorProvider.SetError(FiltrartextBox, "por favor llenar el campo.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(FiltrarcomboBox.Text))
            {
                CamposVacioserrorProvider.SetError(FiltrarcomboBox, "por favor seleccionar un campo.");
                interruptor = false;
            }

            return interruptor;
        }

        private void NoMostrar()
        {
            this.FiltrardataGridView.Columns["Relacion"].Visible = false;
        }

        private void Filtrarbutton_Click(object sender, EventArgs e)
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                FiltrardataGridView.DataSource = BLL.EmpleadosBLL.GetListAll();
                NoMostrar();
            }
            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                FiltrardataGridView.DataSource = BLL.EmpleadosBLL.GetList(p => p.FechaNacimiento >= DesdedateTimePicker.Value.Date && p.FechaNacimiento <= HastadateTimePicker.Value.Date);
                NoMostrar();
            }
            else if (FiltrarcomboBox.SelectedIndex != 0 || FiltrarcomboBox.SelectedIndex == 2)
            {
                if (!Validar())
                {
                    MessageBox.Show("Por favor Seleccionar/Llenar los campos vacios.");
                    Limpiar();
                }
                else
                {
                    if (FiltrarcomboBox.SelectedIndex == 1)
                    {
                        FiltrardataGridView.DataSource = BLL.EmpleadosBLL.GetList(p => p.Nombres == FiltrartextBox.Text);
                        NoMostrar();
                    }
                    if (FiltrarcomboBox.SelectedIndex == 3)
                    {
                        FiltrardataGridView.DataSource = BLL.EmpleadosBLL.GetList(p => p.Nombres == FiltrartextBox.Text && p.FechaNacimiento >= DesdedateTimePicker.Value.Date && p.FechaNacimiento <= HastadateTimePicker.Value.Date);
                        NoMostrar();
                    }
                }
            }
        }

    }

}
