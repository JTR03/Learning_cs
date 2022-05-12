int x = 100;
int y = 0;
int result;

try
{
    result = x/y;
    Console.WriteLine($"result is: {result}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine("You can't divide by zero");
    Console.WriteLine(e.Message);
}
finally{
    Console.WriteLine("code always runs");
}
