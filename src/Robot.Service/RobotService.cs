﻿using Robot.Model;

namespace Robot.Service
{
    public class RobotService : IRobotService
    {
        private ICleanService _cleanService;
        private IDataStorageService _dataStorageService;

        public RobotService(ICleanService cleanService, IDataStorageService dataStorageService)
        {
            _cleanService = cleanService;
            _dataStorageService = dataStorageService;
        }

        public Execution ExecutePath(RobotCommandRequest commandRequest)
        {
            // Implement the robot cleaning logic
            var cleanResponse = _cleanService.Clean(commandRequest);
            var execusionModel = new Execution() 
            {
                Commands = commandRequest.Commands.Count(),
                Duration = cleanResponse.Duration,
                Result = cleanResponse.NumberOfCleansedPlaces,
                Timestamp = DateTime.UtcNow,
                Id = Guid.NewGuid().GetHashCode()
            };

            // Update the database with the result; add a new record
            var isSaved = _dataStorageService.Save(cleanResponse);
            if (isSaved == 0) throw new Exception("Failed to save Execusion Model.");
            return execusionModel;
        }
    }
}
