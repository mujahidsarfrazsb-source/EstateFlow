namespace EstateFlow.Database;

public static class Queries
{
    public const string Login = "SELECT role FROM users WHERE username=@username AND password=@password AND is_active=1 LIMIT 1";

    public const string GetDashboardStats = @"
        SELECT
        (SELECT COUNT(*) FROM properties WHERE is_deleted=0) AS TotalProperties,
        (SELECT COUNT(*) FROM clients WHERE is_deleted=0) AS TotalClients,
        (SELECT COUNT(*) FROM agents WHERE is_deleted=0) AS TotalAgents,
        (SELECT COUNT(*) FROM sales WHERE is_deleted=0) AS TotalSales";

    public const string GetProperties = "SELECT property_id, title, property_type, address, price, status, created_at FROM properties WHERE is_deleted=0 AND (title LIKE @search OR property_type LIKE @search OR address LIKE @search) ORDER BY property_id DESC";
    public const string InsertProperty = "INSERT INTO properties(title, property_type, address, price, status) VALUES(@title,@type,@address,@price,@status)";
    public const string UpdateProperty = "UPDATE properties SET title=@title, property_type=@type, address=@address, price=@price, status=@status WHERE property_id=@id";
    public const string DeleteProperty = "UPDATE properties SET is_deleted=1 WHERE property_id=@id";

    public const string GetClients = "SELECT client_id, full_name, phone, email, client_type, created_at FROM clients WHERE is_deleted=0 AND (full_name LIKE @search OR phone LIKE @search OR email LIKE @search) ORDER BY client_id DESC";
    public const string InsertClient = "INSERT INTO clients(full_name, phone, email, client_type) VALUES(@name,@phone,@email,@type)";
    public const string UpdateClient = "UPDATE clients SET full_name=@name, phone=@phone, email=@email, client_type=@type WHERE client_id=@id";
    public const string DeleteClient = "UPDATE clients SET is_deleted=1 WHERE client_id=@id";

    public const string GetAgents = "SELECT agent_id, full_name, phone, email, commission_rate FROM agents WHERE is_deleted=0 AND (full_name LIKE @search OR phone LIKE @search OR email LIKE @search) ORDER BY agent_id DESC";
    public const string InsertAgent = "INSERT INTO agents(full_name, phone, email, commission_rate) VALUES(@name,@phone,@email,@commission)";
    public const string UpdateAgent = "UPDATE agents SET full_name=@name, phone=@phone, email=@email, commission_rate=@commission WHERE agent_id=@id";
    public const string DeleteAgent = "UPDATE agents SET is_deleted=1 WHERE agent_id=@id";

    public const string GetSales = @"SELECT s.sale_id, p.title AS property_title, c.full_name AS client_name, a.full_name AS agent_name, s.sale_amount, s.sale_date
        FROM sales s
        JOIN properties p ON p.property_id=s.property_id
        JOIN clients c ON c.client_id=s.client_id
        JOIN agents a ON a.agent_id=s.agent_id
        WHERE s.is_deleted=0 AND (p.title LIKE @search OR c.full_name LIKE @search OR a.full_name LIKE @search)
        ORDER BY s.sale_id DESC";
    public const string InsertSale = "INSERT INTO sales(property_id, client_id, agent_id, sale_amount, sale_date) VALUES(@property,@client,@agent,@amount,@date)";
    public const string DeleteSale = "UPDATE sales SET is_deleted=1 WHERE sale_id=@id";
}
