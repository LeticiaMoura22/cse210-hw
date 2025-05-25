public class Entry
{
    public string date;
    public string prompt;
    public string response;

    public Entry(string date, string prompt, string response)
    {
        this.date = date;
        this.prompt = prompt;
        this.response = response;
    }

    public string GetEntryText()
    {
        return $"Date: {date}\nPrompt: {prompt}\nResponse: {response}\n";
    }

    public string ToFileString()
    {
        return $"{date}|{prompt}|{response}";
    }

    public static Entry FromFileString(string line)
    {
        var parts = line.Split('|');
        return new Entry(parts[0], parts[1], parts[2]);
    }
}
