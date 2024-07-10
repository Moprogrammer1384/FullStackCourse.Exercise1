namespace CSVPractice1;

public class UserInteraction : IUserInteraction
{    
    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public string RecieveAddress()
    {        
        return Console.ReadLine();  
    }
}

