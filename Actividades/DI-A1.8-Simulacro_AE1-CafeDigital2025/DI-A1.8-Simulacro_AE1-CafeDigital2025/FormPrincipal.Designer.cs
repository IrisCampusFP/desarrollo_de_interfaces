namespace DI_A1._8_Simulacro_AE1_CafeDigital2025
{
    partial class FormPrincipal
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
            cartaToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnVerCarta = new Button();
            btnHacerPedido = new Button();
            label2 = new Label();
            label3 = new Label();
            elementoReutilizableProducto1 = new ElementoReutilizableProducto();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.SlateBlue;
            menuStrip1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cartaToolStripMenuItem, pedidosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(729, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cartaToolStripMenuItem
            // 
            cartaToolStripMenuItem.ForeColor = Color.White;
            cartaToolStripMenuItem.Name = "cartaToolStripMenuItem";
            cartaToolStripMenuItem.Size = new Size(58, 24);
            cartaToolStripMenuItem.Text = "Carta";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.ForeColor = Color.White;
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(76, 24);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // label1
            // 
            label1.BackColor = Color.MediumSlateBlue;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 28);
            label1.Name = "label1";
            label1.Size = new Size(729, 84);
            label1.TabIndex = 1;
            label1.Text = "☕ CAFÉ DIGITAL 2025";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnVerCarta
            // 
            btnVerCarta.BackColor = Color.SlateBlue;
            btnVerCarta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerCarta.ForeColor = Color.White;
            btnVerCarta.Location = new Point(162, 244);
            btnVerCarta.Name = "btnVerCarta";
            btnVerCarta.Size = new Size(201, 46);
            btnVerCarta.TabIndex = 4;
            btnVerCarta.Text = "📋 VER CARTA";
            btnVerCarta.UseVisualStyleBackColor = false;
            btnVerCarta.Click += btnVerCarta_Click;
            // 
            // btnHacerPedido
            // 
            btnHacerPedido.BackColor = Color.SlateBlue;
            btnHacerPedido.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHacerPedido.ForeColor = Color.White;
            btnHacerPedido.Location = new Point(378, 244);
            btnHacerPedido.Name = "btnHacerPedido";
            btnHacerPedido.Size = new Size(201, 46);
            btnHacerPedido.TabIndex = 5;
            btnHacerPedido.Text = "\U0001f6d2 HACER PEDIDO";
            btnHacerPedido.UseVisualStyleBackColor = false;
            btnHacerPedido.Click += btnHacerPedido_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(208, 146);
            label2.Name = "label2";
            label2.Size = new Size(329, 25);
            label2.TabIndex = 6;
            label2.Text = "¡Bienvenido a nuestro quiosco digital!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(162, 188);
            label3.Name = "label3";
            label3.Size = new Size(417, 25);
            label3.TabIndex = 7;
            label3.Text = "Seleccione una opción del menú para comenzar";
            // 
            // elementoReutilizableProducto1
            // 
            elementoReutilizableProducto1.BackColor = Color.Transparent;
            elementoReutilizableProducto1.Location = new Point(268, 315);
            elementoReutilizableProducto1.Name = "elementoReutilizableProducto1";
            elementoReutilizableProducto1.NombreProducto = "Café del Día";
            elementoReutilizableProducto1.Size = new Size(194, 102);
            elementoReutilizableProducto1.TabIndex = 8;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(729, 450);
            Controls.Add(elementoReutilizableProducto1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnHacerPedido);
            Controls.Add(btnVerCarta);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "FormPrincipal";
            Text = "Café Digital 2025 - Iris Pérez";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cartaToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private Label label1;
        private Button btnVerCarta;
        private Button btnHacerPedido;
        private Button button1;
        private Label label2;
        private Label label3;
        private ElementoReutilizableProducto elementoReutilizableProducto1;
    }
}
