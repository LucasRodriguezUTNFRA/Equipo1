using Boleteria;
using Boleteria.Entidades;
using Boleteria.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketek
{
    public partial class FrmCompraEntrada : Form
    {
        Cliente clienteLogeado;
        public FrmCompraEntrada()
        {
            InitializeComponent();
        }

        public FrmCompraEntrada(Cliente clienteLogeado) : this()
        {
            this.clienteLogeado = clienteLogeado;
        }

        private void FrmCompraEntrada_Load(object sender, EventArgs e)
        {
            this.Text = "Compra de entrada";
            cboShows.DataSource = Administracion.Shows;
            cboCategoria.DataSource = Enum.GetValues(typeof(UbicacionEntrada));
            cboUbicacion.DataSource = Enum.GetValues(typeof(CategoriaEntrada));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrada entradaNueva = Administracion.AgregarEspectadorAlShow(clienteLogeado, (Show)cboShows.SelectedItem, (CategoriaEntrada)cboUbicacion.SelectedItem, (UbicacionEntrada)cboCategoria.SelectedItem);
            MessageBox.Show($"{entradaNueva}", "Venta realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
