namespace Pharmacy_Management_System
{
    partial class Form1
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
            this.PharmDataSet4 = new Pharmacy_Management_System.PharmDataSet4();
            this.SellingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SellingTableAdapter = new Pharmacy_Management_System.PharmDataSet4TableAdapters.SellingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PharmDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SellingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Pharmacy_Management_System.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(40, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(703, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // PharmDataSet4
            // 
            this.PharmDataSet4.DataSetName = "PharmDataSet4";
            this.PharmDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SellingBindingSource
            // 
            this.SellingBindingSource.DataMember = "Selling";
            this.SellingBindingSource.DataSource = this.PharmDataSet4;
            // 
            // SellingTableAdapter
            // 
            this.SellingTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 379);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PharmDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SellingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SellingBindingSource;
        private PharmDataSet4 PharmDataSet4;
        private PharmDataSet4TableAdapters.SellingTableAdapter SellingTableAdapter;
    }
}