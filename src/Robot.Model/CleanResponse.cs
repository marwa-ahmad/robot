namespace Robot.Model
{
    public class CleanResponse
    {
        /// <summary>
        /// The number of unique places cleaned
        /// </summary>
        public int NumberOfCleansedPlaces { get; set; }

        /// <summary>
        /// duration of the calculation in seconds.
        /// </summary>
        public double Duration { get; set; }
    }
}