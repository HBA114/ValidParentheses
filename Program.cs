using ValidParentheses.ParenthesesBuilders;

// Valid Parentheses Question from a Junior Developer Interview

IParenthesesBuilder myParenthesesBuilder = new MyParenthesesBuilder();
IParenthesesBuilder techBuddysParenthesesBuilder = new TechBuddysParenthesesBuilder();

string myResult = myParenthesesBuilder.GenerateValidParentheses(8);
string techBuddysResult = techBuddysParenthesesBuilder.GenerateValidParentheses(8);

Console.WriteLine($"My Result: {myResult}");
Console.WriteLine($"Tech Buddy's Result: {techBuddysResult}");
