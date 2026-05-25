using System.Drawing;
using System.Windows.Forms;

namespace EstateFlow.Forms;

partial class PropertyForm
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle;
    private Label lblMain;
    private Label lblSecond;
    private Label lblThird;
    private Label lblType;
    private TextBox txtMain;
    private TextBox txtSecond;
    private TextBox txtThird;
    private ComboBox cmbType;
    private NumericUpDown numAmount;
    private TextBox txtSearch;
    private Button btnSave;
    private Button btnUpdate;
    private Button btnDelete;
    private Button btnClear;
    private DataGridView dgvRecords;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblMain = new Label();
        lblSecond = new Label();
        lblThird = new Label();
        lblType = new Label();
        txtMain = new TextBox();
        txtSecond = new TextBox();
        txtThird = new TextBox();
        cmbType = new ComboBox();
        numAmount = new NumericUpDown();
        txtSearch = new TextBox();
        btnSave = new Button();
        btnUpdate = new Button();
        btnDelete = new Button();
        btnClear = new Button();
        dgvRecords = new DataGridView();
        label1 = new Label();
        ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitle.Location = new Point(38, 28);
        lblTitle.Margin = new Padding(4, 0, 4, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(496, 60);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Property Management";
        // 
        // lblMain
        // 
        lblMain.Location = new Point(38, 102);
        lblMain.Margin = new Padding(4, 0, 4, 0);
        lblMain.Name = "lblMain";
        lblMain.Size = new Size(123, 31);
        lblMain.TabIndex = 1;
        lblMain.Text = "Title";
        // 
        // lblSecond
        // 
        lblSecond.Location = new Point(38, 158);
        lblSecond.Margin = new Padding(4, 0, 4, 0);
        lblSecond.Name = "lblSecond";
        lblSecond.Size = new Size(123, 31);
        lblSecond.TabIndex = 3;
        lblSecond.Text = "Property Type";
        // 
        // lblThird
        // 
        lblThird.Location = new Point(38, 212);
        lblThird.Margin = new Padding(4, 0, 4, 0);
        lblThird.Name = "lblThird";
        lblThird.Size = new Size(123, 31);
        lblThird.TabIndex = 5;
        lblThird.Text = "Address";
        // 
        // lblType
        // 
        lblType.Location = new Point(562, 102);
        lblType.Margin = new Padding(4, 0, 4, 0);
        lblType.Name = "lblType";
        lblType.Size = new Size(131, 31);
        lblType.TabIndex = 7;
        lblType.Text = "Status";
        // 
        // txtMain
        // 
        txtMain.Location = new Point(188, 98);
        txtMain.Margin = new Padding(4);
        txtMain.Name = "txtMain";
        txtMain.Size = new Size(324, 31);
        txtMain.TabIndex = 2;
        // 
        // txtSecond
        // 
        txtSecond.Location = new Point(188, 152);
        txtSecond.Margin = new Padding(4);
        txtSecond.Name = "txtSecond";
        txtSecond.Size = new Size(324, 31);
        txtSecond.TabIndex = 4;
        // 
        // txtThird
        // 
        txtThird.Location = new Point(188, 208);
        txtThird.Margin = new Padding(4);
        txtThird.Name = "txtThird";
        txtThird.Size = new Size(324, 31);
        txtThird.TabIndex = 6;
        // 
        // cmbType
        // 
        cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbType.Items.AddRange(new object[] { "Available", "Sold", "Rented", "Pending" });
        cmbType.Location = new Point(712, 98);
        cmbType.Margin = new Padding(4);
        cmbType.Name = "cmbType";
        cmbType.Size = new Size(299, 33);
        cmbType.TabIndex = 8;
        // 
        // numAmount
        // 
        numAmount.DecimalPlaces = 2;
        numAmount.Location = new Point(712, 152);
        numAmount.Margin = new Padding(4);
        numAmount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numAmount.Name = "numAmount";
        numAmount.Size = new Size(300, 31);
        numAmount.TabIndex = 9;
        numAmount.ThousandsSeparator = true;
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(38, 288);
        txtSearch.Margin = new Padding(4);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search records...";
        txtSearch.Size = new Size(474, 31);
        txtSearch.TabIndex = 10;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.LimeGreen;
        btnSave.Location = new Point(562, 228);
        btnSave.Margin = new Padding(4);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(131, 50);
        btnSave.TabIndex = 11;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // btnUpdate
        // 
        btnUpdate.BackColor = Color.DodgerBlue;
        btnUpdate.Location = new Point(706, 228);
        btnUpdate.Margin = new Padding(4);
        btnUpdate.Name = "btnUpdate";
        btnUpdate.Size = new Size(131, 50);
        btnUpdate.TabIndex = 12;
        btnUpdate.Text = "Update";
        btnUpdate.UseVisualStyleBackColor = false;
        btnUpdate.Click += btnUpdate_Click;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.IndianRed;
        btnDelete.Location = new Point(850, 228);
        btnDelete.Margin = new Padding(4);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(131, 50);
        btnDelete.TabIndex = 13;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnClear
        // 
        btnClear.BackColor = Color.SlateGray;
        btnClear.Location = new Point(994, 228);
        btnClear.Margin = new Padding(4);
        btnClear.Name = "btnClear";
        btnClear.Size = new Size(131, 50);
        btnClear.TabIndex = 14;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;
        // 
        // dgvRecords
        // 
        dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvRecords.ColumnHeadersHeight = 34;
        dgvRecords.Location = new Point(38, 352);
        dgvRecords.Margin = new Padding(4);
        dgvRecords.MultiSelect = false;
        dgvRecords.Name = "dgvRecords";
        dgvRecords.ReadOnly = true;
        dgvRecords.RowHeadersWidth = 62;
        dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvRecords.Size = new Size(1112, 450);
        dgvRecords.TabIndex = 15;
        dgvRecords.CellClick += dgvRecords_CellClick;
        // 
        // label1
        // 
        label1.Location = new Point(562, 152);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(131, 31);
        label1.TabIndex = 16;
        label1.Text = "Price";
        // 
        // PropertyForm
        // 
        AutoScaleMode = AutoScaleMode.None;
        ClientSize = new Size(1200, 844);
        Controls.Add(label1);
        Controls.Add(lblTitle);
        Controls.Add(lblMain);
        Controls.Add(txtMain);
        Controls.Add(lblSecond);
        Controls.Add(txtSecond);
        Controls.Add(lblThird);
        Controls.Add(txtThird);
        Controls.Add(lblType);
        Controls.Add(cmbType);
        Controls.Add(numAmount);
        Controls.Add(txtSearch);
        Controls.Add(btnSave);
        Controls.Add(btnUpdate);
        Controls.Add(btnDelete);
        Controls.Add(btnClear);
        Controls.Add(dgvRecords);
        Margin = new Padding(4);
        Name = "PropertyForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Property Management";
        ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
}
