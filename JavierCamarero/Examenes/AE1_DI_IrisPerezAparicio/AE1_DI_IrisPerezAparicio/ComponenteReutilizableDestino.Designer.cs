namespace AE1_DI_IrisPerezAparicio
{
    partial class ComponenteReutilizableDestino
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblDestino = new Label();
            SuspendLayout();
            // 
            // lblDestino
            // 
            lblDestino.BackColor = Color.LightSteelBlue;
            lblDestino.BorderStyle = BorderStyle.Fixed3D;
            lblDestino.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDestino.Location = new Point(12, 11);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(183, 42);
            lblDestino.TabIndex = 4;
            lblDestino.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ComponenteReutilizableDestino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            Controls.Add(lblDestino);
            Name = "ComponenteReutilizableDestino";
            Size = new Size(206, 62);
            ResumeLayout(false);
        }

        #endregion

        private Label lblDestino;
    }
}
