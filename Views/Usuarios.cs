using AutomatizacionPruebasElectricas.Classes;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatizacionPruebasElectricas.Views
{
	public partial class Usuarios : Form
	{
		ClsUsuarios users;
		string documentosPath;

		public Usuarios()
		{
			InitializeComponent();
			documentosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\FotosUsuarios";
			users = new ClsUsuarios
			{
				sendDatos = SettingUserInForm
			};
			OpenImage.InitialDirectory = documentosPath;
		}

		private void SettingUserInForm(DataTable datos)
		{
			if (datos.Rows.Count > 0)
			{
				txtNombre.Text = datos.Rows[0][0].ToString();
				txtApellido.Text = datos.Rows[0][1].ToString();
				dtFecha.Value = DateTime.Parse(datos.Rows[0][2].ToString());
				try
				{
					picFoto.Image = Image.FromFile(Path.Combine(documentosPath, datos.Rows[0][3].ToString()));
				}
				catch (Exception)
				{
					picFoto.Image = Image.FromFile(Path.Combine(documentosPath, "default.png"));
				}
				txtUsername.Text = datos.Rows[0][4].ToString();
				txtPassword.Text = datos.Rows[0][5].ToString();

				txtUserID.Enabled = false;
			}
		}

		private void Usuarios_Load(object sender, EventArgs e)
		{
			dtFecha.MaxDate = DateTime.Now;
		}

		private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (chkShowPassword.Checked)
			{
				txtPassword.UseSystemPasswordChar = false;
			}
			else
			{
				txtPassword.UseSystemPasswordChar = true;
			}
		}

		private async void txtUserID_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				await users.GetUser(txtUserID.Text);
			}
		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			txtUserID.Enabled = true;
			txtUserID.Text = "";
			txtNombre.Text = "";
			txtApellido.Text = "";
			dtFecha.Value = DateTime.Now.AddDays(-1);
			txtUsername.Text = "";
			txtPassword.Text = "";
			picFoto.Image = null;
			OpenImage.FileName = documentosPath + "\\default.png";
			txtUserID.Focus();
		}

		private void BtnRuta_Click(object sender, EventArgs e)
		{
			if (OpenImage.ShowDialog() == DialogResult.OK)
			{
				picFoto.Image = Image.FromFile(OpenImage.FileName);
			}
		}

		private async void BtnAddModify_Click(object sender, EventArgs e)
		{
			if (txtUserID.Enabled == true)
			{
				int resultado = await users.PutUser(txtNombre.Text, txtApellido.Text, dtFecha.Value, Path.GetFileName(OpenImage.FileName), txtUsername.Text, txtPassword.Text);
				txtUserID.Text = resultado.ToString();
				txtUserID.Enabled = false;
				MessageBox.Show("Usuario Creado, favor de verificarlo");
			}
			else
			{
				await users.PutUser(txtUserID.Text, txtNombre.Text, txtApellido.Text, dtFecha.Value, Path.GetFileName(OpenImage.FileName), txtUsername.Text, txtPassword.Text);
				MessageBox.Show("Usuario actualizado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private async void BtnEliminar_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Estas seguro de eliminar este usuario?", "Eliminar usuario",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				int resultado = await users.DeleteUser(txtUserID.Text);
				MessageBox.Show($"Se elimino {resultado} usuario", "Operacion completada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
				BtnClear_Click(sender, e);
			}
		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			BuscarUsuario user = new BuscarUsuario();
			user.sendId = RecibirId;
			user.ShowDialog();
		}

		private async void RecibirId(string obj)
		{
			txtUserID.Text = obj;
			await users.GetUser(txtUserID.Text);
		}

		private async void BtnCredencial_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtUserID.Text))
			{
				MessageBox.Show("Primero busca un usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string pdfPath = await users.GenerarCredencial(txtUserID.Text);

			if (!string.IsNullOrEmpty(pdfPath))
			{
				System.Diagnostics.Process.Start(pdfPath); // Abre el PDF automáticamente
			}
		}

		private void BtnModulos_Click(object sender, EventArgs e)
		{
			ModulosParaUsuarios frm = new ModulosParaUsuarios(txtUserID.Text);
			frm.ShowDialog();
		}

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menuforma = new Menu("");
            this.Hide();
            menuforma.Show();
        }
    }
}
