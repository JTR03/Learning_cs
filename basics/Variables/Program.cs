// Program that prints out different variables and data types

int age = 10;
bool isAwesome = true;
char initial = 'J';
// decimal GPA = 52.4;
float f = 2.0f;
string name = "Junior Calmo";

// implicit variables
var i = 125;
var str = "Structure of the world";

// array of values
int[] vals = new int[5];
string[] strs = {"one","two","three"};

Console.WriteLine("{0},{1},{2},{3},{4},{5},{6}", age,isAwesome,initial,i,f,name,str);

// implicit conversion
long bignum;
bignum = i;

// explicit conversion
float i_to_f = (float)i;
Console.WriteLine("{0}",i_to_f);

int f_to_i = (int)f;
Console.WriteLine("{0}",f_to_i);

