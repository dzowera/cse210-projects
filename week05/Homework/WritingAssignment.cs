using System;

class WritingAssignment : Assignment
{
    private string _title; // Attribute specific to WritingAssignment

    // Constructor
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) // Call the base class constructor
    {
        _title = title; // Initialize WritingAssignment-specific attribute
    }

    // Method to get writing information
    public string GetWritingInformation()
    {
        
        // Use the title and student name to create the specific output
        return $"{_title} by {GetStudentName()}";
    }
}