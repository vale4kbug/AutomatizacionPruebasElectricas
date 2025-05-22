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
	public partial class PermisosProductos : Form
	{
		public PermisosProductos(string idUsuario)
		{
			this.idUsuario = idUsuario;
			InitializeComponent();
		}



		public string idUsuario { get; }
	}
}
