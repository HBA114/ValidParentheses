using ValidParentheses.ParenthesesBuilders;

// Valid Parentheses Question from a Junior Developer Interview

IParenthesesBuilder hba114sParenthesesBuilder = new HBA114sParenthesesBuilder();
IParenthesesBuilder techBuddysParenthesesBuilder = new TechBuddysParenthesesBuilder();

string hba114sResult = hba114sParenthesesBuilder.GenerateValidParentheses(8);
string techBuddysResult = techBuddysParenthesesBuilder.GenerateValidParentheses(8);

Console.WriteLine($"HBA114's Result: {hba114sResult}");
Console.WriteLine($"Tech Buddy's Result: {techBuddysResult}");
