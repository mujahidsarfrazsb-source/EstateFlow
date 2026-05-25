using System.Drawing;
using System.Windows.Forms;

namespace EstateFlow.Reports;

partial class ReportViewerForm
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Button btnExportCsv, btnPrint;
    private DataGridView dgvReport;
    protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        lblTitle = new Label(); btnExportCsv = new Button(); btnPrint = new Button(); dgvReport = new DataGridView(); ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit(); SuspendLayout();
        lblTitle.AutoSize = true; lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold); lblTitle.Location = new Point(30, 22); lblTitle.Text = "EstateFlow Sales Report";
        btnExportCsv.Location = new Point(30, 85); btnExportCsv.Size = new Size(155, 42); btnExportCsv.Text = "Export CSV"; btnExportCsv.Click += btnExportCsv_Click;
        btnPrint.Location = new Point(200, 85); btnPrint.Size = new Size(155, 42); btnPrint.Text = "Print"; btnPrint.Click += btnPrint_Click;
        dgvReport.Location = new Point(30, 150); dgvReport.Size = new Size(880, 430); dgvReport.ReadOnly = true; dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        AutoScaleDimensions = new SizeF(8F, 20F); AutoScaleMode = AutoScaleMode.Font; ClientSize = new Size(950, 620); Controls.AddRange(new Control[] { lblTitle,btnExportCsv,btnPrint,dgvReport }); StartPosition = FormStartPosition.CenterParent; Text = "Reports"; ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit(); EstateFlow.EstateFlowTheme.ApplyForm(this); EstateFlow.EstateFlowTheme.ApplyTitle(lblTitle); EstateFlow.EstateFlowTheme.ApplyButton(btnExportCsv, EstateFlow.EstateFlowButtonStyle.Success); EstateFlow.EstateFlowTheme.ApplyButton(btnPrint, EstateFlow.EstateFlowButtonStyle.Dark); EstateFlow.EstateFlowTheme.ApplyGrid(dgvReport); ResumeLayout(false); PerformLayout();
    }
}
