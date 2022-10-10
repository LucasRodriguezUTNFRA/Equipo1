using Boleteria;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrada entradaNueva = Administracion.AgregarEspectadorAlShow(clienteLogeado, (Show)cboShows.SelectedItem, (Categoria)cboUbicacion.SelectedItem, (Ubicacion)cboCategoria.SelectedItem);
            MessageBox.Show($"{entradaNueva}", "Venta realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
