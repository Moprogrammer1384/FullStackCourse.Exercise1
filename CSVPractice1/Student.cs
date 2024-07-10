using CsvHelper.Configuration.Attributes;
using System.Reflection.Metadata.Ecma335;

namespace CSVPractice1;

public class Student
{
    [Name("First Name")]
    public string FirstName { get; set; }

    [Name("Last Name")]
    public string LastName { get; set; }

    [Name("Father Name")]
    public string FatherName { get; set; }

    [Name("National Code")]
    public long NationalCode { get; set; }

    [Name("Grade")]
    public string Grade { get; set; }

    [Name("Total Average")]
    public double TotalAverage { get; set; }
}

