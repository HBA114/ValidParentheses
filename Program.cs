// Valid Parentheses Question from a Junior Developer Interview

using System.Text;

var res = GeneratePattern(10);
Console.WriteLine($"Result: {res}");

string GeneratePattern(int length = 6)
{
    if (length % 2 != 0 || length < 2) return "Length Must Be Even Number and Greater than 0!";
    StringBuilder builder = new StringBuilder();
    int maxParentheses = length / 2;
    List<int> parenthesesLayers = new List<int>();
    Random random = new Random();

    parenthesesLayers.Add(0);
    builder.Append("()");

    for (int i = 1; i < maxParentheses; i++)
    {
        int layer = random.Next(0, parenthesesLayers.Max() + 2);
        parenthesesLayers.Add(layer);
    }

    parenthesesLayers = parenthesesLayers.Order().ToList();

    for (int i = 0; i < parenthesesLayers.Count; i++)
    {
        Console.WriteLine($"i: {i}, Layer: {parenthesesLayers[i]}");
    }

    for (int i = 1; i < parenthesesLayers.Count; i++)
    {
        var possibleIndexes = FindPossibleIndexes(builder.ToString(), parenthesesLayers[i]);
        int index = possibleIndexes[random.Next(0, possibleIndexes.Count)];
        builder.Insert(index, "()");
    }

    return builder.ToString();
}

List<int> FindPossibleIndexes(string parentheses, int layer)
{
    List<int> indexes = new();
    int currentLayer = 0;

    for (int i = 0; i < parentheses.Length; i++)
    {
        if (parentheses[i] == '(')
            currentLayer++;
        else
            currentLayer--;

        if (currentLayer == layer) indexes.Add(i + 1);
    }

    return indexes;
}
