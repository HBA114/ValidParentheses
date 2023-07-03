namespace ValidParentheses.Exceptions;

public class LengthNotValidException : Exception
{
    public LengthNotValidException(string? message) : base(message)
    {
    }
}
