namespace AE1_DI_IrisPerezAparicio
{
    partial class FormDestinos
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
            componenteReutilizableDestino1 = new ComponenteReutilizableDestino();
            componenteReutilizableDestino2 = new ComponenteReutilizableDestino();
            componenteReutilizableDestino3 = new ComponenteReutilizableDestino();
            btnVolverDestinos = new Button();
            btnReservarDestinos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, -1);
            label1.Name = "label1";
            label1.Size = new Size(806, 76);
            label1.TabIndex = 2;
            label1.Text = "Destinos 🛬";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // componenteReutilizableDestino1
            // 
            componenteReutilizableDestino1.BackColor = SystemColors.GradientInactiveCaption;
            componenteReutilizableDestino1.Location = new Point(295, 113);
            componenteReutilizableDestino1.Name = "componenteReutilizableDestino1";
            componenteReutilizableDestino1.NombreDestino = "París 🗼";
            componenteReutilizableDestino1.Size = new Size(206, 62);
            componenteReutilizableDestino1.TabIndex = 6;
            // 
            // componenteReutilizableDestino2
            // 
            componenteReutilizableDestino2.BackColor = SystemColors.GradientInactiveCaption;
            componenteReutilizableDestino2.Location = new Point(295, 191);
            componenteReutilizableDestino2.Name = "componenteReutilizableDestino2";
            componenteReutilizableDestino2.NombreDestino = "Roma 🍝";
            componenteReutilizableDestino2.Size = new Size(206, 62);
            componenteReutilizableDestino2.TabIndex = 7;
            // 
            // componenteReutilizableDestino3
            // 
            componenteReutilizableDestino3.BackColor = SystemColors.GradientInactiveCaption;
            componenteReutilizableDestino3.Location = new Point(295, 268);
            componenteReutilizableDestino3.Name = "componenteReutilizableDestino3";
            componenteReutilizableDestino3.NombreDestino = "Nueva York 🗽";
            componenteReutilizableDestino3.Size = new Size(206, 62);
            componenteReutilizableDestino3.TabIndex = 8;
            // 
            // btnVolverDestinos
            // 
            btnVolverDestinos.AutoSize = true;
            btnVolverDestinos.BackColor = SystemColors.ActiveCaption;
            btnVolverDestinos.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolverDestinos.Location = new Point(286, 362);
            btnVolverDestinos.Name = "btnVolverDestinos";
            btnVolverDestinos.Size = new Size(90, 35);
            btnVolverDestinos.TabIndex = 9;
            btnVolverDestinos.Text = "Volver";
            btnVolverDestinos.UseVisualStyleBackColor = false;
            btnVolverDestinos.Click += btnReservar_Click;
            // 
            // btnReservarDestinos
            // 
            btnReservarDestinos.AutoSize = true;
            btnReservarDestinos.BackColor = Color.LightSteelBlue;
            btnReservarDestinos.Font = new Font("Segoe UI Semilight", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReservarDestinos.Location = new Point(396, 358);
            btnReservarDestinos.Name = "btnReservarDestinos";
            btnReservarDestinos.Size = new Size(126, 42);
            btnReservarDestinos.TabIndex = 10;
            btnReservarDestinos.Text = "Reserva Ya!";
            btnReservarDestinos.UseVisualStyleBackColor = false;
            btnReservarDestinos.Click += btnReservarDestinos_Click;
            // 
            // FormDestinos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReservarDestinos);
            Controls.Add(btnVolverDestinos);
            Controls.Add(componenteReutilizableDestino3);
            Controls.Add(componenteReutilizableDestino2);
            Controls.Add(componenteReutilizableDestino1);
            Controls.Add(label1);
            Name = "FormDestinos";
            Text = "Destinos - Agencia de Viajes 2025 - Iris Pérez Aparicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComponenteReutilizableDestino componenteReutilizableDestino1;
        private ComponenteReutilizableDestino componenteReutilizableDestino2;
        private ComponenteReutilizableDestino componenteReutilizableDestino3;
        private Button btnVolverDestinos;
        private Button btnReservarDestinos;
    }
}