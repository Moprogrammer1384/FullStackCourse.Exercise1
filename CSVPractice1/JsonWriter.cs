
using System.Text.Json;

namespace CSVPractice1;

public class JsonWriter : IWriter
{
    public void Write(List<Student> students, string filePath)
    {
        if (!Directory.Exists(filePath))
        {
            throw new DirectoryNotFoundException($"There is no directory with this address: {filePath}");
        }
        string json = "";

        foreach (var student in students)
        {
            json = JsonSerializer.Serialize(student);
            using (var file = File.Create($"{filePath}\\{student.NationalCode}.json"))        
            File.WriteAllText($"{filePath}\\{student.NationalCode}.json", json);
        }
    }
}

