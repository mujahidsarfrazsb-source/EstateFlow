using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using EstateFlow.Database;

namespace EstateFlow.Reports;

public partial class ReportViewerForm : Form
{
    public ReportViewerForm()
    {
        InitializeComponent();
        LoadReport();
    }

    private void LoadReport()
    {
        var table = Repository.GetTable(Queries.GetSales, new Dictionary<string, object>{ {"@search", "%%"} });
        dgvReport.DataSource = table;
    }

    private void btnExportCsv_Click(object sender, EventArgs e)
    {
        var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "estateflow-sales-report.csv");
        var sb = new StringBuilder();
        foreach (DataGridViewColumn column in dgvReport.Columns) sb.Append(column.HeaderText + ",");
        sb.AppendLine();
        foreach (DataGridViewRow row in dgvReport.Rows)
        {
            if (row.IsNewRow) continue;
            foreach (DataGridViewCell cell in row.Cells) sb.Append((cell.Value?.ToString() ?? "").Replace(",", " ") + ",");
            sb.AppendLine();
        }
        File.WriteAllText(path, sb.ToString());
        MessageBox.Show("CSV exported on Desktop.");
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Use Export CSV for submission demo. Print module placeholder is ready for PrintDocument extension.");
    }
}
