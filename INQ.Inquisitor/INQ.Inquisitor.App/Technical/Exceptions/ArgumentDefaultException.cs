namespace INQ.Inquisitor.App.Exceptions;

public class ArgumentDefaultException : ArgumentException
{
    public ArgumentDefaultException(string paramName) : base("The argument may not be equal to the default value.", paramName) { }
}