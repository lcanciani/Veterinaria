namespace VeterinariaMenu
{
    partial class FormReporteMascotas
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datosVeterinaria = new VeterinariaMenu.datosVeterinaria();
            this.veterinariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinariosTableAdapter = new VeterinariaMenu.datosVeterinariaTableAdapters.veterinariosTableAdapter();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new VeterinariaMenu.datosVeterinariaTableAdapters.DataTable1TableAdapter();
            this.DataSet1 = new VeterinariaMenu.DataSet1();
            this.mascotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mascotasTableAdapter = new VeterinariaMenu.DataSet1TableAdapters.mascotasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosVeterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "tablaMascotas";
            reportDataSource1.Value = this.mascotasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VeterinariaMenu.ReportMascotas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(685, 386);
            this.reportViewer1.TabIndex = 0;
            // 
            // datosVeterinaria
            // 
            this.datosVeterinaria.DataSetName = "datosVeterinaria";
            this.datosVeterinaria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veterinariosBindingSource
            // 
            this.veterinariosBindingSource.DataMember = "veterinarios";
            this.veterinariosBindingSource.DataSource = this.datosVeterinaria;
            // 
            // veterinariosTableAdapter
            // 
            this.veterinariosTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.datosVeterinaria;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mascotasBindingSource
            // 
            this.mascotasBindingSource.DataMember = "mascotas";
            this.mascotasBindingSource.DataSource = this.DataSet1;
            // 
            // mascotasTableAdapter
            // 
            this.mascotasTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteMascotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 386);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteMascotas";
            this.Text = "FormReporteMascotas";
            this.Load += new System.EventHandler(this.FormReporteMascotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosVeterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mascotasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource veterinariosBindingSource;
        private datosVeterinaria datosVeterinaria;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private datosVeterinariaTableAdapters.veterinariosTableAdapter veterinariosTableAdapter;
        private datosVeterinariaTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.BindingSource mascotasBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.mascotasTableAdapter mascotasTableAdapter;
    }
}