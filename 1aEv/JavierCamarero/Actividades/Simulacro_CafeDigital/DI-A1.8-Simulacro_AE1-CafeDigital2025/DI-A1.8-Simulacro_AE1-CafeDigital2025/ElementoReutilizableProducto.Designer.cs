namespace DI_A1._8_Simulacro_AE1_CafeDigital2025
{
    partial class ElementoReutilizableProducto
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
            label1 = new Label();
            label2 = new Label();
            lblProducto = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(7, 8);
            label1.Name = "label1";
            label1.Size = new Size(179, 86);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.MediumSlateBlue;
            label2.Location = new Point(8, 9);
            label2.Name = "label2";
            label2.Size = new Size(55, 84);
            label2.TabIndex = 1;
            // 
            // lblProducto
            // 
            lblProducto.BackColor = Color.White;
            lblProducto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.ForeColor = Color.MediumSlateBlue;
            lblProducto.Location = new Point(60, 9);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(125, 84);
            lblProducto.TabIndex = 2;
            lblProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ElementoReutilizableProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label2);
            Controls.Add(lblProducto);
            Controls.Add(label1);
            Name = "ElementoReutilizableProducto";
            Size = new Size(194, 102);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblProducto;
    }
}
