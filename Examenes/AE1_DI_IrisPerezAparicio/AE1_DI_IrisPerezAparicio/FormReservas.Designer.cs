namespace AE1_DI_IrisPerezAparicio
{
    partial class FormReservas
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
            btnConfirmar = new Button();
            txtNombre = new TextBox();
            txtDestino = new TextBox();
            txtFecha = new TextBox();
            btnCancelar = new Button();
            btnLimpiar = new Button();
            label5 = new Label();
            componenteReutilizableDestino1 = new ComponenteReutilizableDestino();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(806, 76);
            label1.TabIndex = 3;
            label1.Text = "Reservas 🏨";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(215, 139);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 4;
            label2.Text = "Nombre:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(215, 194);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 5;
            label3.Text = "Destino:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientActiveCaption;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(230, 244);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 6;
            label4.Text = "Fecha:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ActiveCaption;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(305, 312);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(134, 50);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Confirmar ✓";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(323, 139);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(323, 192);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(100, 23);
            txtDestino.TabIndex = 9;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(323, 244);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 10;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(169, 323);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 31);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar ❌";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSize = true;
            btnLimpiar.BackColor = Color.SteelBlue;
            btnLimpiar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(469, 323);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(103, 31);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar \U0001f9f9";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(514, 145);
            label5.Name = "label5";
            label5.Size = new Size(141, 17);
            label5.TabIndex = 13;
            label5.Text = "Destino recomendado:";
            // 
            // componenteReutilizableDestino1
            // 
            componenteReutilizableDestino1.BackColor = SystemColors.GradientInactiveCaption;
            componenteReutilizableDestino1.Location = new Point(503, 177);
            componenteReutilizableDestino1.Name = "componenteReutilizableDestino1";
            componenteReutilizableDestino1.NombreDestino = "Viaja a París 🗼";
            componenteReutilizableDestino1.Size = new Size(206, 62);
            componenteReutilizableDestino1.TabIndex = 14;
            // 
            // FormReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(componenteReutilizableDestino1);
            Controls.Add(label5);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCancelar);
            Controls.Add(txtFecha);
            Controls.Add(txtDestino);
            Controls.Add(txtNombre);
            Controls.Add(btnConfirmar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormReservas";
            Text = "Reservas - Agencia de Viajes 2025 - Iris Pérez Aparicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnConfirmar;
        private TextBox txtNombre;
        private TextBox txtDestino;
        private TextBox txtFecha;
        private Button btnCancelar;
        private Button btnLimpiar;
        private Label label5;
        private ComponenteReutilizableDestino componenteReutilizableDestino1;
    }
}