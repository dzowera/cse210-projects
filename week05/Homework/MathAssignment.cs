using System;

class MathAssignment : Assignment
{
    // Additional attributes unique to MathAssignment
    private string _homeworkList;

    // Constructor
    public MathAssignment(string studentName, string topic, string homeworkList)
        : base(studentName, topic) // Call base class constructor
    {
        _homeworkList = homeworkList;
    }

    // Method to get the homework list
    public string GetHomeworkList()
    {
        return _homeworkList;
    }
}