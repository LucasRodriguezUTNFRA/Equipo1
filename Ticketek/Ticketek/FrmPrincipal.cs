namespace Ticketek
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmCompraEntrada frmCompraEntrada = new FrmCompraEntrada(new Boleteria.Cliente("Carlos", "Apellido", 1433232, DateTime.Now));
            frmCompraEntrada.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAltaShow frmAltaShow = new FrmAltaShow();
            frmAltaShow.Show();
        }
    }
}