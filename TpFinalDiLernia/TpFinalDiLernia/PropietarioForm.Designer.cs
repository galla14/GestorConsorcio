namespace TpFinalDiLernia
{
    partial class PropietarioForm
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
            dgvPropietario = new DataGridView();
            btnAgregarProp = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            btnConsPropietarios = new Button();
            txtNroCel = new TextBox();
            label4 = new Label();
            btnEliminarProp = new Button();
            btnModificarProp = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPropietario).BeginInit();
            SuspendLayout();
            // 
            // dgvPropietario
            // 
            dgvPropietario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropietario.Location = new Point(424, 12);
            dgvPropietario.Name = "dgvPropietario";
            dgvPropietario.RowHeadersWidth = 51;
            dgvPropietario.Size = new Size(454, 420);
            dgvPropietario.TabIndex = 0;
            // 
            // btnAgregarProp
            // 
            btnAgregarProp.Location = new Point(63, 191);
            btnAgregarProp.Name = "btnAgregarProp";
            btnAgregarProp.Size = new Size(116, 49);
            btnAgregarProp.TabIndex = 1;
            btnAgregarProp.Text = "Agregar propietario";
            btnAgregarProp.UseVisualStyleBackColor = true;
            btnAgregarProp.Click += btnAgregarProp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 73);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 102);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 4;
            label3.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(137, 65);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(137, 94);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 7;
            // 
            // btnConsPropietarios
            // 
            btnConsPropietarios.Location = new Point(63, 247);
            btnConsPropietarios.Name = "btnConsPropietarios";
            btnConsPropietarios.Size = new Size(116, 49);
            btnConsPropietarios.TabIndex = 8;
            btnConsPropietarios.Text = "Consultar propietarios";
            btnConsPropietarios.UseVisualStyleBackColor = true;
            btnConsPropietarios.Click += btnConsPropietarios_Click;
            // 
            // txtNroCel
            // 
            txtNroCel.Location = new Point(137, 120);
            txtNroCel.Name = "txtNroCel";
            txtNroCel.Size = new Size(100, 23);
            txtNroCel.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 128);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 9;
            label4.Text = "Nro Celular";
            // 
            // btnEliminarProp
            // 
            btnEliminarProp.Location = new Point(63, 302);
            btnEliminarProp.Name = "btnEliminarProp";
            btnEliminarProp.Size = new Size(116, 49);
            btnEliminarProp.TabIndex = 11;
            btnEliminarProp.Text = "Eliminar Propietario";
            btnEliminarProp.UseVisualStyleBackColor = true;
            btnEliminarProp.Click += btnEliminarProp_Click;
            // 
            // btnModificarProp
            // 
            btnModificarProp.Location = new Point(63, 357);
            btnModificarProp.Name = "btnModificarProp";
            btnModificarProp.Size = new Size(116, 49);
            btnModificarProp.TabIndex = 12;
            btnModificarProp.Text = "Modificar Propietario";
            btnModificarProp.UseVisualStyleBackColor = true;
            btnModificarProp.Click += btnModificarProp_Click;
            // 
            // PropietarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 444);
            Controls.Add(btnModificarProp);
            Controls.Add(btnEliminarProp);
            Controls.Add(txtNroCel);
            Controls.Add(label4);
            Controls.Add(btnConsPropietarios);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregarProp);
            Controls.Add(dgvPropietario);
            Name = "PropietarioForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPropietario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPropietario;
        private Button btnAgregarProp;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private Button btnConsPropietarios;
        private TextBox txtNroCel;
        private Label label4;
        private Button btnEliminarProp;
        private Button btnModificarProp;
    }
}
