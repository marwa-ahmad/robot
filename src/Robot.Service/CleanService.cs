using Robot.Model;

namespace Robot.Service
{
    public class CleanService : ICleanService
    {
        /// <summary>
        /// For simplicity we will make this clean service return random number for unique places & time of execusion
        /// </summary>
        /// <param name="commandRequest"></param>
        /// <returns>CleanResponse with random duration between 0 & 1. Returns NumberOfCleansedPlaces randmoly between 1 & 4</returns>
        /// <exception cref="NotImplementedException"></exception>
        public CleanResponse Clean(RobotCommandRequest commandRequest)
        {
            var random = new Random();
            return new CleanResponse()
            {
                Duration = random.NextDouble(),
                NumberOfCleansedPlaces = random.Next(1, 4)
            };
        }
    }
}
