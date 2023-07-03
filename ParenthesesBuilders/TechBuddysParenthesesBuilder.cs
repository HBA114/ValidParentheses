using System.Text;

using ValidParentheses.Exceptions;

namespace ValidParentheses.ParenthesesBuilders;

public class TechBuddysParenthesesBuilder : IParenthesesBuilder
{
    private StringBuilder _builder;
    private char[] _arr = new[] { '(', ')' };
    public TechBuddysParenthesesBuilder()
    {
        _builder = new StringBuilder();
    }

    public string GenerateValidParentheses(int length)
    {
        if (length % 2 != 0 || length < 2)
            throw new LengthNotValidException();

        return GenerateParentheses(length: length, openCount: 0, closeCount: 0);
    }

    private string GenerateParentheses(int length, int openCount, int closeCount)
    {
        int max = length / 2;
        int arrIndex = 0;

        if (openCount <= closeCount)
            arrIndex = 0;   // open
        else if (openCount == max && closeCount < max)
            arrIndex = 1;   // close
        else
            arrIndex = Random.Shared.Next(maxValue: 2);

        var p = _arr[arrIndex];
        _builder.Append(p);

        openCount += arrIndex == 0 ? 1 : 0;
        closeCount += arrIndex == 1 ? 1 : 0;

        if (openCount + closeCount >= length)
            return _builder.ToString();

        GenerateParentheses(length, openCount, closeCount);

        return _builder.ToString();
    }
}
