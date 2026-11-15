namespace Consorcio.UI
{
    partial class GestionUser
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
            dgvUsuarios = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnCrearUser = new Button();
            btnModifUser = new Button();
            btnEliminarUser = new Button();
            btnDesbloquear = new Button();
            btnConsultUser = new Button();
            label4 = new Label();
            cmbRol = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(598, 12);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(604, 553);
            dgvUsuarios.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(64, 69);
            label1.Name = "label1";
            label1.Size = new Size(226, 32);
            label1.TabIndex = 1;
            label1.Text = "Gestion de Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 139);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 170);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(158, 136);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 23);
            txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(158, 168);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 5;
            // 
            // btnCrearUser
            // 
            btnCrearUser.Location = new Point(62, 256);
            btnCrearUser.Name = "btnCrearUser";
            btnCrearUser.Size = new Size(111, 41);
            btnCrearUser.TabIndex = 6;
            btnCrearUser.Text = "Crear Usuario";
            btnCrearUser.UseVisualStyleBackColor = true;
            btnCrearUser.Click += btnCrearUser_Click;
            // 
            // btnModifUser
            // 
            btnModifUser.Location = new Point(179, 256);
            btnModifUser.Name = "btnModifUser";
            btnModifUser.Size = new Size(111, 41);
            btnModifUser.TabIndex = 7;
            btnModifUser.Text = "Modificar Usuario";
            btnModifUser.UseVisualStyleBackColor = true;
            btnModifUser.Click += btnModifUser_Click;
            // 
            // btnEliminarUser
            // 
            btnEliminarUser.Location = new Point(62, 314);
            btnEliminarUser.Name = "btnEliminarUser";
            btnEliminarUser.Size = new Size(111, 41);
            btnEliminarUser.TabIndex = 8;
            btnEliminarUser.Text = "Eliminar Usuario";
            btnEliminarUser.UseVisualStyleBackColor = true;
            btnEliminarUser.Click += btnEliminarUser_Click;
            // 
            // btnDesbloquear
            // 
            btnDesbloquear.Location = new Point(179, 314);
            btnDesbloquear.Name = "btnDesbloquear";
            btnDesbloquear.Size = new Size(111, 41);
            btnDesbloquear.TabIndex = 9;
            btnDesbloquear.Text = "Desbloquear Usuario";
            btnDesbloquear.UseVisualStyleBackColor = true;
            btnDesbloquear.Click += btnDesbloquear_Click;
            // 
            // btnConsultUser
            // 
            btnConsultUser.Location = new Point(62, 370);
            btnConsultUser.Name = "btnConsultUser";
            btnConsultUser.Size = new Size(111, 41);
            btnConsultUser.TabIndex = 10;
            btnConsultUser.Text = "Consultar usuarios";
            btnConsultUser.UseVisualStyleBackColor = true;
            btnConsultUser.Click += btnConsultUser_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 205);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 11;
            label4.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(158, 202);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(121, 23);
            cmbRol.TabIndex = 12;
            cmbRol.SelectedIndexChanged += cmbRol_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(12, 460);
            label5.Name = "label5";
            label5.Size = new Size(501, 30);
            label5.TabIndex = 13;
            label5.Text = "Eliminar solo desactiva de manera logica al usuario";
            // 
            // GestionUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1214, 577);
            Controls.Add(label5);
            Controls.Add(cmbRol);
            Controls.Add(label4);
            Controls.Add(btnConsultUser);
            Controls.Add(btnDesbloquear);
            Controls.Add(btnEliminarUser);
            Controls.Add(btnModifUser);
            Controls.Add(btnCrearUser);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Name = "GestionUser";
            Text = "GestionUser";
            Load += GestionUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnCrearUser;
        private Button btnModifUser;
        private Button btnEliminarUser;
        private Button btnDesbloquear;
        private Button btnConsultUser;
        private Label label4;
        private ComboBox cmbRol;
        private Label label5;
    }
}