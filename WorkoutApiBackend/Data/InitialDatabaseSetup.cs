using System.Data.OleDb;
using Microsoft.EntityFrameworkCore;

namespace WorkoutApiBackend.Data
{
    public class InitialDatabaseSetup
    {
        public static async Task Create()
        {
            await using var context = new WorkoutContext();

            OleDbConnectionStringBuilder builder = new(context.Database.GetConnectionString());
            var fileName = builder.DataSource;

            if (File.Exists(fileName))
            {
                return;
            }

            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();
        }
    }
}
