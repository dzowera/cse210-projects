using System;

public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public Entry()
    {

    }

    public override string ToString()
    {
        return $"{_date} - {_prompt}\n{_response}\n";
    }
}
