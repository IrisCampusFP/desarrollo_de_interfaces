namespace DI_A1._8_Simulacro_AE1_CafeDigital2025
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerCarta_Click(object sender, EventArgs e)
        {
            FormCarta formCarta = new FormCarta();
            formCarta.ShowDialog();
        }

        private void btnHacerPedido_Click(object sender, EventArgs e)
        {
            FormPedido formPedido = new FormPedido();
            formPedido.ShowDialog();
        }

        private void cartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCarta formCarta = new FormCarta();
            formCarta.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPedido formPedido = new FormPedido();
            formPedido.ShowDialog();
        }
    }
}
