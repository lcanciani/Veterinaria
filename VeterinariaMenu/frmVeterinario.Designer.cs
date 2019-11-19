namespace VeterinariaMenu
{
    partial class FrmVeterinario
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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumTelefono = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lstVeterinarios = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCiudades = new System.Windows.Forms.ComboBox();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.btnReporte = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.grpSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(157, 61);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(157, 113);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(157, 139);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtNumTelefono
            // 
            this.txtNumTelefono.Location = new System.Drawing.Point(157, 165);
            this.txtNumTelefono.Name = "txtNumTelefono";
            this.txtNumTelefono.Size = new System.Drawing.Size(168, 20);
            this.txtNumTelefono.TabIndex = 4;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(157, 35);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fecha Nacimiento";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(39, 307);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 30);
            this.btnCargar.TabIndex = 16;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(120, 307);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 30);
            this.btnModificar.TabIndex = 17;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(511, 292);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 50);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(201, 307);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(282, 307);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpiar.TabIndex = 20;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button5_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(157, 190);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 21;
            // 
            // lstVeterinarios
            // 
            this.lstVeterinarios.FormattingEnabled = true;
            this.lstVeterinarios.Location = new System.Drawing.Point(397, 61);
            this.lstVeterinarios.Name = "lstVeterinarios";
            this.lstVeterinarios.Size = new System.Drawing.Size(189, 225);
            this.lstVeterinarios.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ciudad de recidencia";
            // 
            // cboCiudades
            // 
            this.cboCiudades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCiudades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCiudades.FormattingEnabled = true;
            this.cboCiudades.Location = new System.Drawing.Point(157, 216);
            this.cboCiudades.Name = "cboCiudades";
            this.cboCiudades.Size = new System.Drawing.Size(200, 21);
            this.cboCiudades.Sorted = true;
            this.cboCiudades.TabIndex = 24;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rbtMasculino);
            this.grpSexo.Controls.Add(this.rbtFemenino);
            this.grpSexo.Location = new System.Drawing.Point(56, 243);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(301, 43);
            this.grpSexo.TabIndex = 25;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Seleccione sexo del D.N.I.";
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(41, 19);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 1;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(164, 19);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 0;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(363, 307);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 30);
            this.btnReporte.TabIndex = 26;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Lista de Veterinarios:";
            // 
            // FrmVeterinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 354);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.grpSexo);
            this.Controls.Add(this.cboCiudades);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstVeterinarios);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtNumTelefono);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Name = "FrmVeterinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinario";
            this.Load += new System.EventHandler(this.FrmVeterinario_Load);
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumTelefono;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ListBox lstVeterinarios;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCiudades;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label label9;
    }
}