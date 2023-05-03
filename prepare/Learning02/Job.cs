using System;
public class Job
{
    public string _myJobs;
    public string _myTitle;
    public string _companyTitle;
    public int _beginningYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_myJobs} {_myTitle} ({_companyTitle}) {_beginningYear}-{_endYear}");
    }

}