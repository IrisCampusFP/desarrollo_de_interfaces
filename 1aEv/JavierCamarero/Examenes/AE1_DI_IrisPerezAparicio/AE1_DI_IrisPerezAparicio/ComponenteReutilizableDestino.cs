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
    public partial class ComponenteReutilizableDestino : UserControl
    {
        public ComponenteReutilizableDestino()
        {
            InitializeComponent();
        }

        private String nombreDestino;
        public String NombreDestino
        {
            get { return nombreDestino; }
            set
            {
                nombreDestino = value;
                lblDestino.Text = nombreDestino;
            }
        }
    }
}
