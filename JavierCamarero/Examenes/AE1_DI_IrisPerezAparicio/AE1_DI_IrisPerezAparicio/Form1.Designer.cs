namespace AE1_DI_IrisPerezAparicio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            destinosToolStripMenuItem = new ToolStripMenuItem();
            ofertasToolStripMenuItem = new ToolStripMenuItem();
            reservasToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnDestinos = new Button();
            btnOfertas = new Button();
            btnReservas = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { destinosToolStripMenuItem, ofertasToolStripMenuItem, reservasToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(802, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // destinosToolStripMenuItem
            // 
            destinosToolStripMenuItem.Name = "destinosToolStripMenuItem";
            destinosToolStripMenuItem.Size = new Size(64, 20);
            destinosToolStripMenuItem.Text = "Destinos";
            destinosToolStripMenuItem.Click += destinosToolStripMenuItem_Click;
            // 
            // ofertasToolStripMenuItem
            // 
            ofertasToolStripMenuItem.Name = "ofertasToolStripMenuItem";
            ofertasToolStripMenuItem.Size = new Size(57, 20);
            ofertasToolStripMenuItem.Text = "Ofertas";
            ofertasToolStripMenuItem.Click += ofertasToolStripMenuItem_Click;
            // 
            // reservasToolStripMenuItem
            // 
            reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            reservasToolStripMenuItem.Size = new Size(64, 20);
            reservasToolStripMenuItem.Text = "Reservas";
            reservasToolStripMenuItem.Click += reservasToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(802, 76);
            label1.TabIndex = 1;
            label1.Text = "Agencia de Viajes 2025";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDestinos
            // 
            btnDestinos.BackColor = SystemColors.GradientActiveCaption;
            btnDestinos.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDestinos.Location = new Point(127, 219);
            btnDestinos.Name = "btnDestinos";
            btnDestinos.Size = new Size(139, 62);
            btnDestinos.TabIndex = 2;
            btnDestinos.Text = "Destinos 🛬";
            btnDestinos.UseVisualStyleBackColor = false;
            btnDestinos.Click += btnDestinos_Click;
            // 
            // btnOfertas
            // 
            btnOfertas.BackColor = SystemColors.GradientActiveCaption;
            btnOfertas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOfertas.Location = new Point(332, 219);
            btnOfertas.Name = "btnOfertas";
            btnOfertas.Size = new Size(139, 62);
            btnOfertas.TabIndex = 3;
            btnOfertas.Text = "Ofertas💲";
            btnOfertas.UseVisualStyleBackColor = false;
            btnOfertas.Click += btnOfertas_Click;
            // 
            // btnReservas
            // 
            btnReservas.BackColor = SystemColors.GradientActiveCaption;
            btnReservas.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReservas.Location = new Point(535, 219);
            btnReservas.Name = "btnReservas";
            btnReservas.Size = new Size(139, 62);
            btnReservas.TabIndex = 4;
            btnReservas.Text = "Reservas 🏨";
            btnReservas.UseVisualStyleBackColor = false;
            btnReservas.Click += btnReservas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(802, 439);
            Controls.Add(btnReservas);
            Controls.Add(btnOfertas);
            Controls.Add(btnDestinos);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Agencia de Viajes 2025 - Iris Pérez Aparicio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem destinosToolStripMenuItem;
        private ToolStripMenuItem ofertasToolStripMenuItem;
        private ToolStripMenuItem reservasToolStripMenuItem;
        private Label label1;
        private Button btnDestinos;
        private Button btnOfertas;
        private Button btnReservas;
    }
}
