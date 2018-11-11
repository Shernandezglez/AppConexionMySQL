namespace AppConexionSGBDR
{
    partial class ConexionSQL
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnEjecutarSentencia = new System.Windows.Forms.Button();
            this.btnCerrarConexion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSentence = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(104, 12);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(100, 20);
            this.txtHost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuario:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(104, 71);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña: ";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(104, 142);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Puerto:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(104, 220);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 9;
            // 
            // btnEjecutarSentencia
            // 
            this.btnEjecutarSentencia.Location = new System.Drawing.Point(1022, 127);
            this.btnEjecutarSentencia.Name = "btnEjecutarSentencia";
            this.btnEjecutarSentencia.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutarSentencia.TabIndex = 16;
            this.btnEjecutarSentencia.Text = "Ejecutar";
            this.btnEjecutarSentencia.UseVisualStyleBackColor = true;
            this.btnEjecutarSentencia.Click += new System.EventHandler(this.btnEjecutarSentencia_Click);
            // 
            // btnCerrarConexion
            // 
            this.btnCerrarConexion.Location = new System.Drawing.Point(1038, 556);
            this.btnCerrarConexion.Name = "btnCerrarConexion";
            this.btnCerrarConexion.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarConexion.TabIndex = 15;
            this.btnCerrarConexion.Text = "Salir";
            this.btnCerrarConexion.UseVisualStyleBackColor = true;
            this.btnCerrarConexion.Click += new System.EventHandler(this.btnCerrarConexion_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(652, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Resultado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(652, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sentencia";
            // 
            // txtSentence
            // 
            this.txtSentence.Location = new System.Drawing.Point(411, 26);
            this.txtSentence.Multiline = true;
            this.txtSentence.Name = "txtSentence";
            this.txtSentence.Size = new System.Drawing.Size(538, 78);
            this.txtSentence.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "BD";
            // 
            // txtBD
            // 
            this.txtBD.Location = new System.Drawing.Point(104, 293);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(100, 20);
            this.txtBD.TabIndex = 17;
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.Location = new System.Drawing.Point(411, 211);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(538, 407);
            this.lstResultado.TabIndex = 19;
            // 
            // ConexionSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 631);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.btnEjecutarSentencia);
            this.Controls.Add(this.btnCerrarConexion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSentence);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.button1);
            this.Name = "ConexionSQL";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnEjecutarSentencia;
        private System.Windows.Forms.Button btnCerrarConexion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSentence;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBD;
        private System.Windows.Forms.ListBox lstResultado;
    }
}

