
namespace formulario8_login
{
    partial class Fusuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fusuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.ComboBox();
            this.txtclave = new System.Windows.Forms.ComboBox();
            this.lstnivel = new System.Windows.Forms.ComboBox();
            this.bprimero = new System.Windows.Forms.Button();
            this.banterior = new System.Windows.Forms.Button();
            this.bsiguiente = new System.Windows.Forms.Button();
            this.bultimo = new System.Windows.Forms.Button();
            this.bnuevo = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.bactualizar = new System.Windows.Forms.Button();
            this._sistema_mdbDataSet = new formulario8_login._sistema_mdbDataSet();
            this.usernameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usernameTableAdapter = new formulario8_login._sistema_mdbDataSetTableAdapters.UsernameTableAdapter();
            this.usernameBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usernameBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._sistema_mdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESO DE USUARIO AL SISTEMA\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clave";
            // 
            // txtusuario
            // 
            this.txtusuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usernameBindingSource, "Nombre", true));
            this.txtusuario.FormattingEnabled = true;
            this.txtusuario.Location = new System.Drawing.Point(128, 73);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(121, 21);
            this.txtusuario.TabIndex = 4;
            // 
            // txtclave
            // 
            this.txtclave.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usernameBindingSource, "Clave", true));
            this.txtclave.FormattingEnabled = true;
            this.txtclave.Location = new System.Drawing.Point(128, 107);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(121, 21);
            this.txtclave.TabIndex = 5;
            // 
            // lstnivel
            // 
            this.lstnivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usernameBindingSource, "Nivel", true));
            this.lstnivel.FormattingEnabled = true;
            this.lstnivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.lstnivel.Location = new System.Drawing.Point(128, 142);
            this.lstnivel.Name = "lstnivel";
            this.lstnivel.Size = new System.Drawing.Size(121, 21);
            this.lstnivel.TabIndex = 6;
            // 
            // bprimero
            // 
            this.bprimero.Location = new System.Drawing.Point(20, 201);
            this.bprimero.Name = "bprimero";
            this.bprimero.Size = new System.Drawing.Size(80, 37);
            this.bprimero.TabIndex = 7;
            this.bprimero.Text = "Primero";
            this.bprimero.UseVisualStyleBackColor = true;
            this.bprimero.Click += new System.EventHandler(this.bprimero_Click);
            // 
            // banterior
            // 
            this.banterior.Location = new System.Drawing.Point(106, 201);
            this.banterior.Name = "banterior";
            this.banterior.Size = new System.Drawing.Size(80, 37);
            this.banterior.TabIndex = 8;
            this.banterior.Text = "Anterior";
            this.banterior.UseVisualStyleBackColor = true;
            this.banterior.Click += new System.EventHandler(this.banterior_Click);
            // 
            // bsiguiente
            // 
            this.bsiguiente.Location = new System.Drawing.Point(192, 203);
            this.bsiguiente.Name = "bsiguiente";
            this.bsiguiente.Size = new System.Drawing.Size(80, 37);
            this.bsiguiente.TabIndex = 9;
            this.bsiguiente.Text = "Siguiente";
            this.bsiguiente.UseVisualStyleBackColor = true;
            this.bsiguiente.Click += new System.EventHandler(this.bsiguiente_Click);
            // 
            // bultimo
            // 
            this.bultimo.Location = new System.Drawing.Point(278, 203);
            this.bultimo.Name = "bultimo";
            this.bultimo.Size = new System.Drawing.Size(80, 37);
            this.bultimo.TabIndex = 10;
            this.bultimo.Text = "Ultimo";
            this.bultimo.UseVisualStyleBackColor = true;
            this.bultimo.Click += new System.EventHandler(this.bultimo_Click);
            // 
            // bnuevo
            // 
            this.bnuevo.Location = new System.Drawing.Point(20, 254);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(80, 37);
            this.bnuevo.TabIndex = 11;
            this.bnuevo.Text = "nuevo";
            this.bnuevo.UseVisualStyleBackColor = true;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // beliminar
            // 
            this.beliminar.Location = new System.Drawing.Point(106, 254);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(80, 37);
            this.beliminar.TabIndex = 12;
            this.beliminar.Text = "eliminar";
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // bmodificar
            // 
            this.bmodificar.Location = new System.Drawing.Point(192, 254);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(80, 37);
            this.bmodificar.TabIndex = 13;
            this.bmodificar.Text = "modificar";
            this.bmodificar.UseVisualStyleBackColor = true;
            this.bmodificar.Click += new System.EventHandler(this.bmodificar_Click);
            // 
            // bsalir
            // 
            this.bsalir.Location = new System.Drawing.Point(278, 254);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(80, 37);
            this.bsalir.TabIndex = 14;
            this.bsalir.Text = "salir";
            this.bsalir.UseVisualStyleBackColor = true;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // bguardar
            // 
            this.bguardar.Location = new System.Drawing.Point(20, 254);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(80, 37);
            this.bguardar.TabIndex = 15;
            this.bguardar.Text = "guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // bactualizar
            // 
            this.bactualizar.Location = new System.Drawing.Point(192, 254);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(80, 37);
            this.bactualizar.TabIndex = 16;
            this.bactualizar.Text = "actualizar";
            this.bactualizar.UseVisualStyleBackColor = true;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // _sistema_mdbDataSet
            // 
            this._sistema_mdbDataSet.DataSetName = "_sistema_mdbDataSet";
            this._sistema_mdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usernameBindingSource
            // 
            this.usernameBindingSource.DataMember = "Username";
            this.usernameBindingSource.DataSource = this._sistema_mdbDataSet;
            // 
            // usernameTableAdapter
            // 
            this.usernameTableAdapter.ClearBeforeFill = true;
            // 
            // usernameBindingSource1
            // 
            this.usernameBindingSource1.DataMember = "Username";
            this.usernameBindingSource1.DataSource = this._sistema_mdbDataSet;
            // 
            // usernameBindingSource2
            // 
            this.usernameBindingSource2.DataMember = "Username";
            this.usernameBindingSource2.DataSource = this._sistema_mdbDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(278, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Fusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.bmodificar);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.bnuevo);
            this.Controls.Add(this.bultimo);
            this.Controls.Add(this.bsiguiente);
            this.Controls.Add(this.banterior);
            this.Controls.Add(this.bprimero);
            this.Controls.Add(this.lstnivel);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bguardar);
            this.Controls.Add(this.bactualizar);
            this.Name = "Fusuario";
            this.Text = "Fusuario";
            this.Load += new System.EventHandler(this.Fusuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this._sistema_mdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtusuario;
        private System.Windows.Forms.ComboBox txtclave;
        private System.Windows.Forms.ComboBox lstnivel;
        private System.Windows.Forms.Button bprimero;
        private System.Windows.Forms.Button banterior;
        private System.Windows.Forms.Button bsiguiente;
        private System.Windows.Forms.Button bultimo;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bactualizar;
        private _sistema_mdbDataSet _sistema_mdbDataSet;
        private System.Windows.Forms.BindingSource usernameBindingSource;
        private _sistema_mdbDataSetTableAdapters.UsernameTableAdapter usernameTableAdapter;
        private System.Windows.Forms.BindingSource usernameBindingSource2;
        private System.Windows.Forms.BindingSource usernameBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}