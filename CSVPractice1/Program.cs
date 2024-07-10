
using CSVPractice1;

CSVReader csvReader = new();
JsonWriter jsonWriter = new();
UserInteraction userInteraction = new();
StudentController studentController = new(userInteraction, csvReader, jsonWriter);

studentController.Execute();

Console.ReadLine();