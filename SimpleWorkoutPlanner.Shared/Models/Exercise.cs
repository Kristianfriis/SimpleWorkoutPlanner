namespace SimpleWorkoutPlanner.Shared.Models;

public class Exercise
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? PictureUrl { get; set; }
    public int MinReps { get; set; }
    public int MaxReps { get; set; }
    public int Sets { get; set; }
    public TimeSpan Time { get; set; }
    public TimeSpan Pause { get; set; }
}