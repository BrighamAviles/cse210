namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int laps;
        private const double LapDistance = 50; // meters per lap

        public Swimming(DateTime date, int minutes, int laps)
            : base(date, minutes)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return (laps * LapDistance) / 1000; // convert meters to kilometers
        }

        public override double GetSpeed()
        {
            return (GetDistance() / Minutes) * 60;
        }

        public override double GetPace()
        {
            return Minutes / GetDistance();
        }
    }
}
