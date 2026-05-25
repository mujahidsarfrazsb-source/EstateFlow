using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EstateFlow.Database;

namespace EstateFlow.Forms;

public partial class ClientForm : Form
{
    private int selectedId = 0;

    public ClientForm()
    {
        InitializeComponent();
        LoadRecords();
    }

    private void LoadRecords(string search = "")
    {
        dgvRecords.DataSource = Repository.GetTable(Queries.GetClients, new Dictionary<string, object>{ {"@search", "%" + search + "%"} });
        dgvRecords.AutoResizeColumns();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMain.Text))
        {
            MessageBox.Show("Required field is missing.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        Repository.Execute(Queries.InsertClient, new Dictionary<string, object>{ {"@name", txtMain.Text.Trim()}, {"@phone", txtSecond.Text.Trim()}, {"@email", txtThird.Text.Trim()}, {"@type", cmbType.Text} });
        ClearForm();
        LoadRecords(txtSearch.Text.Trim());
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (selectedId == 0)
        {
            MessageBox.Show("Please select a record first.");
            return;
        }
        Repository.Execute(Queries.UpdateClient, new Dictionary<string, object>{ {"@id", selectedId}, {"@name", txtMain.Text.Trim()}, {"@phone", txtSecond.Text.Trim()}, {"@email", txtThird.Text.Trim()}, {"@type", cmbType.Text} });
        ClearForm();
        LoadRecords(txtSearch.Text.Trim());
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (selectedId == 0)
        {
            MessageBox.Show("Please select a record first.");
            return;
        }
        if (MessageBox.Show("Are you sure you want to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            Repository.Execute(Queries.DeleteClient, new Dictionary<string, object>{ {"@id", selectedId} });
            ClearForm();
            LoadRecords(txtSearch.Text.Trim());
        }
    }

    private void dgvRecords_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        var row = dgvRecords.Rows[e.RowIndex];
        selectedId = Convert.ToInt32(row.Cells[0].Value);
        txtMain.Text = row.Cells[1].Value.ToString(); txtSecond.Text = row.Cells[2].Value.ToString(); txtThird.Text = row.Cells[3].Value.ToString(); cmbType.Text = row.Cells[4].Value.ToString();
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        LoadRecords(txtSearch.Text.Trim());
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearForm();
    }

    private void ClearForm()
    {
        selectedId = 0;
        txtMain.Clear();
        txtSecond.Clear();
        txtThird.Clear();
        cmbType.SelectedIndex = 0;
        numAmount.Value = 0;
    }
}
