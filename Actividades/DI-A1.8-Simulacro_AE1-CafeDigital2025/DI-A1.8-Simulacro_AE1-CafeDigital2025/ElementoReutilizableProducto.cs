using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_A1._8_Simulacro_AE1_CafeDigital2025
{
    public partial class ElementoReutilizableProducto : UserControl
    {
        public ElementoReutilizableProducto()
        {
            InitializeComponent();
        }

        private String nombreProducto;
        public String NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; 
                lblProducto.Text = nombreProducto; }
        }

        private void lblProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
