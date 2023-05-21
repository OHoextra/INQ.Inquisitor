namespace INQ.Inquisitor.App.Exceptions;

public class ArgumentEmptyException : ArgumentException
{
    public ArgumentEmptyException(string paramName) : base("The argument may not be an empty collection.", paramName) { }
}

