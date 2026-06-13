using System;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        // Encapsulation: Private member variables
        private DateTime _date;
        private int _minutes;

        // Constructor
        public Activity(DateTime date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        // Getters to allow derived classes to access private fields safely
        public DateTime GetDate() => _date;
        public int GetMinutes() => _minutes;

        // Polymorphism: Abstract methods to be overridden by derived classes
        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        // Shared method available to all classes
        public virtual string GetSummary()
        {
            return $"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_minutes} min) - " +
                   $"Distance: {GetDistance():F1} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }
}
