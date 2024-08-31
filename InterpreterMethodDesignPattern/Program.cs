// Creating expressions: 1 + 2
using InterpreterMethodDesignPattern;

Expression expression = new AdditionExpression(new NumberExpression(1), new NumberExpression(2));

// Interpreting and evaluating the expression
int result = expression.Interpret();
Console.WriteLine("Result:" + result); // Output: 3
