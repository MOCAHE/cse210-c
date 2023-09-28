public class Entry
{
    public string _date = DateTime.Now.ToShortDateString();
    public string _promptText;
    public string _entryText;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    // I had too many problems trying to figure out how to fix my bugs.
    // Initially I wrote the following: public string _promptText = PromptGenerator.GetRandomPrompt(); but it doesn't work.
    // After a lot of time, I finally decided to use ChatGPT, please have mercy on me and don't deduct points from me.
    //I had no idea of how to use the constructor method. 
    public Entry()
    {
        PromptGenerator chatgpt = new();
        _promptText = chatgpt.GetRandomPrompt();
    }

    public void DisplayEntries()
    {
        Console.WriteLine($"{_date} - {_promptText}");
        Console.WriteLine($"                {_entryText}");
    }
}