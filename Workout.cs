﻿#region WorkoutClass

namespace HealthAndFitnessTracker
{

    public class Workout
    {
        #region Properties
        public int WorkoutId { get; set; }
        public int PersonId { get; set; }
        public DateTime WorkoutDate { get; set; }
        public string WorkoutType { get; set; } = string.Empty;
        public TimeSpan Duration { get; set; }
        public double CaloriesBurned { get; set; }
        public TimeOnly WorkoutStart { get; set; }
        public TimeOnly WorkoutFinished { get; set; }

        #endregion

        #region Constructors
        // The Workout class primarily deals with representing workout data. (Single Responsibility Principle)
        // This constructor initializes workout-related properties.
        public Workout() { }
        public Workout(DateTime workoutDate, string workoutType, TimeOnly WorkoutStart, TimeOnly WorkoutFinished, double caloriesBurned, int PersonId)
        {
            if (WorkoutStart > WorkoutFinished)
            {
                Console.WriteLine("Invalid workout duration. Please ensure the start time is before the finish time.");
            }

            (WorkoutStart, WorkoutFinished) = (WorkoutFinished, WorkoutStart);

            this.WorkoutDate = workoutDate;
            this.WorkoutType = workoutType;
            this.Duration = WorkoutStart - WorkoutFinished;
            this.CaloriesBurned = caloriesBurned;
            this.PersonId = PersonId;
        }
        #endregion

    }
}

#endregion