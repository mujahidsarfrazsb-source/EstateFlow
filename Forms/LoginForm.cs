using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EstateFlow.Database;

namespace EstateFlow.Forms;

public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        var role = Repository.Scalar(Queries.Login, new Dictionary<string, object>
        {
            {"@username", txtUsername.Text.Trim()},
            {"@password", txtPassword.Text.Trim()}
        });

        if (role == null)
        {
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Hide();
        using var dashboard = new DashboardForm(txtUsername.Text.Trim(), role.ToString() ?? "User");
        dashboard.ShowDialog();
        Show();
    }

    private void btnTestDb_Click(object sender, EventArgs e)
    {
        DbConnection.TestConnection(out var message);
        MessageBox.Show(message, "Database Test");
    }
}
