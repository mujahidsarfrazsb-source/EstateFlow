using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EstateFlow.Database;

namespace EstateFlow.Forms;

public partial class SalesForm : Form
{
    private int selectedSaleId = 0;
    public SalesForm()
    {
        InitializeComponent();
        LoadLookups();
        LoadSales();
    }

    private void LoadLookups()
    {
        cmbProperty.DataSource = Repository.GetTable("SELECT property_id, title FROM properties WHERE is_deleted=0");
        cmbProperty.DisplayMember = "title"; cmbProperty.ValueMember = "property_id";
        cmbClient.DataSource = Repository.GetTable("SELECT client_id, full_name FROM clients WHERE is_deleted=0");
        cmbClient.DisplayMember = "full_name"; cmbClient.ValueMember = "client_id";
        cmbAgent.DataSource = Repository.GetTable("SELECT agent_id, full_name FROM agents WHERE is_deleted=0");
        cmbAgent.DisplayMember = "full_name"; cmbAgent.ValueMember = "agent_id";
    }

    private void LoadSales(string search = "")
    {
        dgvSales.DataSource = Repository.GetTable(Queries.GetSales, new Dictionary<string, object> { { "@search", "%" + search + "%" } });
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        Repository.Execute(Queries.InsertSale, new Dictionary<string, object> { { "@property", cmbProperty.SelectedValue }, { "@client", cmbClient.SelectedValue }, { "@agent", cmbAgent.SelectedValue }, { "@amount", numAmount.Value }, { "@date", dtSaleDate.Value.Date } });
        LoadSales();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (selectedSaleId == 0) return;
        if (MessageBox.Show("Delete selected sale?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            Repository.Execute(Queries.DeleteSale, new Dictionary<string, object> { { "@id", selectedSaleId } });
            selectedSaleId = 0; LoadSales();
        }
    }

    private void dgvSales_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        selectedSaleId = Convert.ToInt32(dgvSales.Rows[e.RowIndex].Cells[0].Value);
    }

    private void txtSearch_TextChanged(object sender, EventArgs e) => LoadSales(txtSearch.Text.Trim());

    private void label1_Click(object sender, EventArgs e)
    {

    }
}
