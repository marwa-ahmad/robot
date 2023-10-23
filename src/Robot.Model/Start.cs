using System.ComponentModel.DataAnnotations;

namespace Robot.Model
{
    public class Start
    {
        [Range(-100000, 100000, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int X { get; set; }

        [Range(-100000, 100000, ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        public int Y { get; set; }
    }
}