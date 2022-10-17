
namespace formulario8_login
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.bentrar_access = new System.Windows.Forms.Button();
            this.bentrar_sqlserver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESO AL SISTEMA";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(71, 139);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(135, 20);
            this.txtclave.TabIndex = 1;
            // 
            // bentrar_access
            // 
            this.bentrar_access.Location = new System.Drawing.Point(10, 203);
            this.bentrar_access.Name = "bentrar_access";
            this.bentrar_access.Size = new System.Drawing.Size(105, 48);
            this.bentrar_access.TabIndex = 2;
            this.bentrar_access.Text = "Entrar Usando Access";
            this.bentrar_access.UseVisualStyleBackColor = true;
            this.bentrar_access.Click += new System.EventHandler(this.bentrar_access_Click);
            // 
            // bentrar_sqlserver
            // 
            this.bentrar_sqlserver.Location = new System.Drawing.Point(133, 203);
            this.bentrar_sqlserver.Name = "bentrar_sqlserver";
            this.bentrar_sqlserver.Size = new System.Drawing.Size(105, 48);
            this.bentrar_sqlserver.TabIndex = 3;
            this.bentrar_sqlserver.Text = "Entrar Usando SQL Server";
            this.bentrar_sqlserver.UseVisualStyleBackColor = true;
            this.bentrar_sqlserver.Click += new System.EventHandler(this.bentrar_sqlserver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "clave";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(71, 90);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(167, 20);
            this.txtusuario.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 280);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bentrar_sqlserver);
            this.Controls.Add(this.bentrar_access);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Button bentrar_access;
        private System.Windows.Forms.Button bentrar_sqlserver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

