namespace DI_A1._9_AppEscritorioSencilla
{
    partial class FormSecundario
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
            datosUsuarioControl1 = new DatosUsuarioControl();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // datosUsuarioControl1
            // 
            datosUsuarioControl1.Location = new Point(268, 54);
            datosUsuarioControl1.Name = "datosUsuarioControl1";
            datosUsuarioControl1.Size = new Size(253, 213);
            datosUsuarioControl1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(359, 273);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormSecundario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(datosUsuarioControl1);
            Name = "FormSecundario";
            Text = "FormSecundario";
            ResumeLayout(false);
        }

        #endregion

        private DatosUsuarioControl datosUsuarioControl1;
        private Button btnAceptar;
    }
}