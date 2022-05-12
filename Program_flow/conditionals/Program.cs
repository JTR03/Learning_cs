int val = 50;

// if else statements
if (val == 50)
{
    Console.WriteLine("value is 50");
}else if(val >= 50 && val <=60)
{
    Console.WriteLine("the value is between 50 and 60");
}
else
{
    Console.WriteLine("Value is not 50");
}

// ternary operators
Console.WriteLine(val < 50 ? "val is less then 50":"val is equal or greater then 50");

// switch statement
switch (val)
{
    case 50:
        Console.WriteLine("the val is 50");
        break;
    case 51:
        Console.WriteLine("the val is 51");
        break;
    case 52:
    case 53:
    case 54:
    case 55:
        Console.WriteLine("the val is between 52 and 55");
        break;
        
    default:
        Console.WriteLine("the val is some other num");
        break;
}