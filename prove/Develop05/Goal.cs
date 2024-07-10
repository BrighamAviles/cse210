public abstract class Goal
{
    public string _shortName;  // Changed to protected
    public string _description;  // Changed to protected
    public int _points;  // Changed to protected

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Points: {_points})";
    }

    public abstract string GetStringRepresentation();
}
