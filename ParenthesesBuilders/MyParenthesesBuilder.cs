using System.Text;

using ValidParentheses.Exceptions;

namespace ValidParentheses.ParenthesesBuilders;

public class MyParenthesesBuilder : IParenthesesBuilder
{
    private StringBuilder _builder;
    public MyParenthesesBuilder()
    {
        _builder = new StringBuilder();
    }

    public string GenerateValidParentheses(int length)
    {
        if (length % 2 != 0 || length < 2) throw new LengthNotValidException("Length Must Be Even Number and Greater than 0!");
        int maxParentheses = length / 2;
        List<int> parenthesesLayers = new List<int>();

        parenthesesLayers.Add(0);
        _builder.Append("()");

        for (int i = 1; i < maxParentheses; i++)
        {
            int layer = Random.Shared.Next(0, parenthesesLayers.Max() + 2);
            parenthesesLayers.Add(layer);
        }

        parenthesesLayers = parenthesesLayers.Order().ToList();

        for (int i = 1; i < parenthesesLayers.Count; i++)
        {
            var possibleIndexes = FindPossibleIndexes(_builder.ToString(), parenthesesLayers[i]);
            int index = possibleIndexes[Random.Shared.Next(0, possibleIndexes.Count)];
            _builder.Insert(index, "()");
        }

        return _builder.ToString();
    }

    private List<int> FindPossibleIndexes(string parentheses, int layer)
    {
        List<int> indexes = new();
        int currentLayer = 0;

        for (int i = 0; i < parentheses.Length; i++)
        {
            if (parentheses[i] == '(') currentLayer++;
            else currentLayer--;
            if (currentLayer == layer) indexes.Add(i + 1);
        }

        return indexes;
    }

}
