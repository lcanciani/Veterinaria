namespace VeterinariaMenu
{
    partial class ReporteVeterinarios
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.veterinariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VeterinariaDataSet = new VeterinariaMenu.VeterinariaDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.veterinariosTableAdapter = new VeterinariaMenu.VeterinariaDataSetTableAdapters.veterinariosTableAdapter();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VeterinariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // veterinariosBindingSource
            // 
            this.veterinariosBindingSource.DataMember = "veterinarios";
            this.veterinariosBindingSource.DataSource = this.VeterinariaDataSet;
            // 
            // VeterinariaDataSet
            // 
            this.VeterinariaDataSet.DataSetName = "VeterinariaDataSet";
            this.VeterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "TablaVeterinario";
            reportDataSource1.Value = this.veterinariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VeterinariaMenu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(680, 426);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // veterinariosTableAdapter
            // 
            this.veterinariosTableAdapter.ClearBeforeFill = true;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(31, 444);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(75, 60);
            this.btnMostrarTodo.TabIndex = 1;
            this.btnMostrarTodo.Text = "Mostrar todos los veterinarios";
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReporteVeterinarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteVeterinarios";
            this.Text = "ReporteVeterinarios";
            this.Load += new System.EventHandler(this.ReporteVeterinarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.veterinariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VeterinariaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource veterinariosBindingSource;
        private VeterinariaDataSet VeterinariaDataSet;
        private VeterinariaDataSetTableAdapters.veterinariosTableAdapter veterinariosTableAdapter;
        private System.Windows.Forms.Button btnMostrarTodo;
    }
}