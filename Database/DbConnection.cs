using MySql.Data.MySqlClient;

namespace EstateFlow.Database;

public static class DbConnection
{
    private static readonly string ConnectionString =
        "server=localhost;port=3307;database=estateflow_db;uid=root;pwd=admin123;SslMode=disabled;";

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(ConnectionString);
    }

    public static bool TestConnection(out string message)
    {
        try
        {
            using var connection = GetConnection();
            connection.Open();
            message = "Database connected successfully.";
            return true;
        }
        catch (Exception ex)
        {
            message = ex.Message;
            return false;
        }
    }
}
