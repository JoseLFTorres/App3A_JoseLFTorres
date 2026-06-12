namespace App3A.Cafeteria
{
    public partial class frmCafeteria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSuero = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.lblExtra = new System.Windows.Forms.Label();
            this.cmbTamano = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbFrio = new System.Windows.Forms.RadioButton();
            this.rdbCaliente = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lsbBebidas = new System.Windows.Forms.ListBox();
            this.chkAzucar = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAzucar);
            this.groupBox1.Controls.Add(this.rdbSuero);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtExtra);
            this.groupBox1.Controls.Add(this.lblExtra);
            this.groupBox1.Controls.Add(this.cmbTamano);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbFrio);
            this.groupBox1.Controls.Add(this.rdbCaliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 608);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE BEBIDAS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbSuero
            // 
            this.rdbSuero.AutoSize = true;
            this.rdbSuero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.rdbSuero.Location = new System.Drawing.Point(150, 85);
            this.rdbSuero.Name = "rdbSuero";
            this.rdbSuero.Size = new System.Drawing.Size(79, 24);
            this.rdbSuero.TabIndex = 11;
            this.rdbSuero.TabStop = true;
            this.rdbSuero.Text = "Suero";
            this.rdbSuero.UseVisualStyleBackColor = true;
            this.rdbSuero.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(118, 486);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(131, 59);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(15, 348);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.Size = new System.Drawing.Size(360, 34);
            this.txtExtra.TabIndex = 9;
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(6, 314);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(163, 29);
            this.lblExtra.TabIndex = 8;
            this.lblExtra.Text = "Temperatura";
            // 
            // cmbTamano
            // 
            this.cmbTamano.FormattingEnabled = true;
            this.cmbTamano.Items.AddRange(new object[] {
            "Chico",
            "Mediano",
            "Grande"});
            this.cmbTamano.Location = new System.Drawing.Point(11, 274);
            this.cmbTamano.Name = "cmbTamano";
            this.cmbTamano.Size = new System.Drawing.Size(360, 37);
            this.cmbTamano.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tamaño";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(11, 205);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(360, 34);
            this.txtPrecio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(11, 136);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(360, 34);
            this.txtNombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // rdbFrio
            // 
            this.rdbFrio.AutoSize = true;
            this.rdbFrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFrio.Location = new System.Drawing.Point(224, 55);
            this.rdbFrio.Name = "rdbFrio";
            this.rdbFrio.Size = new System.Drawing.Size(147, 24);
            this.rdbFrio.TabIndex = 1;
            this.rdbFrio.TabStop = true;
            this.rdbFrio.Text = "Bebidas Frias";
            this.rdbFrio.UseVisualStyleBackColor = true;
            // 
            // rdbCaliente
            // 
            this.rdbCaliente.AutoSize = true;
            this.rdbCaliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCaliente.Location = new System.Drawing.Point(6, 55);
            this.rdbCaliente.Name = "rdbCaliente";
            this.rdbCaliente.Size = new System.Drawing.Size(183, 24);
            this.rdbCaliente.TabIndex = 0;
            this.rdbCaliente.TabStop = true;
            this.rdbCaliente.Text = "Bebidas Calientes";
            this.rdbCaliente.UseVisualStyleBackColor = true;
            this.rdbCaliente.CheckedChanged += new System.EventHandler(this.rdbCaliente_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCantidad);
            this.groupBox2.Controls.Add(this.lblDescripcion);
            this.groupBox2.Controls.Add(this.lsbBebidas);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(428, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 608);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bebidas Registradas";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(6, 501);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(277, 29);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "0 Bebidas Registradas";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(6, 413);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(166, 29);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion: ";
            // 
            // lsbBebidas
            // 
            this.lsbBebidas.FormattingEnabled = true;
            this.lsbBebidas.ItemHeight = 29;
            this.lsbBebidas.Location = new System.Drawing.Point(6, 59);
            this.lsbBebidas.Name = "lsbBebidas";
            this.lsbBebidas.Size = new System.Drawing.Size(438, 323);
            this.lsbBebidas.TabIndex = 0;
            this.lsbBebidas.SelectedIndexChanged += new System.EventHandler(this.lsbBebidas_SelectedIndexChanged);
            // 
            // chkAzucar
            // 
            this.chkAzucar.AutoSize = true;
            this.chkAzucar.Location = new System.Drawing.Point(15, 413);
            this.chkAzucar.Name = "chkAzucar";
            this.chkAzucar.Size = new System.Drawing.Size(172, 33);
            this.chkAzucar.TabIndex = 12;
            this.chkAzucar.Text = "Con azúcar ";
            this.chkAzucar.UseVisualStyleBackColor = true;
            // 
            // frmCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(890, 632);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCafeteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCafeteria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCaliente;
        private System.Windows.Forms.RadioButton rdbFrio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTamano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ListBox lsbBebidas;
        private System.Windows.Forms.RadioButton rdbSuero;
        private System.Windows.Forms.CheckBox chkAzucar;
    }
}