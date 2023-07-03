using ValidParentheses.ParenthesesBuilders;

// Valid Parentheses Question from a Junior Developer Interview

IParenthesesBuilder myParenthesesBuilder = new MyParenthesesBuilder();
string myResult = myParenthesesBuilder.GenerateValidParentheses(6);
Console.WriteLine($"My Result: {myResult}");
