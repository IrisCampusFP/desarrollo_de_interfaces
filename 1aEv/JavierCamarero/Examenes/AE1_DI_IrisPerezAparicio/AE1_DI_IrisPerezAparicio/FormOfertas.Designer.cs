namespace AE1_DI_IrisPerezAparicio
{
    partial class FormOfertas
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
            label3 = new Label();
            label4 = new Label();
            btnReservar = new Button();
            btnVolverOfertas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new Size(806, 76);
            label1.TabIndex = 3;
            label1.Text = "Ofertas💲";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.LightSteelBlue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(161, 169);
            label2.Name = "label2";
            label2.Size = new Size(455, 64);
            label2.TabIndex = 4;
            label2.Text = "2x1 en viajes a Canarias 🏝️";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(161, 123);
            label3.Name = "label3";
            label3.Size = new Size(169, 21);
            label3.TabIndex = 5;
            label3.Text = "Promociones activas:";
            // 
            // label4
            // 
            label4.BackColor = Color.LightSteelBlue;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(161, 266);
            label4.Name = "label4";
            label4.Size = new Size(455, 64);
            label4.TabIndex = 6;
            label4.Text = "10% de descuento en cruceros 🛳️";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReservar
            // 
            btnReservar.AutoSize = true;
            btnReservar.BackColor = Color.LightSteelBlue;
            btnReservar.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservar.Location = new Point(391, 362);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(126, 42);
            btnReservar.TabIndex = 7;
            btnReservar.Text = "Reserva Ya!";
            btnReservar.UseVisualStyleBackColor = false;
            btnReservar.Click += btnReservar_Click;
            // 
            // btnVolverOfertas
            // 
            btnVolverOfertas.AutoSize = true;
            btnVolverOfertas.BackColor = SystemColors.ActiveCaption;
            btnVolverOfertas.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolverOfertas.Location = new Point(284, 366);
            btnVolverOfertas.Name = "btnVolverOfertas";
            btnVolverOfertas.Size = new Size(90, 35);
            btnVolverOfertas.TabIndex = 10;
            btnVolverOfertas.Text = "Volver";
            btnVolverOfertas.UseVisualStyleBackColor = false;
            btnVolverOfertas.Click += btnVolverOfertas_Click;
            // 
            // FormOfertas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolverOfertas);
            Controls.Add(btnReservar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormOfertas";
            Text = "Ofertas - Agencia de Viajes 2025 - Iris Pérez Aparicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnReservar;
        private Button btnVolverOfertas;
    }
}