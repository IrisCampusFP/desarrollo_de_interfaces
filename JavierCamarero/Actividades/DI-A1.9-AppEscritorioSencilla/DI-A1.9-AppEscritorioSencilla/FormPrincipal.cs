namespace DI_A1._9_AppEscritorioSencilla
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnAbrirSecundario_Click(object sender, EventArgs e)
        {
            FormSecundario formSec = new FormSecundario();
            formSec.ShowDialog();
        }
    }
}
