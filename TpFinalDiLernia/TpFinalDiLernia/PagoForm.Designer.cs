namespace Consorcio.UI
{
    partial class PagoForm
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
            dgvPago = new DataGridView();
            label2 = new Label();
            dtpFechaPago = new DateTimePicker();
            label3 = new Label();
            txtMonto = new TextBox();
            label4 = new Label();
            txtNroComprobante = new TextBox();
            label5 = new Label();
            txtObser = new TextBox();
            label6 = new Label();
            cmbMedioPago = new ComboBox();
            btnIngresarPago = new Button();
            btnModificarPago = new Button();
            btnEliminarPago = new Button();
            btnConsultarPago = new Button();
            cmbExpensas = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPago).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 37);
            label1.Name = "label1";
            label1.Size = new Size(148, 32);
            label1.TabIndex = 0;
            label1.Text = "Detalle Pago";
            // 
            // dgvPago
            // 
            dgvPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPago.Location = new Point(480, 12);
            dgvPago.Name = "dgvPago";
            dgvPago.Size = new Size(850, 574);
            dgvPago.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 159);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha Pago";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Location = new Point(165, 148);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(200, 23);
            dtpFechaPago.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 193);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(165, 185);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 227);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 6;
            label4.Text = "Medio Pago";
            // 
            // txtNroComprobante
            // 
            txtNroComprobante.Location = new Point(165, 252);
            txtNroComprobante.Name = "txtNroComprobante";
            txtNroComprobante.Size = new Size(100, 23);
            txtNroComprobante.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 260);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 8;
            label5.Text = "Nro Comprobante";
            // 
            // txtObser
            // 
            txtObser.Location = new Point(165, 285);
            txtObser.Name = "txtObser";
            txtObser.Size = new Size(100, 23);
            txtObser.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(55, 293);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 10;
            label6.Text = "Observaciones";
            // 
            // cmbMedioPago
            // 
            cmbMedioPago.FormattingEnabled = true;
            cmbMedioPago.Location = new Point(165, 219);
            cmbMedioPago.Name = "cmbMedioPago";
            cmbMedioPago.Size = new Size(121, 23);
            cmbMedioPago.TabIndex = 12;
            // 
            // btnIngresarPago
            // 
            btnIngresarPago.Location = new Point(67, 352);
            btnIngresarPago.Name = "btnIngresarPago";
            btnIngresarPago.Size = new Size(102, 41);
            btnIngresarPago.TabIndex = 13;
            btnIngresarPago.Text = "Ingresar Pago";
            btnIngresarPago.UseVisualStyleBackColor = true;
            btnIngresarPago.Click += btnIngresarPago_Click;
            // 
            // btnModificarPago
            // 
            btnModificarPago.Location = new Point(194, 352);
            btnModificarPago.Name = "btnModificarPago";
            btnModificarPago.Size = new Size(102, 41);
            btnModificarPago.TabIndex = 14;
            btnModificarPago.Text = "Modificar Pago";
            btnModificarPago.UseVisualStyleBackColor = true;
            btnModificarPago.Click += btnModificarPago_Click;
            // 
            // btnEliminarPago
            // 
            btnEliminarPago.Location = new Point(67, 399);
            btnEliminarPago.Name = "btnEliminarPago";
            btnEliminarPago.Size = new Size(102, 41);
            btnEliminarPago.TabIndex = 15;
            btnEliminarPago.Text = "Eliminar Pago";
            btnEliminarPago.UseVisualStyleBackColor = true;
            btnEliminarPago.Click += btnEliminarPago_Click;
            // 
            // btnConsultarPago
            // 
            btnConsultarPago.Location = new Point(194, 399);
            btnConsultarPago.Name = "btnConsultarPago";
            btnConsultarPago.Size = new Size(102, 41);
            btnConsultarPago.TabIndex = 16;
            btnConsultarPago.Text = "Consultar Pago";
            btnConsultarPago.UseVisualStyleBackColor = true;
            // 
            // cmbExpensas
            // 
            cmbExpensas.FormattingEnabled = true;
            cmbExpensas.Location = new Point(165, 107);
            cmbExpensas.Name = "cmbExpensas";
            cmbExpensas.Size = new Size(121, 23);
            cmbExpensas.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 115);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 18;
            label7.Text = "Expensas";
            // 
            // PagoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 598);
            Controls.Add(label7);
            Controls.Add(cmbExpensas);
            Controls.Add(btnConsultarPago);
            Controls.Add(btnEliminarPago);
            Controls.Add(btnModificarPago);
            Controls.Add(btnIngresarPago);
            Controls.Add(cmbMedioPago);
            Controls.Add(txtObser);
            Controls.Add(label6);
            Controls.Add(txtNroComprobante);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtMonto);
            Controls.Add(label3);
            Controls.Add(dtpFechaPago);
            Controls.Add(label2);
            Controls.Add(dgvPago);
            Controls.Add(label1);
            Name = "PagoForm";
            Text = "PagoForm";
            Load += PagoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPago).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvPago;
        private Label label2;
        private DateTimePicker dtpFechaPago;
        private Label label3;
        private TextBox txtMonto;
        private Label label4;
        private TextBox txtNroComprobante;
        private Label label5;
        private TextBox txtObser;
        private Label label6;
        private ComboBox cmbMedioPago;
        private Button btnIngresarPago;
        private Button btnModificarPago;
        private Button btnEliminarPago;
        private Button btnConsultarPago;
        private ComboBox cmbExpensas;
        private Label label7;
    }
}