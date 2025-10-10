namespace DI_A1._8_Simulacro_AE1_CafeDigital2025
{
    partial class FormPedido
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
            label5 = new Label();
            txtNombre = new TextBox();
            txtProducto = new TextBox();
            txtCantidad = new TextBox();
            elementoReutilizableProducto1 = new ElementoReutilizableProducto();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.MediumSlateBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(493, 70);
            label1.TabIndex = 3;
            label1.Text = "\U0001f6d2 REALIZAR PEDIDO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(332, 20);
            label2.TabIndex = 4;
            label2.Text = "Complete el formulario para realizar su pedido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(44, 137);
            label3.Name = "label3";
            label3.Size = new Size(161, 21);
            label3.TabIndex = 5;
            label3.Text = "Nombre del cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkSlateBlue;
            label4.Location = new Point(44, 183);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 6;
            label4.Text = "Producto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkSlateBlue;
            label5.Location = new Point(45, 230);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 7;
            label5.Text = "Cantidad:";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(211, 137);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(237, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtProducto
            // 
            txtProducto.BorderStyle = BorderStyle.FixedSingle;
            txtProducto.Location = new Point(211, 183);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(237, 23);
            txtProducto.TabIndex = 9;
            // 
            // txtCantidad
            // 
            txtCantidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad.Location = new Point(211, 228);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(237, 23);
            txtCantidad.TabIndex = 10;
            // 
            // elementoReutilizableProducto1
            // 
            elementoReutilizableProducto1.BackColor = Color.Transparent;
            elementoReutilizableProducto1.Location = new Point(150, 270);
            elementoReutilizableProducto1.Name = "elementoReutilizableProducto1";
            elementoReutilizableProducto1.NombreProducto = "🎁 Producto Seleccionado";
            elementoReutilizableProducto1.Size = new Size(194, 102);
            elementoReutilizableProducto1.TabIndex = 11;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.SeaGreen;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(45, 387);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(123, 33);
            btnConfirmar.TabIndex = 12;
            btnConfirmar.Text = "Confirmar ✔";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(184, 387);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 33);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar ✖";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkSlateBlue;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(325, 387);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 33);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar \U0001f9f9";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FormPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 444);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(elementoReutilizableProducto1);
            Controls.Add(txtCantidad);
            Controls.Add(txtProducto);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPedido";
            Text = "Pedidos - Café Digital 2025 - Iris Pérez";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtProducto;
        private TextBox txtCantidad;
        private ElementoReutilizableProducto elementoReutilizableProducto1;
        private Button btnConfirmar;
        private Button btnCancelar;
        private Button btnLimpiar;
    }
}