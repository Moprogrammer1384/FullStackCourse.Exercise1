
using CsvHelper;
using System.Globalization;

namespace CSVPractice1;

public class CSVReader : IReader
{
    public List<Student> Read(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"There is no file with this address : {filePath}");
        }
                                                
        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        return csv.GetRecords<Student>().ToList();
    }
}

