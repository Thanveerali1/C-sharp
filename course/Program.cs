using System;


class Course
{
    protected void ShowDetails()
    {
        Console.WriteLine("Course Name: Introduction to C#");
        Console.WriteLine("Duration: 4 weeks");
    }
}

class OnlineCourse : Course
{
    public void DisplayCourse()
    {
     
        ShowDetails();
    }
}


class Program
{
    static void Main()
    {
        OnlineCourse oc = new OnlineCourse();

        oc.DisplayCourse();
        Console.ReadLine();
    }
}
