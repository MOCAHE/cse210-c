using System;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine($"You have {_score} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nNo goals to display.");
            return;
        }

        int counter = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{counter}. {goal.GetDetailsString()}");
            counter++;
        }
    }

    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
            return;
        }

        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\n1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal\n");
        Console.Write("Select goal type: ");

        string typeChoice = Console.ReadLine();
        Goal newGoal = null;

        switch (typeChoice)
        {
            case "1":
                Console.Write("\nEnter the short name for the Simple Goal: ");
                string simpleShortName = Console.ReadLine();
                Console.Write("Enter the description for the Simple Goal: ");
                string simpleDescription = Console.ReadLine();
                Console.Write("Enter the points for the Simple Goal: ");
                int simplePoints = int.Parse(Console.ReadLine());
                newGoal = new SimpleGoal(simpleShortName, simpleDescription, simplePoints);
                break;

            case "2":
                Console.Write("Enter the short name for the Eternal Goal: ");
                string eternalShortName = Console.ReadLine();
                Console.Write("Enter the description for the Eternal Goal: ");
                string eternalDescription = Console.ReadLine();
                Console.Write("Enter the points for the Eternal Goal: ");
                int eternalPoints = int.Parse(Console.ReadLine());
                newGoal = new EternalGoal(eternalShortName, eternalDescription, eternalPoints);
                break;

            case "3":
                Console.Write("Enter the short name for the Checklist Goal: ");
                string checklistShortName = Console.ReadLine();
                Console.Write("Enter the description for the Checklist Goal: ");
                string checklistDescription = Console.ReadLine();
                Console.Write("Enter the points for the Checklist Goal: ");
                int checklistPoints = int.Parse(Console.ReadLine());
                Console.Write("Enter the target for the Checklist Goal: ");
                int checklistTarget = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus for the Checklist Goal: ");
                int checklistBonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(checklistShortName, checklistDescription, checklistPoints, checklistTarget, checklistBonus);
                break;

            default:
                Console.WriteLine("Invalid choice!\n");
                return;
        }
        _goals.Add(newGoal);
        Console.WriteLine("\nGoal added successfully!\n");
    }

    public void RecordEvent()
    {
        // Listar las metas con números
        int counter = 1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{counter}. {goal.GetDetailsString()}");
            counter++;
        }

        // Pide al usuario seleccionar un número de meta
        Console.Write("Select the number of the goal you want to record: ");
        int goalNumber;
        bool isParsed = int.TryParse(Console.ReadLine(), out goalNumber);

        if (isParsed)
        {
            if (goalNumber > 0 && goalNumber <= _goals.Count)
            {
                Goal selectedGoal = _goals[goalNumber - 1];
                selectedGoal.RecordEvent();
                _score += selectedGoal.GetPoints();
                Console.WriteLine($"\n{selectedGoal.GetDetailsString()}. Current score: {_score}");
            }
            else
            {
                Console.WriteLine("Invalid selection!");
            }
        }

        else
        {
            Console.WriteLine("Invalid input!");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter the filename to save the goals (e.g goals.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (var goal in _goals)
            {
                // Usamos el método GetStringRepresentation() de la clase Goal para obtener la representación de string de la meta.
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename to load: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            // El primer índice (línea 0) contiene la puntuación.
            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(',');

                if (line.StartsWith("SimpleGoal:"))
                {
                    string shortName = parts[0].Substring("SimpleGoal:".Length);
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    bool isComplete = bool.Parse(parts[3]);

                    SimpleGoal loadedGoal = new SimpleGoal(shortName, description, points);
                    if (isComplete)
                    {
                        // Utilizar reflexión para establecer directamente _isComplete sin invocar RecordEvent
                        typeof(SimpleGoal).GetField("_isComplete", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(loadedGoal, true);
                    }
                    _goals.Add(loadedGoal);
                }

                else if (line.StartsWith("EternalGoal:"))
                {
                    string shortName = parts[0].Substring("EternalGoal:".Length);
                    string description = parts[1];
                    int points = int.Parse(parts[2]);

                    Goal loadedGoal = new EternalGoal(shortName, description, points);
                    _goals.Add(loadedGoal);
                }

                else if (line.StartsWith("ChecklistGoal:"))
                {
                    string shortName = parts[0].Substring("ChecklistGoal:".Length);
                    string description = parts[1];
                    int points = int.Parse(parts[2]);
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[3]);
                    int amountCompleted = int.Parse(parts[5]);

                    ChecklistGoal loadedGoal = new ChecklistGoal(shortName, description, points, target, bonus);
                    for (int j = 0; j < amountCompleted; j++)
                    {
                        loadedGoal.RecordEvent();  // Esto aumentará la cantidad completada.
                    }
                    _goals.Add(loadedGoal);
                }
            }

            Console.WriteLine("\nGoals loaded successfully!\n");
        }

        else
        {
            Console.WriteLine("\nNo saved goals found\n");
        }
    }
}