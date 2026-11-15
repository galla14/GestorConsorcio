namespace Consorcio.UI
{
    partial class Form1
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
            txtUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPassw = new TextBox();
            btnIniciarSesion = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(400, 136);
            txtUser.Margin = new Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(171, 27);
            txtUser.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 143);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 1;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 181);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // txtPassw
            // 
            txtPassw.Location = new Point(400, 175);
            txtPassw.Margin = new Padding(3, 4, 3, 4);
            txtPassw.Name = "txtPassw";
            txtPassw.PasswordChar = '*';
            txtPassw.Size = new Size(171, 27);
            txtPassw.TabIndex = 2;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(319, 232);
            btnIniciarSesion.Margin = new Padding(3, 4, 3, 4);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(104, 55);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "Iniciar sesion";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(91, 441);
            label3.Name = "label3";
            label3.Size = new Size(737, 41);
            label3.TabIndex = 5;
            label3.Text = "Solo superadmin tiene permisos de modificar usuarios";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label3);
            Controls.Add(btnIniciarSesion);
            Controls.Add(label2);
            Controls.Add(txtPassw);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private Label label1;
        private Label label2;
        private TextBox txtPassw;
        private Button btnIniciarSesion;
        private Label label3;
    }
}