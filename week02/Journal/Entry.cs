using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public Entry()
    {
        // Empty constructor (you can add initialization later)
    }

    public override string ToString()
    {
        return $"{_date} - {_prompt}\n{_response}\n";
    }
}
