using Microsoft.Extensions.Configuration;
using Robot.Model;

namespace Robot.Storage.PostgreSQL
{
    public class PostgreSQLStorageService : IDataStorageService
    {
        private readonly IConfiguration _configuration;

        public PostgreSQLStorageService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<int> Save(Execution execution)
        {
            await using var dataContext = new DataContext(_configuration);
            await dataContext.Database.EnsureCreatedAsync();

            // Insert a Execusion
            dataContext.Execusions.Add(execution);
            var affectedRecords = await dataContext.SaveChangesAsync();
            return affectedRecords;
        }
    }
}
