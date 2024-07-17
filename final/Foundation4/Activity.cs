using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private DateTime date;
        private int minutes;

        protected Activity(DateTime date, int minutes)
        {
            this.date = date;
            this.minutes = minutes;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public string GetSummary()
        {
            return $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({minutes} min) - Distance: {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
        }

        public DateTime Date => date;
        public int Minutes => minutes;
    }
}
