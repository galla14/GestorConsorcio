namespace Consorcio.UI
{
    partial class GestionRoles
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
            dgvPermisos = new DataGridView();
            dgvRoles = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnCrearRol = new Button();
            btnEliminarRol = new Button();
            btnAgregarPermiso = new Button();
            btnSacarPermiso = new Button();
            txtNombreRol = new TextBox();
            label3 = new Label();
            tvRol = new TreeView();
            label4 = new Label();
            btnConsRol = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            SuspendLayout();
            // 
            // dgvPermisos
            // 
            dgvPermisos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPermisos.Location = new Point(380, 57);
            dgvPermisos.Name = "dgvPermisos";
            dgvPermisos.RowHeadersWidth = 62;
            dgvPermisos.Size = new Size(474, 576);
            dgvPermisos.TabIndex = 0;
            // 
            // dgvRoles
            // 
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new Point(894, 57);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowHeadersWidth = 62;
            dgvRoles.Size = new Size(430, 576);
            dgvRoles.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(380, 23);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 2;
            label1.Text = "Permisos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(894, 23);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 3;
            label2.Text = "Roles";
            // 
            // btnCrearRol
            // 
            btnCrearRol.Location = new Point(41, 333);
            btnCrearRol.Name = "btnCrearRol";
            btnCrearRol.Size = new Size(100, 42);
            btnCrearRol.TabIndex = 4;
            btnCrearRol.Text = "Crear Rol";
            btnCrearRol.UseVisualStyleBackColor = true;
            btnCrearRol.Click += btnCrearRol_Click_1;
            // 
            // btnEliminarRol
            // 
            btnEliminarRol.Location = new Point(159, 333);
            btnEliminarRol.Name = "btnEliminarRol";
            btnEliminarRol.Size = new Size(100, 42);
            btnEliminarRol.TabIndex = 5;
            btnEliminarRol.Text = "Eliminar Rol";
            btnEliminarRol.UseVisualStyleBackColor = true;
            btnEliminarRol.Click += btnEliminarRol_Click;
            // 
            // btnAgregarPermiso
            // 
            btnAgregarPermiso.Location = new Point(41, 385);
            btnAgregarPermiso.Name = "btnAgregarPermiso";
            btnAgregarPermiso.Size = new Size(100, 42);
            btnAgregarPermiso.TabIndex = 6;
            btnAgregarPermiso.Text = "Agregar Permiso";
            btnAgregarPermiso.UseVisualStyleBackColor = true;
            btnAgregarPermiso.Click += btnAgregarPermiso_Click;
            // 
            // btnSacarPermiso
            // 
            btnSacarPermiso.Location = new Point(159, 385);
            btnSacarPermiso.Name = "btnSacarPermiso";
            btnSacarPermiso.Size = new Size(100, 42);
            btnSacarPermiso.TabIndex = 7;
            btnSacarPermiso.Text = "Sacar Permiso";
            btnSacarPermiso.UseVisualStyleBackColor = true;
            btnSacarPermiso.Click += btnSacarPermiso_Click;
            // 
            // txtNombreRol
            // 
            txtNombreRol.Location = new Point(159, 279);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.Size = new Size(100, 23);
            txtNombreRol.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 287);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 9;
            label3.Text = "Nombre Rol";
            // 
            // tvRol
            // 
            tvRol.Location = new Point(159, 68);
            tvRol.Name = "tvRol";
            tvRol.Size = new Size(195, 190);
            tvRol.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 44);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 11;
            label4.Text = "Roles";
            // 
            // btnConsRol
            // 
            btnConsRol.Location = new Point(41, 433);
            btnConsRol.Name = "btnConsRol";
            btnConsRol.Size = new Size(100, 42);
            btnConsRol.TabIndex = 12;
            btnConsRol.Text = "Consultar Rol";
            btnConsRol.UseVisualStyleBackColor = true;
            btnConsRol.Click += btnConsRol_Click;
            // 
            // GestionRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 639);
            Controls.Add(btnConsRol);
            Controls.Add(label4);
            Controls.Add(tvRol);
            Controls.Add(label3);
            Controls.Add(txtNombreRol);
            Controls.Add(btnSacarPermiso);
            Controls.Add(btnAgregarPermiso);
            Controls.Add(btnEliminarRol);
            Controls.Add(btnCrearRol);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvRoles);
            Controls.Add(dgvPermisos);
            Name = "GestionRoles";
            Text = "GestionRoles";
            ((System.ComponentModel.ISupportInitialize)dgvPermisos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPermisos;
        private DataGridView dgvRoles;
        private Label label1;
        private Label label2;
        private Button btnCrearRol;
        private Button btnEliminarRol;
        private Button btnAgregarPermiso;
        private Button btnSacarPermiso;
        private TextBox txtNombreRol;
        private Label label3;
        private TreeView tvRol;
        private Label label4;
        private Button btnConsRol;
    }
}