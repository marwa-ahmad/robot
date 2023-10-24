using Robot.Model;

namespace Robot.Service
{
    public interface ICleanService
    {
        /// <summary>
        /// Clean method will do actual cleaning
        /// </summary>
        /// <param name="commandRequest"></param>
        /// <returns></returns>
        public CleanResponse Clean(RobotCommandRequest commandRequest);
    }
}
