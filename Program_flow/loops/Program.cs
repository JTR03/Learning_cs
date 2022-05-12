// for loops

int val = 15;
int[] nums = new int[] {3,20,25,30,28, 14, 15, 92, 6,35,54};
string str = "text in the string";

for (int i = 0; i < val; i++)
{
    Console.WriteLine("i is currently {0}", i);
}

// foreach-in loop, used to iterate over a sequence like arrays or string
// break and continue statement
foreach (int i in nums)
{
    if (i >= 20 && i < 29)
    {
        continue;
    }
    Console.WriteLine($"i is currently {i}");
    if(i >= 60){
        break;
    }
}

// var count = 0;
// foreach (char c in str)
// {
//     if (c == 'e')
//     {
//         count++;
//     }
//     Console.WriteLine(count);
// }

// while loops
 string inputStr = "";

// while (inputStr != "exit")
// {
//     inputStr = Console.ReadLine();
//     Console.WriteLine("you entered: {0}",inputStr);
// }

// do-while loop
do
{
    Console.WriteLine("enter text");
    inputStr = Console.ReadLine();   
    Console.WriteLine("you entered: {0}",inputStr);
} while (inputStr != "exit");


