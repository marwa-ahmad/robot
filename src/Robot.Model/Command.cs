using System.ComponentModel.DataAnnotations;

namespace Robot.Model
{
    public class Command
    {
        public Direction Direction { get; set; }

        [Range(0, 100000, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Steps { get; set; }
    }
}