using System.ComponentModel.DataAnnotations;

namespace Robot.Model
{
    public class Command
    {
        public Direction Direction { get; set; }
        public int Steps { get; set; }
    }
}