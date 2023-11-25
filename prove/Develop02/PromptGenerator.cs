public class PromptGenerator 
{
    public List<string> _prompts = new List<string>  
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something that made you laugh today?",
        "Who made your day better today?",
        "What is one thing you want to remember from today?",
        "What steps did you take today towards a goal you’re working on?",
        "How can you make tomorrow (even) better than today?",
        "What went well today?",
        "What’s a simple pleasure in your life that you are thankful for?",
        "How did you show love to someone today?",
        "How would you describe your spirituality today?",
        "What was your magic power today?",
        "Identify three times that you felt challenged today.",
        "What do I need to let go of today?",
        "What do you need the most right now?",
        "If you could only accomplish three things tomorrow, what would they be?",
        "What was the most peaceful moment during the day?",
        "Would you change any of the decisions you made today?",
        "What frightened you today?",
        "Who do you wish you had talked to today? What would you say?",
        "If you’d had another hour during the day, how would you have spent it?"
    };

    public PromptGenerator()
    {

    }
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }  
}


