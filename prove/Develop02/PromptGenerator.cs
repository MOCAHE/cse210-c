public class PromptGenerator
{
    public Random _random = new();
    public List<string> _prompts = new()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Did you learn something new today?",
        "Describe a moment from your childhood that taught you an important lesson",
        "Imagine you're in a completely new and unfamiliar place. Describe your thoughts and emotions as you explore this place.",
        "What is a goal or dream you want to achieve soon? Detail how you plan to accomplish it.",
        "Reflect on a recent conversation you had with someone. How did that conversation make you feel? Did you learn something new?"
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