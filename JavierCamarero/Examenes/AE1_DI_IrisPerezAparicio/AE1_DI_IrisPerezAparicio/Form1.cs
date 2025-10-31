namespace AE1_DI_IrisPerezAparicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            FormDestinos formDestinos = new FormDestinos();
            formDestinos.ShowDialog();
        }

        private void destinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDestinos formDestinos = new FormDestinos();
            formDestinos.ShowDialog();
        }

        private void btnOfertas_Click(object sender, EventArgs e)
        {
            FormOfertas formOfertas = new FormOfertas();
            formOfertas.ShowDialog();
        }

        private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOfertas formOfertas = new FormOfertas();
            formOfertas.ShowDialog();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            FormReservas formReservas = new FormReservas();
            formReservas.ShowDialog();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReservas formReservas = new FormReservas();
            formReservas.ShowDialog();
        }
    }
}
