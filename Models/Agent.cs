namespace EstateFlow.Models;

public class Agent
{
    public int AgentId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public decimal CommissionRate { get; set; }
}
