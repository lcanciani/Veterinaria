﻿namespace VeterinariaMenu
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
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.datosVeterinaria = new VeterinariaMenu.datosVeterinaria();
            this.veterinariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinariosTableAdapter = new VeterinariaMenu.datosVeterinariaTableAdapters.veterinariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.datosVeterinaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariosBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "veterinarios";
            reportDataSource1.Value = this.veterinariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "VeterinariaMenu.ReportVet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 516);
            this.reportViewer1.TabIndex = 2;
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
            // ReporteVeterinarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnMostrarTodo);
            this.Name = "ReporteVeterinarios";
            this.Text = "ReporteVeterinarios";
            this.Load += new System.EventHandler(this.ReporteVeterinarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosVeterinaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        
        private System.Windows.Forms.Button btnMostrarTodo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource veterinariosBindingSource;
        private datosVeterinaria datosVeterinaria;
        private datosVeterinariaTableAdapters.veterinariosTableAdapter veterinariosTableAdapter;
    }
}