namespace ExceptionConstructors;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter string or Null to test for Exception");
        string? text = Console.ReadLine();

        if (string.IsNullOrEmpty(text))
        {
            throw new CustomNullException();
            throw new CustomNullException("This is a Null Exception");
            throw new CustomNullException("This is a Null Exception", Exception());
        }
        else
        {
            Console.WriteLine($"You entered: {text}, a Custom Exception.");
        }
        
    }

    private static Exception Exception()
    {
        throw new NotImplementedException();
    }

    public class CustomNullException : Exception
    {
        public CustomNullException()
        {
        }
        public CustomNullException(string message) : base(message)
        {
        }
        public CustomNullException(string message, Exception innerexception) : base(message, innerexception)
        {
        }
    }


}

