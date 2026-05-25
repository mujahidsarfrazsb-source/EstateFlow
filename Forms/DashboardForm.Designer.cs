using System.Drawing;
using System.Windows.Forms;

namespace EstateFlow.Forms;

partial class DashboardForm
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle, lblWelcome, lblProperties, lblClients, lblAgents, lblSales;
    private Button btnProperties, btnClients, btnAgents, btnSales, btnReports, btnExit;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblWelcome = new Label();
        lblProperties = new Label();
        lblClients = new Label();
        lblAgents = new Label();
        lblSales = new Label();
        btnProperties = new Button();
        btnClients = new Button();
        btnAgents = new Button();
        btnSales = new Button();
        btnReports = new Button();
        btnExit = new Button();

        SuspendLayout();

        // =====================================================
        // FORM
        // =====================================================

        AutoScaleMode = AutoScaleMode.None;
        BackColor = Color.FromArgb(245, 247, 250);
        ClientSize = new Size(1220, 650);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "EstateFlow Dashboard";

        // =====================================================
        // TITLE
        // =====================================================

        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
        lblTitle.Location = new Point(40, 25);
        lblTitle.Text = "EstateFlow Dashboard";

        // =====================================================
        // WELCOME LABEL
        // =====================================================

        lblWelcome.AutoSize = true;
        lblWelcome.Font = new Font("Segoe UI", 11F);
        lblWelcome.ForeColor = Color.FromArgb(100, 116, 139);
        lblWelcome.Location = new Point(45, 90);
        lblWelcome.Text = "Welcome to your real estate control panel";

        // =====================================================
        // PROPERTIES CARD
        // =====================================================

        lblProperties.BackColor = Color.FromArgb(37, 99, 235);
        lblProperties.ForeColor = Color.White;
        lblProperties.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblProperties.TextAlign = ContentAlignment.MiddleCenter;
        lblProperties.Location = new Point(45, 150);
        lblProperties.Size = new Size(250, 110);
        lblProperties.Text = "120\nProperties";

        // =====================================================
        // CLIENTS CARD
        // =====================================================

        lblClients.BackColor = Color.FromArgb(22, 163, 74);
        lblClients.ForeColor = Color.White;
        lblClients.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblClients.TextAlign = ContentAlignment.MiddleCenter;
        lblClients.Location = new Point(330, 150);
        lblClients.Size = new Size(250, 110);
        lblClients.Text = "85\nClients";

        // =====================================================
        // AGENTS CARD
        // =====================================================

        lblAgents.BackColor = Color.FromArgb(14, 165, 233);
        lblAgents.ForeColor = Color.White;
        lblAgents.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblAgents.TextAlign = ContentAlignment.MiddleCenter;
        lblAgents.Location = new Point(615, 150);
        lblAgents.Size = new Size(250, 110);
        lblAgents.Text = "20\nAgents";

        // =====================================================
        // SALES CARD
        // =====================================================

        lblSales.BackColor = Color.FromArgb(245, 158, 11);
        lblSales.ForeColor = Color.White;
        lblSales.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblSales.TextAlign = ContentAlignment.MiddleCenter;
        lblSales.Location = new Point(900, 150);
        lblSales.Size = new Size(250, 110);
        lblSales.Text = "$50K\nSales";

        // =====================================================
        // BUTTON COMMON STYLE
        // =====================================================

        Font buttonFont = new Font("Segoe UI", 11F, FontStyle.Bold);

        // =====================================================
        // PROPERTIES BUTTON
        // =====================================================

        btnProperties.BackColor = Color.FromArgb(37, 99, 235);
        btnProperties.ForeColor = Color.White;
        btnProperties.FlatStyle = FlatStyle.Flat;
        btnProperties.FlatAppearance.BorderSize = 0;
        btnProperties.Font = buttonFont;
        btnProperties.Location = new Point(45, 310);
        btnProperties.Size = new Size(250, 65);
        btnProperties.Text = "Properties";
        btnProperties.UseVisualStyleBackColor = false;
        btnProperties.Click += btnProperties_Click;

        // =====================================================
        // CLIENTS BUTTON
        // =====================================================

        btnClients.BackColor = Color.FromArgb(22, 163, 74);
        btnClients.ForeColor = Color.White;
        btnClients.FlatStyle = FlatStyle.Flat;
        btnClients.FlatAppearance.BorderSize = 0;
        btnClients.Font = buttonFont;
        btnClients.Location = new Point(330, 310);
        btnClients.Size = new Size(250, 65);
        btnClients.Text = "Clients";
        btnClients.UseVisualStyleBackColor = false;
        btnClients.Click += btnClients_Click;

        // =====================================================
        // AGENTS BUTTON
        // =====================================================

        btnAgents.BackColor = Color.FromArgb(14, 165, 233);
        btnAgents.ForeColor = Color.White;
        btnAgents.FlatStyle = FlatStyle.Flat;
        btnAgents.FlatAppearance.BorderSize = 0;
        btnAgents.Font = buttonFont;
        btnAgents.Location = new Point(615, 310);
        btnAgents.Size = new Size(250, 65);
        btnAgents.Text = "Agents";
        btnAgents.UseVisualStyleBackColor = false;
        btnAgents.Click += btnAgents_Click;

        // =====================================================
        // SALES BUTTON
        // =====================================================

        btnSales.BackColor = Color.FromArgb(245, 158, 11);
        btnSales.ForeColor = Color.White;
        btnSales.FlatStyle = FlatStyle.Flat;
        btnSales.FlatAppearance.BorderSize = 0;
        btnSales.Font = buttonFont;
        btnSales.Location = new Point(900, 310);
        btnSales.Size = new Size(250, 65);
        btnSales.Text = "Sales";
        btnSales.UseVisualStyleBackColor = false;
        btnSales.Click += btnSales_Click;

        // =====================================================
        // REPORTS BUTTON
        // =====================================================

        btnReports.BackColor = Color.FromArgb(15, 23, 42);
        btnReports.ForeColor = Color.White;
        btnReports.FlatStyle = FlatStyle.Flat;
        btnReports.FlatAppearance.BorderSize = 0;
        btnReports.Font = buttonFont;
        btnReports.Location = new Point(45, 420);
        btnReports.Size = new Size(250, 65);
        btnReports.Text = "Reports";
        btnReports.UseVisualStyleBackColor = false;
        btnReports.Click += btnReports_Click;

        // =====================================================
        // EXIT BUTTON
        // =====================================================

        btnExit.BackColor = Color.FromArgb(239, 68, 68);
        btnExit.ForeColor = Color.White;
        btnExit.FlatStyle = FlatStyle.Flat;
        btnExit.FlatAppearance.BorderSize = 0;
        btnExit.Font = buttonFont;
        btnExit.Location = new Point(330, 420);
        btnExit.Size = new Size(250, 65);
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = false;
        btnExit.Click += btnExit_Click;

        // =====================================================
        // ADD CONTROLS
        // =====================================================

        Controls.Add(lblTitle);
        Controls.Add(lblWelcome);

        Controls.Add(lblProperties);
        Controls.Add(lblClients);
        Controls.Add(lblAgents);
        Controls.Add(lblSales);

        Controls.Add(btnProperties);
        Controls.Add(btnClients);
        Controls.Add(btnAgents);
        Controls.Add(btnSales);

        Controls.Add(btnReports);
        Controls.Add(btnExit);

        Margin = new Padding(4, 4, 4, 4);
        Name = "DashboardForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "EstateFlow Dashboard";

        ResumeLayout(false);
        PerformLayout();
    }
}