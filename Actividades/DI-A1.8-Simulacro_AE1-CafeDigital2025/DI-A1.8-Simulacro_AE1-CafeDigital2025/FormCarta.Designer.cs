namespace DI_A1._8_Simulacro_AE1_CafeDigital2025
{
    partial class FormCarta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            elementoReutilizableProducto1 = new ElementoReutilizableProducto();
            elementoReutilizableProducto2 = new ElementoReutilizableProducto();
            elementoReutilizableProducto3 = new ElementoReutilizableProducto();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.MediumSlateBlue;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(494, 73);
            label1.TabIndex = 2;
            label1.Text = "📋 NUESTRA CARTA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 3;
            label2.Text = "Productos disponibles:";
            // 
            // elementoReutilizableProducto1
            // 
            elementoReutilizableProducto1.BackColor = Color.Transparent;
            elementoReutilizableProducto1.Location = new Point(147, 105);
            elementoReutilizableProducto1.Name = "elementoReutilizableProducto1";
            elementoReutilizableProducto1.NombreProducto = "☕ Café Latte";
            elementoReutilizableProducto1.Size = new Size(194, 102);
            elementoReutilizableProducto1.TabIndex = 4;
            // 
            // elementoReutilizableProducto2
            // 
            elementoReutilizableProducto2.BackColor = Color.Transparent;
            elementoReutilizableProducto2.Location = new Point(147, 199);
            elementoReutilizableProducto2.Name = "elementoReutilizableProducto2";
            elementoReutilizableProducto2.NombreProducto = "🍵 Té verde";
            elementoReutilizableProducto2.Size = new Size(194, 102);
            elementoReutilizableProducto2.TabIndex = 5;
            // 
            // elementoReutilizableProducto3
            // 
            elementoReutilizableProducto3.BackColor = Color.Transparent;
            elementoReutilizableProducto3.Location = new Point(147, 293);
            elementoReutilizableProducto3.Name = "elementoReutilizableProducto3";
            elementoReutilizableProducto3.NombreProducto = "\U0001f950 Croissant";
            elementoReutilizableProducto3.Size = new Size(194, 102);
            elementoReutilizableProducto3.TabIndex = 6;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.MediumSlateBlue;
            btnCerrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(186, 401);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(116, 40);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormCarta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(493, 456);
            Controls.Add(btnCerrar);
            Controls.Add(elementoReutilizableProducto3);
            Controls.Add(elementoReutilizableProducto2);
            Controls.Add(elementoReutilizableProducto1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCarta";
            Text = "Carta - Café Digital 2025 - Iris Pérez";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ElementoReutilizableProducto elementoReutilizableProducto1;
        private ElementoReutilizableProducto elementoReutilizableProducto2;
        private ElementoReutilizableProducto elementoReutilizableProducto3;
        private Button btnCerrar;
    }
}