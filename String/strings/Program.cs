// string operations

string outstr;
string str1 = "the quick brown fox jumped over the lazy dog";
string str2 = "this is some string";
string str3 = "THIS is a STRING";
string[] strs = {"one","two","three","four"};

Console.WriteLine(str1.Length);
Console.WriteLine(str1[12]);
foreach (char c in str1)
{
    Console.Write(c);
    if (c == 'j')
    {
        Console.WriteLine();
        break;
    }
}

outstr = String.Concat(strs);
Console.WriteLine(outstr);

outstr = String.Join(".",strs);
Console.WriteLine(outstr);

outstr = String.Join("---",strs);
Console.WriteLine(outstr);

// string comparition

int result = String.Compare(str2, "this is some text");
Console.WriteLine(result);

bool isEqual = str2.Equals(str3);
Console.WriteLine(isEqual);

// String search
Console.WriteLine(str1.IndexOf('e'));
Console.WriteLine(str1.IndexOf("fox"));
Console.WriteLine(str1.LastIndexOf('e'));
Console.WriteLine(str1.LastIndexOf("lazy"));

outstr = str1.Replace("fox","cat");
Console.WriteLine(outstr);
Console.WriteLine(outstr.IndexOf("fox"));

