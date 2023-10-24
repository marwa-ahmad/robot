using Robot.Model;

namespace Robot.Storage
{
    public interface IDataStorageService
    {
        /// <summary>
        ///The resulting value will be stored in a table named executions together with timestamp of
        /// </summary>
        /// <param name="execution"></param>
        /// <returns>Number of affected records</returns>
        Task<int> Save(Execution execution);
    }
}