using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AE1_DI_IrisPerezAparicio
{
    public partial class FormDestinos : Form
    {
        public FormDestinos()
        {
            InitializeComponent();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReservarDestinos_Click(object sender, EventArgs e)
        {
            FormReservas formReservas = new FormReservas();
            formReservas.ShowDialog();
        }

        private void btnVolverDestinos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
