using System.Text.Json;
using SimpleWorkoutPlanner.Shared.Models;

namespace SimpleWorkoutPlanner.Client.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var ti = new Exercise()
        {
            Pause = new TimeSpan(0,0,60)
        };

        var parsed = JsonSerializer.Serialize(ti);
        
        Console.WriteLine(parsed);
    }
}