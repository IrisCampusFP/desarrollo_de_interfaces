namespace DI_A1._9_AppEscritorioSencilla
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
            datosUsuarioControl1 = new DatosUsuarioControl();
            btnAbrirSecundario = new Button();
            SuspendLayout();
            // 
            // datosUsuarioControl1
            // 
            datosUsuarioControl1.Location = new Point(280, 63);
            datosUsuarioControl1.Name = "datosUsuarioControl1";
            datosUsuarioControl1.Size = new Size(253, 213);
            datosUsuarioControl1.TabIndex = 0;
            // 
            // btnAbrirSecundario
            // 
            btnAbrirSecundario.AutoSize = true;
            btnAbrirSecundario.Location = new Point(332, 282);
            btnAbrirSecundario.Name = "btnAbrirSecundario";
            btnAbrirSecundario.Size = new Size(163, 25);
            btnAbrirSecundario.TabIndex = 1;
            btnAbrirSecundario.Text = "Abrir formulario secundario";
            btnAbrirSecundario.UseVisualStyleBackColor = true;
            btnAbrirSecundario.Click += btnAbrirSecundario_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAbrirSecundario);
            Controls.Add(datosUsuarioControl1);
            Name = "FormPrincipal";
            Text = "Form1";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DatosUsuarioControl datosUsuarioControl1;
        private Button btnAbrirSecundario;
    }
}
