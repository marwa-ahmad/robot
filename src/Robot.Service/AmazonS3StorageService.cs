using Robot.Model;
using Robot.Storage;

namespace Robot.Service
{
    /// <summary>
    /// Another service for storing data using Amazon S3
    /// </summary>
    public class AmazonS3StorageService : IDataStorageService
    {
        public Task<int> Save(Execution execution)
        {
            throw new NotImplementedException();
        }
    }
}
