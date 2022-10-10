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
    //string lugarUsado, Artista artista, List<Persona> espectadores, DateTime fechaDeShow, int duracion, float precioBase
    public partial class FrmAltaShow : Form
    {
        public FrmAltaShow()
        {
            InitializeComponent();
        }
        private void FrmAltaShow_Load(object sender, EventArgs e)
        {
            cboArtista.DataSource = Administracion.Artistas;
            this.Text = "Alta de shows";
            //cboEstablecimiento
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Administracion.Shows.Add(new Show("lugar random", (Artista)cboArtista.SelectedItem, dtpFecha.Value, int.Parse(txtDuracion.Text), float.Parse(txtPrecio.Text)));
        }
    }
}
