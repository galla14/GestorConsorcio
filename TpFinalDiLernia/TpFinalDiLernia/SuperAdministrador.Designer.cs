namespace Consorcio.UI
{
    partial class SuperAdministrador
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
            btnExpensas = new Button();
            btnPropietario = new Button();
            btnUnidad = new Button();
            btnPago = new Button();
            btnGestionUser = new Button();
            label1 = new Label();
            btnRoles = new Button();
            SuspendLayout();
            // 
            // btnExpensas
            // 
            btnExpensas.Location = new Point(349, 377);
            btnExpensas.Margin = new Padding(4, 5, 4, 5);
            btnExpensas.Name = "btnExpensas";
            btnExpensas.Size = new Size(167, 80);
            btnExpensas.TabIndex = 0;
            btnExpensas.Text = "Expensas";
            btnExpensas.UseVisualStyleBackColor = true;
            btnExpensas.Click += btnExpensas_Click;
            // 
            // btnPropietario
            // 
            btnPropietario.Location = new Point(121, 375);
            btnPropietario.Margin = new Padding(4, 5, 4, 5);
            btnPropietario.Name = "btnPropietario";
            btnPropietario.Size = new Size(167, 80);
            btnPropietario.TabIndex = 1;
            btnPropietario.Text = "Propietario";
            btnPropietario.UseVisualStyleBackColor = true;
            btnPropietario.Click += btnPropietario_Click;
            // 
            // btnUnidad
            // 
            btnUnidad.Location = new Point(551, 375);
            btnUnidad.Margin = new Padding(4, 5, 4, 5);
            btnUnidad.Name = "btnUnidad";
            btnUnidad.Size = new Size(167, 80);
            btnUnidad.TabIndex = 2;
            btnUnidad.Text = "Unidad";
            btnUnidad.UseVisualStyleBackColor = true;
            btnUnidad.Click += btnUnidad_Click;
            // 
            // btnPago
            // 
            btnPago.Location = new Point(761, 377);
            btnPago.Margin = new Padding(4, 5, 4, 5);
            btnPago.Name = "btnPago";
            btnPago.Size = new Size(167, 80);
            btnPago.TabIndex = 3;
            btnPago.Text = "Pago";
            btnPago.UseVisualStyleBackColor = true;
            btnPago.Click += btnPago_Click;
            // 
            // btnGestionUser
            // 
            btnGestionUser.Location = new Point(121, 465);
            btnGestionUser.Margin = new Padding(4, 5, 4, 5);
            btnGestionUser.Name = "btnGestionUser";
            btnGestionUser.Size = new Size(167, 80);
            btnGestionUser.TabIndex = 4;
            btnGestionUser.Text = "Gestion User";
            btnGestionUser.UseVisualStyleBackColor = true;
            btnGestionUser.Visible = false;
            btnGestionUser.Click += btnGestionUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F);
            label1.Location = new Point(99, 197);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 74);
            label1.TabIndex = 5;
            label1.Text = "Menu";
            // 
            // btnRoles
            // 
            btnRoles.Location = new Point(349, 467);
            btnRoles.Margin = new Padding(4, 5, 4, 5);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(167, 80);
            btnRoles.TabIndex = 6;
            btnRoles.Text = "Gestion Roles";
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Visible = false;
            btnRoles.Click += btnRoles_Click;
            // 
            // SuperAdministrador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 797);
            Controls.Add(btnRoles);
            Controls.Add(label1);
            Controls.Add(btnGestionUser);
            Controls.Add(btnPago);
            Controls.Add(btnUnidad);
            Controls.Add(btnPropietario);
            Controls.Add(btnExpensas);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SuperAdministrador";
            Text = "SuperAdministrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExpensas;
        private Button btnPropietario;
        private Button btnUnidad;
        private Button btnPago;
        private Button btnGestionUser;
        private Label label1;
        private Button btnRoles;
    }
}