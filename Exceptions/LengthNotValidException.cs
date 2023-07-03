using ValidParentheses.Exceptions.ExceptionMessages;

namespace ValidParentheses.Exceptions;

public class LengthNotValidException : Exception
{
    public LengthNotValidException(string message = LengthNotValidMessage.message) : base(message)
    {
    }
}
