using System.Drawing;
using System.Windows.Forms;

namespace EstateFlow.Forms;

partial class SalesForm
{
    private System.ComponentModel.IContainer components = null;
    private Label lblTitle, lblProperty, lblClient, lblAgent, lblAmount;
    private ComboBox cmbProperty, cmbClient, cmbAgent;
    private NumericUpDown numAmount;
    private DateTimePicker dtSaleDate;
    private TextBox txtSearch;
    private Button btnSave, btnDelete;
    private DataGridView dgvSales;
    protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        lblTitle = new Label();
        lblProperty = new Label();
        lblClient = new Label();
        lblAgent = new Label();
        lblAmount = new Label();
        cmbProperty = new ComboBox();
        cmbClient = new ComboBox();
        cmbAgent = new ComboBox();
        numAmount = new NumericUpDown();
        dtSaleDate = new DateTimePicker();
        txtSearch = new TextBox();
        btnSave = new Button();
        btnDelete = new Button();
        dgvSales = new DataGridView();
        label1 = new Label();
        ((System.ComponentModel.ISupportInitialize)numAmount).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
        lblTitle.Location = new Point(38, 28);
        lblTitle.Margin = new Padding(4, 0, 4, 0);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(418, 60);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Sales Management";
        // 
        // lblProperty
        // 
        lblProperty.Location = new Point(38, 108);
        lblProperty.Margin = new Padding(4, 0, 4, 0);
        lblProperty.Name = "lblProperty";
        lblProperty.Size = new Size(106, 29);
        lblProperty.TabIndex = 1;
        lblProperty.Text = "Property";
        // 
        // lblClient
        // 
        lblClient.Location = new Point(38, 162);
        lblClient.Margin = new Padding(4, 0, 4, 0);
        lblClient.Name = "lblClient";
        lblClient.Size = new Size(106, 29);
        lblClient.TabIndex = 3;
        lblClient.Text = "Client";
        // 
        // lblAgent
        // 
        lblAgent.Location = new Point(38, 218);
        lblAgent.Margin = new Padding(4, 0, 4, 0);
        lblAgent.Name = "lblAgent";
        lblAgent.Size = new Size(106, 29);
        lblAgent.TabIndex = 5;
        lblAgent.Text = "Agent";
        // 
        // lblAmount
        // 
        lblAmount.Location = new Point(562, 108);
        lblAmount.Margin = new Padding(4, 0, 4, 0);
        lblAmount.Name = "lblAmount";
        lblAmount.Size = new Size(105, 29);
        lblAmount.TabIndex = 7;
        lblAmount.Text = "Amount";
        // 
        // cmbProperty
        // 
        cmbProperty.Location = new Point(162, 102);
        cmbProperty.Margin = new Padding(4);
        cmbProperty.Name = "cmbProperty";
        cmbProperty.Size = new Size(349, 33);
        cmbProperty.TabIndex = 2;
        // 
        // cmbClient
        // 
        cmbClient.Location = new Point(162, 158);
        cmbClient.Margin = new Padding(4);
        cmbClient.Name = "cmbClient";
        cmbClient.Size = new Size(349, 33);
        cmbClient.TabIndex = 4;
        // 
        // cmbAgent
        // 
        cmbAgent.Location = new Point(162, 212);
        cmbAgent.Margin = new Padding(4);
        cmbAgent.Name = "cmbAgent";
        cmbAgent.Size = new Size(349, 33);
        cmbAgent.TabIndex = 6;
        // 
        // numAmount
        // 
        numAmount.DecimalPlaces = 2;
        numAmount.Location = new Point(675, 102);
        numAmount.Margin = new Padding(4);
        numAmount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
        numAmount.Name = "numAmount";
        numAmount.Size = new Size(300, 31);
        numAmount.TabIndex = 8;
        // 
        // dtSaleDate
        // 
        dtSaleDate.Location = new Point(675, 158);
        dtSaleDate.Margin = new Padding(4);
        dtSaleDate.Name = "dtSaleDate";
        dtSaleDate.Size = new Size(299, 31);
        dtSaleDate.TabIndex = 9;
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(38, 294);
        txtSearch.Margin = new Padding(4);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search sales...";
        txtSearch.Size = new Size(474, 31);
        txtSearch.TabIndex = 12;
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.LimeGreen;
        btnSave.Location = new Point(675, 218);
        btnSave.Margin = new Padding(4);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(138, 50);
        btnSave.TabIndex = 10;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.IndianRed;
        btnDelete.Location = new Point(831, 218);
        btnDelete.Margin = new Padding(4);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(138, 50);
        btnDelete.TabIndex = 11;
        btnDelete.Text = "Delete";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // dgvSales
        // 
        dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvSales.ColumnHeadersHeight = 34;
        dgvSales.Location = new Point(38, 333);
        dgvSales.Margin = new Padding(4);
        dgvSales.Name = "dgvSales";
        dgvSales.ReadOnly = true;
        dgvSales.RowHeadersWidth = 62;
        dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvSales.Size = new Size(1112, 444);
        dgvSales.TabIndex = 13;
        dgvSales.CellClick += dgvSales_CellClick;
        // 
        // label1
        // 
        label1.Location = new Point(562, 158);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(105, 29);
        label1.TabIndex = 14;
        label1.Text = "Date";
        label1.Click += label1_Click;
        // 
        // SalesForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1200, 844);
        Controls.Add(label1);
        Controls.Add(lblTitle);
        Controls.Add(lblProperty);
        Controls.Add(cmbProperty);
        Controls.Add(lblClient);
        Controls.Add(cmbClient);
        Controls.Add(lblAgent);
        Controls.Add(cmbAgent);
        Controls.Add(lblAmount);
        Controls.Add(numAmount);
        Controls.Add(dtSaleDate);
        Controls.Add(btnSave);
        Controls.Add(btnDelete);
        Controls.Add(txtSearch);
        Controls.Add(dgvSales);
        Margin = new Padding(4);
        Name = "SalesForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Sales Management";
        ((System.ComponentModel.ISupportInitialize)numAmount).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label label1;
}
