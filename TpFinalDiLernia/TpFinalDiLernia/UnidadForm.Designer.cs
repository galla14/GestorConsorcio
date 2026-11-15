namespace Consorcio.UI
{
    partial class UnidadForm
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
            dgvUnidad = new DataGridView();
            label1 = new Label();
            btnAgregar = new Button();
            label2 = new Label();
            txtPiso = new TextBox();
            txtDpto = new TextBox();
            label3 = new Label();
            txtMedida = new TextBox();
            label4 = new Label();
            gpbAptoAlq = new GroupBox();
            tdbNo = new RadioButton();
            rdbSi = new RadioButton();
            gpbAlquilado = new GroupBox();
            radioButton1 = new RadioButton();
            rdAlquilado = new RadioButton();
            btnModificar = new Button();
            btnConsultar = new Button();
            btnEliminar = new Button();
            cmbPropietarios = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUnidad).BeginInit();
            gpbAptoAlq.SuspendLayout();
            gpbAlquilado.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUnidad
            // 
            dgvUnidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnidad.Location = new Point(549, 12);
            dgvUnidad.Name = "dgvUnidad";
            dgvUnidad.Size = new Size(487, 503);
            dgvUnidad.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 29);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 1;
            label1.Text = "UNIDAD";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(86, 368);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(99, 41);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar Unidad";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 76);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Piso";
            label2.Click += label2_Click;
            // 
            // txtPiso
            // 
            txtPiso.Location = new Point(170, 73);
            txtPiso.Name = "txtPiso";
            txtPiso.Size = new Size(100, 23);
            txtPiso.TabIndex = 4;
            // 
            // txtDpto
            // 
            txtDpto.Location = new Point(170, 104);
            txtDpto.Name = "txtDpto";
            txtDpto.Size = new Size(100, 23);
            txtDpto.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 109);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 5;
            label3.Text = "Departamento";
            // 
            // txtMedida
            // 
            txtMedida.Location = new Point(170, 133);
            txtMedida.Name = "txtMedida";
            txtMedida.Size = new Size(100, 23);
            txtMedida.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 138);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 7;
            label4.Text = "Medida dpto";
            // 
            // gpbAptoAlq
            // 
            gpbAptoAlq.Controls.Add(tdbNo);
            gpbAptoAlq.Controls.Add(rdbSi);
            gpbAptoAlq.Location = new Point(89, 172);
            gpbAptoAlq.Name = "gpbAptoAlq";
            gpbAptoAlq.Size = new Size(201, 60);
            gpbAptoAlq.TabIndex = 13;
            gpbAptoAlq.TabStop = false;
            gpbAptoAlq.Text = "Apto alquiler";
            // 
            // tdbNo
            // 
            tdbNo.AutoSize = true;
            tdbNo.Location = new Point(101, 37);
            tdbNo.Name = "tdbNo";
            tdbNo.Size = new Size(41, 19);
            tdbNo.TabIndex = 11;
            tdbNo.TabStop = true;
            tdbNo.Text = "No";
            tdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbSi
            // 
            rdbSi.AutoSize = true;
            rdbSi.Location = new Point(8, 37);
            rdbSi.Name = "rdbSi";
            rdbSi.Size = new Size(34, 19);
            rdbSi.TabIndex = 10;
            rdbSi.TabStop = true;
            rdbSi.Text = "Si";
            rdbSi.UseVisualStyleBackColor = true;
            // 
            // gpbAlquilado
            // 
            gpbAlquilado.Controls.Add(radioButton1);
            gpbAlquilado.Controls.Add(rdAlquilado);
            gpbAlquilado.Location = new Point(89, 238);
            gpbAlquilado.Name = "gpbAlquilado";
            gpbAlquilado.Size = new Size(201, 60);
            gpbAlquilado.TabIndex = 14;
            gpbAlquilado.TabStop = false;
            gpbAlquilado.Text = "Alquilado";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(101, 37);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(41, 19);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "No";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdAlquilado
            // 
            rdAlquilado.AutoSize = true;
            rdAlquilado.Location = new Point(8, 37);
            rdAlquilado.Name = "rdAlquilado";
            rdAlquilado.Size = new Size(34, 19);
            rdAlquilado.TabIndex = 10;
            rdAlquilado.TabStop = true;
            rdAlquilado.Text = "Si";
            rdAlquilado.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(86, 415);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(99, 41);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Modificar Unidad";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(191, 415);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(99, 41);
            btnConsultar.TabIndex = 16;
            btnConsultar.Text = "Consultar unidad";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(191, 368);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 41);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar unidad";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cmbPropietarios
            // 
            cmbPropietarios.FormattingEnabled = true;
            cmbPropietarios.Location = new Point(170, 318);
            cmbPropietarios.Name = "cmbPropietarios";
            cmbPropietarios.Size = new Size(199, 23);
            cmbPropietarios.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(89, 326);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 19;
            label7.Text = "Propietarios";
            // 
            // UnidadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 527);
            Controls.Add(label7);
            Controls.Add(cmbPropietarios);
            Controls.Add(btnEliminar);
            Controls.Add(btnConsultar);
            Controls.Add(btnModificar);
            Controls.Add(gpbAlquilado);
            Controls.Add(gpbAptoAlq);
            Controls.Add(txtMedida);
            Controls.Add(label4);
            Controls.Add(txtDpto);
            Controls.Add(label3);
            Controls.Add(txtPiso);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(dgvUnidad);
            Name = "UnidadForm";
            Text = "UnidadForm";
            Load += UnidadForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUnidad).EndInit();
            gpbAptoAlq.ResumeLayout(false);
            gpbAptoAlq.PerformLayout();
            gpbAlquilado.ResumeLayout(false);
            gpbAlquilado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUnidad;
        private Label label1;
        private Button btnAgregar;
        private Label label2;
        private TextBox txtPiso;
        private TextBox txtDpto;
        private Label label3;
        private TextBox txtMedida;
        private Label label4;
        private GroupBox gpbAptoAlq;
        private RadioButton tdbNo;
        private RadioButton rdbSi;
        private GroupBox gpbAlquilado;
        private RadioButton radioButton1;
        private RadioButton rdAlquilado;
        private Button btnModificar;
        private Button btnConsultar;
        private Button btnEliminar;
        private ComboBox cmbPropietarios;
        private Label label7;
    }
}