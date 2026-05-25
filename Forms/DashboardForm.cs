using System;
using System.Data;
using System.Windows.Forms;
using EstateFlow.Database;

namespace EstateFlow.Forms;

public partial class DashboardForm : Form
{
    private readonly string currentUser;
    private readonly string currentRole;

    public DashboardForm(string username, string role)
    {
        currentUser = username;
        currentRole = role;
        InitializeComponent();
        LoadStats();
    }

    private void LoadStats()
    {
        lblWelcome.Text = $"Welcome, {currentUser} ({currentRole})";
        DataTable stats = Repository.GetTable(Queries.GetDashboardStats);
        if (stats.Rows.Count == 0) return;
        lblProperties.Text = "Properties: " + stats.Rows[0]["TotalProperties"];
        lblClients.Text = "Clients: " + stats.Rows[0]["TotalClients"];
        lblAgents.Text = "Agents: " + stats.Rows[0]["TotalAgents"];
        lblSales.Text = "Sales: " + stats.Rows[0]["TotalSales"];
    }

    private void btnProperties_Click(object sender, EventArgs e) { using var f = new PropertyForm(); f.ShowDialog(); LoadStats(); }
    private void btnClients_Click(object sender, EventArgs e) { using var f = new ClientForm(); f.ShowDialog(); LoadStats(); }
    private void btnAgents_Click(object sender, EventArgs e) { using var f = new AgentForm(); f.ShowDialog(); LoadStats(); }
    private void btnSales_Click(object sender, EventArgs e) { using var f = new SalesForm(); f.ShowDialog(); LoadStats(); }
    private void btnReports_Click(object sender, EventArgs e) { using var f = new EstateFlow.Reports.ReportViewerForm(); f.ShowDialog(); }
    private void btnExit_Click(object sender, EventArgs e) => Close();
}
