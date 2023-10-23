using Robot.Model;

namespace Robot.Service
{
    public interface IDataStorageService
    {
        /// <summary>
        ///The resulting value will be stored in a table named executions together with timestamp of
        /// </summary>
        /// <param name="cleanResponse"></param>
        /// <returns>Number of affected records</returns>
        int Save(CleanResponse cleanResponse);
    }
}