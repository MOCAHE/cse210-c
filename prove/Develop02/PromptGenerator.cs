public class PromptGenerator
{
    public Random _random = new();
    public List<string> _prompts = new()
    {
        "Queso 1",
        "Queso 2",
        "Queso 3",
        "Queso 4"
    };

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public PromptGenerator()
    { }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

}