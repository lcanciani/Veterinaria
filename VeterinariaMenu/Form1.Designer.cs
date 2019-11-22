namespace VeterinariaMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarMascotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTurnosAgendadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarCuadroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorOscuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulMarinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeOscuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coloresClarosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azulClaroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verdeAguaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caballitioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.veterinarioToolStripMenuItem,
            this.empleadoToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.nuevoToolStripMenuItem.Text = "Veterinaria";
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pacienteToolStripMenuItem.Text = "Mascotas...";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // veterinarioToolStripMenuItem
            // 
            this.veterinarioToolStripMenuItem.Name = "veterinarioToolStripMenuItem";
            this.veterinarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.veterinarioToolStripMenuItem.Text = "Veterinarios...";
            this.veterinarioToolStripMenuItem.Click += new System.EventHandler(this.veterinarioToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadoToolStripMenuItem.Text = "Propietarios";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // mostrarMascotaToolStripMenuItem
            // 
            this.mostrarMascotaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTurnosAgendadosToolStripMenuItem});
            this.mostrarMascotaToolStripMenuItem.Name = "mostrarMascotaToolStripMenuItem";
            this.mostrarMascotaToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.mostrarMascotaToolStripMenuItem.Text = "Turnos Agendados";
            // 
            // verTurnosAgendadosToolStripMenuItem
            // 
            this.verTurnosAgendadosToolStripMenuItem.Name = "verTurnosAgendadosToolStripMenuItem";
            this.verTurnosAgendadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verTurnosAgendadosToolStripMenuItem.Text = "Turnos...";
            this.verTurnosAgendadosToolStripMenuItem.Click += new System.EventHandler(this.verTurnosAgendadosToolStripMenuItem_Click);
            // 
            // teToolStripMenuItem
            // 
            this.teToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.contactosToolStripMenuItem1,
            this.personalizarCuadroToolStripMenuItem});
            this.teToolStripMenuItem.Name = "teToolStripMenuItem";
            this.teToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.teToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // contactosToolStripMenuItem1
            // 
            this.contactosToolStripMenuItem1.Name = "contactosToolStripMenuItem1";
            this.contactosToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.contactosToolStripMenuItem1.Text = "Contactos ";
            this.contactosToolStripMenuItem1.Click += new System.EventHandler(this.contactosToolStripMenuItem1_Click);
            // 
            // personalizarCuadroToolStripMenuItem
            // 
            this.personalizarCuadroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorOscuroToolStripMenuItem,
            this.coloresClarosToolStripMenuItem,
            this.imagenesToolStripMenuItem});
            this.personalizarCuadroToolStripMenuItem.Name = "personalizarCuadroToolStripMenuItem";
            this.personalizarCuadroToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.personalizarCuadroToolStripMenuItem.Text = "Personalizar Fondo";
            // 
            // colorOscuroToolStripMenuItem
            // 
            this.colorOscuroToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.colorOscuroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negroToolStripMenuItem,
            this.azulMarinoToolStripMenuItem,
            this.verdeOscuroToolStripMenuItem});
            this.colorOscuroToolStripMenuItem.Name = "colorOscuroToolStripMenuItem";
            this.colorOscuroToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.colorOscuroToolStripMenuItem.Text = "Colores Oscuros";
            this.colorOscuroToolStripMenuItem.Click += new System.EventHandler(this.colorOscuroToolStripMenuItem_Click);
            // 
            // negroToolStripMenuItem
            // 
            this.negroToolStripMenuItem.Name = "negroToolStripMenuItem";
            this.negroToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.negroToolStripMenuItem.Text = "Negro";
            this.negroToolStripMenuItem.Click += new System.EventHandler(this.negroToolStripMenuItem_Click);
            // 
            // azulMarinoToolStripMenuItem
            // 
            this.azulMarinoToolStripMenuItem.Name = "azulMarinoToolStripMenuItem";
            this.azulMarinoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.azulMarinoToolStripMenuItem.Text = "Azul Marino";
            this.azulMarinoToolStripMenuItem.Click += new System.EventHandler(this.azulMarinoToolStripMenuItem_Click);
            // 
            // verdeOscuroToolStripMenuItem
            // 
            this.verdeOscuroToolStripMenuItem.Name = "verdeOscuroToolStripMenuItem";
            this.verdeOscuroToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.verdeOscuroToolStripMenuItem.Text = "Verde Oscuro";
            this.verdeOscuroToolStripMenuItem.Click += new System.EventHandler(this.verdeOscuroToolStripMenuItem_Click);
            // 
            // coloresClarosToolStripMenuItem
            // 
            this.coloresClarosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blancoToolStripMenuItem,
            this.azulClaroToolStripMenuItem,
            this.verdeAguaToolStripMenuItem});
            this.coloresClarosToolStripMenuItem.Name = "coloresClarosToolStripMenuItem";
            this.coloresClarosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.coloresClarosToolStripMenuItem.Text = "Colores Claros";
            // 
            // blancoToolStripMenuItem
            // 
            this.blancoToolStripMenuItem.Name = "blancoToolStripMenuItem";
            this.blancoToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.blancoToolStripMenuItem.Text = "Blanco";
            this.blancoToolStripMenuItem.Click += new System.EventHandler(this.blancoToolStripMenuItem_Click);
            // 
            // azulClaroToolStripMenuItem
            // 
            this.azulClaroToolStripMenuItem.Name = "azulClaroToolStripMenuItem";
            this.azulClaroToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.azulClaroToolStripMenuItem.Text = "Azul Claro";
            this.azulClaroToolStripMenuItem.Click += new System.EventHandler(this.azulClaroToolStripMenuItem_Click);
            // 
            // verdeAguaToolStripMenuItem
            // 
            this.verdeAguaToolStripMenuItem.Name = "verdeAguaToolStripMenuItem";
            this.verdeAguaToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.verdeAguaToolStripMenuItem.Text = "Verde Agua";
            this.verdeAguaToolStripMenuItem.Click += new System.EventHandler(this.verdeAguaToolStripMenuItem_Click);
            // 
            // imagenesToolStripMenuItem
            // 
            this.imagenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caballitioToolStripMenuItem});
            this.imagenesToolStripMenuItem.Name = "imagenesToolStripMenuItem";
            this.imagenesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.imagenesToolStripMenuItem.Text = "imagenes";
            // 
            // caballitioToolStripMenuItem
            // 
            this.caballitioToolStripMenuItem.Name = "caballitioToolStripMenuItem";
            this.caballitioToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.caballitioToolStripMenuItem.Text = "caballitio";
            this.caballitioToolStripMenuItem.Click += new System.EventHandler(this.caballitioToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.mostrarMascotaToolStripMenuItem,
            this.teToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(547, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha y Hora ";
            // 
            // lblhora
            // 
            this.lblhora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(408, 57);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(41, 13);
            this.lblhora.TabIndex = 2;
            this.lblhora.Text = "label2";
            this.lblhora.Click += new System.EventHandler(this.lblhora_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proximos Turnos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(15, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(315, 190);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(429, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(547, 251);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarMascotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTurnosAgendadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarCuadroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorOscuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coloresClarosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulMarinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeOscuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem azulClaroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verdeAguaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem imagenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caballitioToolStripMenuItem;
    }
}

