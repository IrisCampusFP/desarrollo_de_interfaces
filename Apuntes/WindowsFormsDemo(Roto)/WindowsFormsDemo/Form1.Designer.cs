namespace WindowsFormsDemo
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
            botonHola = new Button();
            lblSaludo = new Label();
            SuspendLayout();
            // 
            // botonHola
            // 
            botonHola.AutoSize = true;
            botonHola.BackColor = Color.FromArgb(255, 192, 192);
            botonHola.Location = new Point(379, 82);
            botonHola.Name = "botonHola";
            botonHola.Size = new Size(123, 95);
            botonHola.TabIndex = 0;
            botonHola.Text = "button1";
            botonHola.UseVisualStyleBackColor = false;
            botonHola.Click += botonHola_Click;
            // 
            // lblSaludo
            // 
            lblSaludo.Font = new Font("Segoe UI", 48F);
            lblSaludo.ForeColor = Color.FromArgb(255, 128, 128);
            lblSaludo.Location = new Point(87, 216);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(607, 142);
            lblSaludo.TabIndex = 1;
            lblSaludo.Text = "Ventana de saludo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSaludo);
            Controls.Add(botonHola);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonHola;
        private Label lblSaludo;
    }
}
