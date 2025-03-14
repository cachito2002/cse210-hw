class GoalManager
{
    private List<Goals> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goals>();
        _score = 0;
    }

    public void AddGoal(Goals goal)
    {
        _goals.Add(goal);
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int score)
    {
        _score = score;
    }
    public void RecordEvent(int index)
    {

        if (index >= 0 && index < _goals.Count)
        {
            int oldScore = _score;
            int oldLevel = (oldScore / 100) + 1;
            
            int pointsEarned = _goals[index].RecordEvent();
            _score += pointsEarned;

            int newLevel = (_score / 100) + 1;

            Console.WriteLine($"Congratulations! You made: {pointsEarned} points! ");

            if (newLevel > oldLevel)
            {
                var levelInfo = GetLevelInfo();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\n*** LEVEL UP! ***");
                Console.WriteLine($"YOU ARE NOW {levelInfo.level}: {levelInfo.title}!!!");
                Console.ResetColor();
            }
            Console.WriteLine($"THIS IS YOUR SCORE: {_score}");
        }

    }
    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet");
            return;
        }

        Console.WriteLine("Current Goals: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailString()}");
        }
    }
    public void SaveGoals(string filename)
    {

        if (!filename.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
        {
            filename += ".txt";
        }
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
           outputFile.WriteLine(_score);
            foreach (Goals goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals SAVED!!");
    }
    public void LoadGoals(string filename)
    {

        if (!filename.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
        {
            filename += ".txt";
        }

        _goals.Clear();

        if (!File.Exists(filename))
        {
            Console.WriteLine($"File {filename} NOT FOUND");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        if (lines.Length > 0)
        {
            _score = int.Parse(lines[0]);


            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(":");

                string goalType = parts[0];
                string[] goalData = parts[1].Split(",");

                switch (goalType)
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(goalData[0], goalData[1], int.Parse(goalData[2]), bool.Parse(goalData[3])));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(goalData[0], goalData[1], int.Parse(goalData[2])));
                        break;
                    case "ChecklistGoal":
                        _goals.Add(new ChecklistGoal(goalData[0], goalData[1], int.Parse(goalData[2]), int.Parse(goalData[3]), int.Parse(goalData[4]), int.Parse(goalData[5])));
                        break;
                }
            }
        }

        Console.WriteLine($"Goals LOADED {filename}!!");

    }

    public void CreateGoal()
    {
        Console.WriteLine("THESE ARE THE GOALS FOR YOUR JOURNEY");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Choose the type of goal you want to create: ");

        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the description of the goal: ");
        string description = Console.ReadLine();

        Console.WriteLine("How many points will this goal be?: ");
        int points = int.Parse(Console.ReadLine());

        Goals newGoal;

        switch (choice)
        {
            case 1:
                newGoal = new SimpleGoal(name, description, points);
                break;
            case 2:
                newGoal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("How many times will need to complete this goal to get a bonus?: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for completing this goal?: ");
                int bonus = int.Parse(Console.ReadLine());

                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("That goal is invalid, please try again");
                return;
        }

        AddGoal(newGoal);
        Console.WriteLine("Goal CREATED!!!");

    }

    public (int level, string title) GetLevelInfo()
    {
        int level = (_score / 100) + 1;

        string[] titles = {
            "A GREENIE",
            "A NOVICE",
            "A JOURNEYMAN",
            "A MASTER",
            "A LEGEND",
            "THE MASETER OF THE UNIVERSE",
            "THE ONE AND ONLY JOHN CENA",
            "EPIC WIZARD",
            "A WARRIOR",
            "THE ULTIMATE SUPER MAUI"
        };
        string title = titles[Math.Min(level - 1, titles.Length - 1)];
        return (level, title);
    }











}