namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt1 = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.Label();
            this.checkPreference = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnStatus);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.checkPreference);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txt4);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.txt3);
            this.panel1.Controls.Add(this.txtBD);
            this.panel1.Controls.Add(this.txt2);
            this.panel1.Controls.Add(this.txtServer);
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 225);
            this.panel1.TabIndex = 0;
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Location = new System.Drawing.Point(35, 19);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(46, 13);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "Servidor";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(38, 36);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(100, 20);
            this.txtServer.TabIndex = 1;
            // 
            // txtBD
            // 
            this.txtBD.Location = new System.Drawing.Point(38, 80);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(100, 20);
            this.txtBD.TabIndex = 3;
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Location = new System.Drawing.Point(35, 63);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(75, 13);
            this.txt2.TabIndex = 2;
            this.txt2.Text = "Base de datos";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(197, 36);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 5;
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.Location = new System.Drawing.Point(194, 19);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(43, 13);
            this.txt3.TabIndex = 4;
            this.txt3.Text = "Usuario";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(197, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txt4
            // 
            this.txt4.AutoSize = true;
            this.txt4.Location = new System.Drawing.Point(194, 63);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(61, 13);
            this.txt4.TabIndex = 6;
            this.txt4.Text = "Contraseña";
            // 
            // checkPreference
            // 
            this.checkPreference.AutoSize = true;
            this.checkPreference.Location = new System.Drawing.Point(38, 119);
            this.checkPreference.Name = "checkPreference";
            this.checkPreference.Size = new System.Drawing.Size(138, 17);
            this.checkPreference.TabIndex = 8;
            this.checkPreference.Text = "Autenticación integrada";
            this.checkPreference.UseVisualStyleBackColor = true;
            this.checkPreference.CheckedChanged += new System.EventHandler(this.checkPreference_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(38, 161);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(119, 161);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(75, 23);
            this.btnStatus.TabIndex = 10;
            this.btnStatus.Text = "Estado";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(217, 161);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Desconectar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 225);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Conexión a un origen de datos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox checkPreference;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label txt4;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label txt3;
        private System.Windows.Forms.TextBox txtBD;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label txt1;
    }
}

