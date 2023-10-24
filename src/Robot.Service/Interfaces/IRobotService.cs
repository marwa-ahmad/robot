using Robot.Model;

namespace Robot.Service
{
    public interface IRobotService
    {
        /// <summary>
        /// Implement the robot cleaning logic and database interaction here
        /// Update the database with the result
        /// Return the result in JSON format
        /// </summary>
        /// <param name="commandRequest"></param>
        /// <returns>Execusion Model which has been saved into DB</returns>
        public Task<Execution> ExecutePath(RobotCommandRequest commandRequest);
    }
}