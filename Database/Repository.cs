using System.Data;
using MySql.Data.MySqlClient;

namespace EstateFlow.Database;

public static class Repository
{
    public static DataTable GetTable(string sql, Dictionary<string, object>? parameters = null)
    {
        using var connection = DbConnection.GetConnection();
        using var command = new MySqlCommand(sql, connection);
        AddParameters(command, parameters);
        using var adapter = new MySqlDataAdapter(command);
        var table = new DataTable();
        adapter.Fill(table);
        return table;
    }

    public static int Execute(string sql, Dictionary<string, object>? parameters = null)
    {
        using var connection = DbConnection.GetConnection();
        using var command = new MySqlCommand(sql, connection);
        AddParameters(command, parameters);
        connection.Open();
        return command.ExecuteNonQuery();
    }

    public static object? Scalar(string sql, Dictionary<string, object>? parameters = null)
    {
        using var connection = DbConnection.GetConnection();
        using var command = new MySqlCommand(sql, connection);
        AddParameters(command, parameters);
        connection.Open();
        return command.ExecuteScalar();
    }

    private static void AddParameters(MySqlCommand command, Dictionary<string, object>? parameters)
    {
        if (parameters == null) return;
        foreach (var item in parameters)
        {
            command.Parameters.AddWithValue(item.Key, item.Value ?? DBNull.Value);
        }
    }
}
