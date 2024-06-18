namespace SistemaDeVentas
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
            txtNombreProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            txtCantidad = new TextBox();
            btnAgregarVenta = new Button();
            btnReporteTabular = new Button();
            btnReporteGrafico = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(223, 77);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 23);
            txtNombreProducto.TabIndex = 0;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(223, 106);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(100, 23);
            txtPrecioProducto.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(223, 135);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 2;
            // 
            // btnAgregarVenta
            // 
            btnAgregarVenta.Location = new Point(339, 76);
            btnAgregarVenta.Name = "btnAgregarVenta";
            btnAgregarVenta.Size = new Size(75, 23);
            btnAgregarVenta.TabIndex = 3;
            btnAgregarVenta.Text = "Guardar";
            btnAgregarVenta.UseVisualStyleBackColor = true;
            btnAgregarVenta.Click += btnAgregarVenta_Click;
            // 
            // btnReporteTabular
            // 
            btnReporteTabular.Location = new Point(585, 76);
            btnReporteTabular.Name = "btnReporteTabular";
            btnReporteTabular.Size = new Size(85, 44);
            btnReporteTabular.TabIndex = 4;
            btnReporteTabular.Text = "reporte tabular";
            btnReporteTabular.UseVisualStyleBackColor = true;
            // 
            // btnReporteGrafico
            // 
            btnReporteGrafico.Location = new Point(480, 76);
            btnReporteGrafico.Name = "btnReporteGrafico";
            btnReporteGrafico.Size = new Size(82, 44);
            btnReporteGrafico.TabIndex = 5;
            btnReporteGrafico.Text = "Grafico";
            btnReporteGrafico.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 76);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 6;
            label1.Text = "nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 106);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 138);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 8;
            label3.Text = "cantidad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnReporteGrafico);
            Controls.Add(btnReporteTabular);
            Controls.Add(btnAgregarVenta);
            Controls.Add(txtCantidad);
            Controls.Add(txtPrecioProducto);
            Controls.Add(txtNombreProducto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProducto;
        private TextBox txtPrecioProducto;
        private TextBox txtCantidad;
        private Button btnAgregarVenta;
        private Button btnReporteTabular;
        private Button btnReporteGrafico;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
