namespace SimpleWorkoutPlanner.Shared.Models;

public class Workout
{
    public bool Progression { get; set; }
    public List<Exercise>? Exercises { get; set; }
}