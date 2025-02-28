public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _duration;


    public Activity(string activityName, string activityDescription, int duration)
        {
            _activityName = activityName;
            _activityDescription = activityDescription;
            _duration = duration;
        }

    public string GetActivityName()
        {
            return _activityName;
        }

    public string GetActivityDescription()
        {
            return _activityDescription;
        }
}