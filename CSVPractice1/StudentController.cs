using System.Drawing;
using System.Runtime.InteropServices;

namespace CSVPractice1;

public class StudentController
{
    private readonly IUserInteraction _userInteraction;
    private readonly IReader _reader;
    private readonly IWriter _writer;

    public StudentController(IUserInteraction userInteraction, IReader reader, IWriter writer)
    {
        this._userInteraction = userInteraction;
        this._reader = reader;
        this._writer = writer;
    }

    internal void Execute()
    {
        try
        {
            _userInteraction.PrintMessage("Welcome to student manager app");
            _userInteraction.PrintMessage("Enter your input file address: ");
            string Address = _userInteraction.RecieveAddress();
            var students = _reader.Read(Address);
            _userInteraction.PrintMessage("Enter your output file address: ");
            string outPutAddress = _userInteraction.RecieveAddress();
            _writer.Write(students, outPutAddress);
        }
        catch (DirectoryNotFoundException ex)
        {
            _userInteraction.PrintMessage(ex.Message);
        }
        catch(FileNotFoundException ex)
        {
            _userInteraction.PrintMessage(ex.Message);
        }
        catch(Exception ex)
        {
            _userInteraction.PrintMessage(ex.Message);
        }
        finally
        {
            _userInteraction.PrintMessage("Done");
        }
    }
}


