namespace Robot.Model
{
    public class Execution
    {
        public int Id { get; set; }

        /// <summary>
        /// timestamp of insertion
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// number of command elements
        /// </summary>
        public int Commands { get; set; }


        public int Result { get; set; }

        /// <summary>
        /// duration of the calculation in seconds.
        /// </summary>
        public double Duration { get; set; }
    }
}
