namespace ExerciseTracking
{
    public class Cycling : Activity
    {
        private double speed; // in kilometers per hour

        public Cycling(DateTime date, int minutes, double speed)
            : base(date, minutes)
        {
            this.speed = speed;
        }

        public override double GetDistance()
        {
            return (speed * Minutes) / 60;
        }

        public override double GetSpeed()
        {
            return speed;
        }

        public override double GetPace()
        {
            return 60 / speed;
        }
    }
}
