using AutomatizacionPruebasElectricas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatizacionPruebasElectricas.Views
{
	public partial class ModulosParaUsuarios : Form
	{
		private string id;

		public ModulosParaUsuarios(string id)
		{
			InitializeComponent();
			this.id = id;
		}

		private async void ModulosParaUsuarios_Load(object sender, EventArgs e)
		{
			// Instancia de tu clase de acceso a datos
			ClsUsuarios clsUsuarios = new ClsUsuarios();

			// Obtiene todos los módulos del sistema
			List<string> todosLosModulos = await clsUsuarios.GetModulos();

			// Obtiene los módulos activos del usuario
			List<string> modulosActivos = await clsUsuarios.GetModulosActivos(id); // Este método debe devolver solo los módulos asignados al usuario

			// Configurar las columnas del DataGridView
			dataGridView1.Columns.Clear();

			// Columna de texto para el nombre del módulo
			dataGridView1.Columns.Add("Modulo", "Módulo");

			// Columna ComboBox para permisos (Activo / Inactivo)
			DataGridViewComboBoxColumn comboCol = new DataGridViewComboBoxColumn();
			comboCol.Name = "Acceso";
			comboCol.HeaderText = "Acceso";
			comboCol.Items.AddRange("Activo", "Inactivo");

			dataGridView1.Columns.Add(comboCol);

			// Llenar el DataGridView
			foreach (string modulo in todosLosModulos)
			{
				// Verifica si el módulo está activo para el usuario
				string estado = modulosActivos.Contains(modulo) ? "Activo" : "Inactivo";
				dataGridView1.Rows.Add(modulo, estado);
			}


		}

		private async void BtnRegistrarPermisos_Click(object sender, EventArgs e)
		{
			// Recolectar módulos seleccionados como "Activo"
			List<string> modulosSeleccionados = new List<string>();

			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				if (row.IsNewRow) continue;

				string modulo = row.Cells["Modulo"].Value?.ToString();
				string acceso = row.Cells["Acceso"].Value?.ToString();

				if (!string.IsNullOrEmpty(modulo) && acceso == "Activo")
				{
					modulosSeleccionados.Add(modulo);
				}
			}

			// Llamar al método que actualiza la base de datos
			ClsUsuarios clsUsuarios = new ClsUsuarios();
			bool exito = await clsUsuarios.ActualizarModulosDelUsuario(id, modulosSeleccionados);

			if (exito)
			{
				MessageBox.Show("Permisos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Ocurrió un error al actualizar los permisos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
