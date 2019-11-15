namespace VeterinariaMenu
{
    partial class FrmTurnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txrNumTurno = new System.Windows.Forms.TextBox();
            this.txtApeDueño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomDueño = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTurnos = new System.Windows.Forms.DataGridView();
            this.txtNroTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipoUrg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomMascota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTurnos = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoMascotas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Turno";
            // 
            // txrNumTurno
            // 
            this.txrNumTurno.Location = new System.Drawing.Point(125, 54);
            this.txrNumTurno.Name = "txrNumTurno";
            this.txrNumTurno.Size = new System.Drawing.Size(153, 20);
            this.txrNumTurno.TabIndex = 1;
            // 
            // txtApeDueño
            // 
            this.txtApeDueño.Location = new System.Drawing.Point(125, 80);
            this.txtApeDueño.Name = "txtApeDueño";
            this.txtApeDueño.Size = new System.Drawing.Size(153, 20);
            this.txtApeDueño.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido del Dueño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha del Turno";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNomDueño
            // 
            this.txtNomDueño.Location = new System.Drawing.Point(125, 106);
            this.txtNomDueño.Name = "txtNomDueño";
            this.txtNomDueño.Size = new System.Drawing.Size(153, 20);
            this.txtNomDueño.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del Dueño";
            // 
            // dgvTurnos
            // 
            this.dgvTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnos.Location = new System.Drawing.Point(284, 54);
            this.dgvTurnos.Name = "dgvTurnos";
            this.dgvTurnos.Size = new System.Drawing.Size(462, 179);
            this.dgvTurnos.TabIndex = 8;
            // 
            // txtNroTel
            // 
            this.txtNroTel.Location = new System.Drawing.Point(125, 184);
            this.txtNroTel.Name = "txtNroTel";
            this.txtNroTel.Size = new System.Drawing.Size(153, 20);
            this.txtNroTel.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nro. Telefono";
            // 
            // txtTipoUrg
            // 
            this.txtTipoUrg.Location = new System.Drawing.Point(125, 158);
            this.txtTipoUrg.Name = "txtTipoUrg";
            this.txtTipoUrg.Size = new System.Drawing.Size(153, 20);
            this.txtTipoUrg.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tipo de Urgencia";
            // 
            // txtNomMascota
            // 
            this.txtNomMascota.Location = new System.Drawing.Point(125, 132);
            this.txtNomMascota.Name = "txtNomMascota";
            this.txtNomMascota.Size = new System.Drawing.Size(153, 20);
            this.txtNomMascota.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nombre de la Mascota";
            // 
            // dtpTurnos
            // 
            this.dtpTurnos.Location = new System.Drawing.Point(125, 236);
            this.dtpTurnos.Name = "dtpTurnos";
            this.dtpTurnos.Size = new System.Drawing.Size(200, 20);
            this.dtpTurnos.TabIndex = 17;
            // 
            // cmbTipoMascotas
            // 
            this.cmbTipoMascotas.FormattingEnabled = true;
            this.cmbTipoMascotas.Location = new System.Drawing.Point(125, 211);
            this.cmbTipoMascotas.Name = "cmbTipoMascotas";
            this.cmbTipoMascotas.Size = new System.Drawing.Size(153, 21);
            this.cmbTipoMascotas.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tipo de Mascota";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.TabIndex = 20;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(12, 331);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(108, 44);
            this.btnCargar.TabIndex = 21;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(126, 331);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 44);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(240, 331);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 44);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 387);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoMascotas);
            this.Controls.Add(this.dtpTurnos);
            this.Controls.Add(this.txtNroTel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTipoUrg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNomMascota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvTurnos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomDueño);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApeDueño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txrNumTurno);
            this.Controls.Add(this.label1);
            this.Name = "Turnos";
            this.Text = "Turnos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txrNumTurno;
        private System.Windows.Forms.TextBox txtApeDueño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomDueño;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTurnos;
        private System.Windows.Forms.TextBox txtNroTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipoUrg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomMascota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTurnos;
        private System.Windows.Forms.ComboBox cmbTipoMascotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}