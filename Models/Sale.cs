namespace EstateFlow.Models;

public class Sale
{
    public int SaleId { get; set; }
    public int PropertyId { get; set; }
    public int ClientId { get; set; }
    public int AgentId { get; set; }
    public decimal SaleAmount { get; set; }
    public DateTime SaleDate { get; set; }
}
