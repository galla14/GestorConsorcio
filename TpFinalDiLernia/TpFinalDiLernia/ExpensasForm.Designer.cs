namespace Consorcio.UI
{
    partial class ExpensasForm
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
            dgvExpensas = new DataGridView();
            label1 = new Label();
            txtMontoOrd = new TextBox();
            dtEmision = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dtVencimiento = new DateTimePicker();
            txtMontoExtraord = new TextBox();
            label4 = new Label();
            btnRecargo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbEstado = new ComboBox();
            label7 = new Label();
            cmbPorPropietario = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            btnGenerarExcel = new Button();
            btnBuscar = new Button();
            label10 = new Label();
            cmbUnidad = new ComboBox();
            btnInsertDetalle = new Button();
            btnEliminarDetalle = new Button();
            btnModificarDetalle = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExpensas).BeginInit();
            SuspendLayout();
            // 
            // dgvExpensas
            // 
            dgvExpensas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExpensas.Location = new Point(623, 61);
            dgvExpensas.Name = "dgvExpensas";
            dgvExpensas.Size = new Size(489, 496);
            dgvExpensas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 114);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Monto ordinario";
            // 
            // txtMontoOrd
            // 
            txtMontoOrd.Location = new Point(243, 106);
            txtMontoOrd.Name = "txtMontoOrd";
            txtMontoOrd.Size = new Size(100, 23);
            txtMontoOrd.TabIndex = 2;
            // 
            // dtEmision
            // 
            dtEmision.Location = new Point(243, 237);
            dtEmision.Name = "dtEmision";
            dtEmision.Size = new Size(200, 23);
            dtEmision.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 245);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 4;
            label2.Text = "Fecha Emision";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 274);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 6;
            label3.Text = "Fecha Vencimiento";
            // 
            // dtVencimiento
            // 
            dtVencimiento.Location = new Point(243, 266);
            dtVencimiento.Name = "dtVencimiento";
            dtVencimiento.Size = new Size(200, 23);
            dtVencimiento.TabIndex = 5;
            // 
            // txtMontoExtraord
            // 
            txtMontoExtraord.Location = new Point(243, 135);
            txtMontoExtraord.Name = "txtMontoExtraord";
            txtMontoExtraord.Size = new Size(100, 23);
            txtMontoExtraord.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(122, 143);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 7;
            label4.Text = "Monto Extraordinario";
            // 
            // btnRecargo
            // 
            btnRecargo.Location = new Point(243, 164);
            btnRecargo.Name = "btnRecargo";
            btnRecargo.Size = new Size(100, 23);
            btnRecargo.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(122, 172);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 9;
            label5.Text = "Recargo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(122, 201);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 11;
            label6.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(243, 201);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 12;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(55, 39);
            label7.Name = "label7";
            label7.Size = new Size(161, 50);
            label7.TabIndex = 20;
            label7.Text = "EXPENSAS";
            // 
            // cmbPorPropietario
            // 
            cmbPorPropietario.FormattingEnabled = true;
            cmbPorPropietario.Location = new Point(637, 578);
            cmbPorPropietario.Name = "cmbPorPropietario";
            cmbPorPropietario.Size = new Size(204, 23);
            cmbPorPropietario.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(623, 560);
            label8.Name = "label8";
            label8.Size = new Size(164, 15);
            label8.TabIndex = 21;
            label8.Text = "Buscar unidad Por propietario";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(623, 8);
            label9.Name = "label9";
            label9.Size = new Size(243, 50);
            label9.TabIndex = 23;
            label9.Text = "Detalle Expensas";
            // 
            // btnGenerarExcel
            // 
            btnGenerarExcel.Location = new Point(960, 564);
            btnGenerarExcel.Name = "btnGenerarExcel";
            btnGenerarExcel.Size = new Size(107, 37);
            btnGenerarExcel.TabIndex = 24;
            btnGenerarExcel.Text = "Generar Excel";
            btnGenerarExcel.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(847, 564);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(107, 37);
            btnBuscar.TabIndex = 25;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(122, 85);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 26;
            label10.Text = "Unidad";
            // 
            // cmbUnidad
            // 
            cmbUnidad.FormattingEnabled = true;
            cmbUnidad.Location = new Point(243, 77);
            cmbUnidad.Name = "cmbUnidad";
            cmbUnidad.Size = new Size(121, 23);
            cmbUnidad.TabIndex = 28;
            // 
            // btnInsertDetalle
            // 
            btnInsertDetalle.Location = new Point(288, 356);
            btnInsertDetalle.Name = "btnInsertDetalle";
            btnInsertDetalle.Size = new Size(107, 48);
            btnInsertDetalle.TabIndex = 29;
            btnInsertDetalle.Text = "Ingresar detalle";
            btnInsertDetalle.UseVisualStyleBackColor = true;
            btnInsertDetalle.Click += btnInsertDetalle_Click;
            // 
            // btnEliminarDetalle
            // 
            btnEliminarDetalle.Location = new Point(122, 302);
            btnEliminarDetalle.Name = "btnEliminarDetalle";
            btnEliminarDetalle.Size = new Size(107, 48);
            btnEliminarDetalle.TabIndex = 30;
            btnEliminarDetalle.Text = "Eliminar detalle";
            btnEliminarDetalle.UseVisualStyleBackColor = true;
            btnEliminarDetalle.Click += btnEliminarDetalle_Click;
            // 
            // btnModificarDetalle
            // 
            btnModificarDetalle.Location = new Point(122, 356);
            btnModificarDetalle.Name = "btnModificarDetalle";
            btnModificarDetalle.Size = new Size(107, 48);
            btnModificarDetalle.TabIndex = 31;
            btnModificarDetalle.Text = "Modificar detalle";
            btnModificarDetalle.UseVisualStyleBackColor = true;
            btnModificarDetalle.Click += btnModificarDetalle_Click;
            // 
            // button1
            // 
            button1.Location = new Point(288, 302);
            button1.Name = "button1";
            button1.Size = new Size(107, 48);
            button1.TabIndex = 32;
            button1.Text = "Consultar Expensas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ExpensasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 606);
            Controls.Add(button1);
            Controls.Add(btnModificarDetalle);
            Controls.Add(btnEliminarDetalle);
            Controls.Add(btnInsertDetalle);
            Controls.Add(cmbUnidad);
            Controls.Add(label10);
            Controls.Add(btnBuscar);
            Controls.Add(btnGenerarExcel);
            Controls.Add(label9);
            Controls.Add(cmbPorPropietario);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cmbEstado);
            Controls.Add(label6);
            Controls.Add(btnRecargo);
            Controls.Add(label5);
            Controls.Add(txtMontoExtraord);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtVencimiento);
            Controls.Add(label2);
            Controls.Add(dtEmision);
            Controls.Add(txtMontoOrd);
            Controls.Add(label1);
            Controls.Add(dgvExpensas);
            Name = "ExpensasForm";
            Text = "Expensas";
            Load += ExpensasForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExpensas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvExpensas;
        private Label label1;
        private TextBox txtMontoOrd;
        private DateTimePicker dtEmision;
        private Label label2;
        private Label label3;
        private DateTimePicker dtVencimiento;
        private TextBox txtMontoExtraord;
        private Label label4;
        private TextBox btnRecargo;
        private Label label5;
        private Label label6;
        private ComboBox cmbEstado;
        public Label label7;
        private ComboBox cmbPorPropietario;
        private Label label8;
        public Label label9;
        private Button btnGenerarExcel;
        private Button btnBuscar;
        private Label label10;
        private ComboBox cmbUnidad;
        private Button btnInsertDetalle;
        private Button btnEliminarDetalle;
        private Button btnModificarDetalle;
        private Button button1;
    }
}