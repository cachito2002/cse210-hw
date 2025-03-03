using System;
using System.Collections.Generic;
public class ActivityTracker
{
    private Dictionary<string, int> _activityCounts;

    public ActivityTracker()
    {
        _activityCounts = new Dictionary<string, int>();
    }

    public void RecordActivity(string activityName)
    {
        if (_activityCounts.ContainsKey(activityName))
        {
            _activityCounts[activityName]++;
        }
        else
        {
            _activityCounts[activityName] = 1;
        }
    }

    public Dictionary<string, int> GetActivityCounts()
    {
        return _activityCounts;
    }

    public void DisplayStatistics()
    {
        Console.WriteLine("\n ---Activity Statistics---");

        if (_activityCounts.Count == 0)
        {
            Console.WriteLine("No activities have been recorded yet.");
            return;
        }

        foreach (var activity in _activityCounts)
        {
            Console.WriteLine($"{activity.Key}: {activity.Value} time{(activity.Value != 1 ? "s" : "")}");
        }

        int totalActivities = 0;
        foreach (var count in _activityCounts.Values)
        {
            totalActivities += count;
        }

        Console.WriteLine($"Total activities performed: {totalActivities}");
    }
}