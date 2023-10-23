using Robot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
