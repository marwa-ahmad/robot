namespace Robot.Model
{
    public class RobotCommandRequest
    {
        public Start Start { get; set; }
        public List<Command> Commands { get; set; }
    }
}