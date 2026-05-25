using System.Drawing;
using System.Windows.Forms;

namespace EstateFlow.Forms;

partial class LoginForm
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Label lblUsername;
    private Label lblPassword;
    private TextBox txtUsername;
    private TextBox txtPassword;
    private Button btnLogin;
    private Button btnTestDb;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblUsername = new Label();
        lblPassword = new Label();
        txtUsername = new TextBox();
        txtPassword = new TextBox();
        btnLogin = new Button();
        btnTestDb = new Button();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lblTitle.Location = new Point(98, 44);
        lblTitle.Margin = new Padding(4, 0, 4, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(446, 65);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "EstateFlow System";
        // 
        // lblUsername
        // 
        lblUsername.Location = new Point(100, 127);
        lblUsername.Margin = new Padding(4, 0, 4, 0);
        lblUsername.Name = "lblUsername";
        lblUsername.Size = new Size(125, 31);
        lblUsername.TabIndex = 1;
        lblUsername.Text = "Username";
        // 
        // lblPassword
        // 
        lblPassword.Location = new Point(100, 221);
        lblPassword.Margin = new Padding(4, 0, 4, 0);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(125, 31);
        lblPassword.TabIndex = 3;
        lblPassword.Text = "Password";
        // 
        // txtUsername
        // 
        txtUsername.Location = new Point(100, 173);
        txtUsername.Margin = new Padding(4, 4, 4, 4);
        txtUsername.Name = "txtUsername";
        txtUsername.Size = new Size(399, 31);
        txtUsername.TabIndex = 2;
        txtUsername.Text = "admin";
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(100, 265);
        txtPassword.Margin = new Padding(4, 4, 4, 4);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.Size = new Size(399, 31);
        txtPassword.TabIndex = 4;
        txtPassword.Text = "admin123";
        // 
        // btnLogin
        // 
        btnLogin.BackColor = Color.RoyalBlue;
        btnLogin.Location = new Point(100, 344);
        btnLogin.Margin = new Padding(4, 4, 4, 4);
        btnLogin.Name = "btnLogin";
        btnLogin.Size = new Size(188, 55);
        btnLogin.TabIndex = 5;
        btnLogin.Text = "Login";
        btnLogin.UseVisualStyleBackColor = false;
        btnLogin.Click += btnLogin_Click;
        // 
        // btnTestDb
        // 
        btnTestDb.BackColor = SystemColors.ControlText;
        btnTestDb.ForeColor = Color.Transparent;
        btnTestDb.Location = new Point(312, 344);
        btnTestDb.Margin = new Padding(4, 4, 4, 4);
        btnTestDb.Name = "btnTestDb";
        btnTestDb.Size = new Size(188, 55);
        btnTestDb.TabIndex = 6;
        btnTestDb.Text = "Test DB";
        btnTestDb.UseVisualStyleBackColor = false;
        btnTestDb.Click += btnTestDb_Click;
        // 
        // LoginForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(612, 475);
        Controls.Add(lblTitle);
        Controls.Add(lblUsername);
        Controls.Add(txtUsername);
        Controls.Add(lblPassword);
        Controls.Add(txtPassword);
        Controls.Add(btnLogin);
        Controls.Add(btnTestDb);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 4, 4, 4);
        MaximizeBox = false;
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "EstateFlow Login";
        ResumeLayout(false);
        PerformLayout();
    }
}
