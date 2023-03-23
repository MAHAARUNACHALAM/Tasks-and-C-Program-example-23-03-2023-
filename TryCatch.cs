//Try Catch

public class InvalidAgeException : Exception
{
    public InvalidAgeException(String message)
        : base(message)
    {

    }
}

class TryCatch
{

    static void validate(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Sorry, Age must be greater than 18");
        }
    }
    static void Main(String[] args)
    {
        int a = 10;
        int b = 0;
        int c;
        try
        {
            validate(a / b);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("Try diving by a number other than 0");
        }

        catch (InvalidAgeException e)
        {
            Console.WriteLine(e);
            Console.WriteLine("User defined exception is called");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error  " + e);
        }

    }
}