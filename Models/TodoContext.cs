using Microsoft.EntityFrameworkCore;
// using System.Data.SqlClient;

namespace TodoApi.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    // [System.ComponentModel.SettingsBindable(true)]
    // public override string ConnectionString { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlServer("Server=192.168.1.15,1433;Database=CVEDb;Connection Timeout=60;User Id=sa;Password=Admin@123#;TrustServerCertificate=True;MultipleActiveResultSets=True;");
    // }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}

// SqlConnection conn = new SqlConnection();
// conn.ConnectionString =
//   "Data Source=192.168.1.15;" +
//   "Initial Catalog=DataBaseName;" +
//   "User id=ail;" +
//   "Password=123;";
// conn.Open();
// conn.Close();