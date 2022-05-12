// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// operators
int x = 10, y = 5;
string a ="alphabets", b="letters";

// basic math operators
Console.WriteLine((x/y)*x);
Console.WriteLine(a + b);

// increment and decrement
x++;
y--;

// shorthand operator a = a + b
a += b;

// logical Operators 
Console.WriteLine(x > y && y >= 5);
Console.WriteLine(x > y || y >= 5);

// null-coalescing operator
string str = null;

Console.WriteLine(str ?? "unknown string");
str ??= "new string";
Console.WriteLine(str);