using Extension_methods;

int x = 9;
if(x.GreaterThanTen())
{
    Console.WriteLine("Valid number"); 
}
else
{
    Console.WriteLine("Invalid number");
}

Console.WriteLine("Enter string value");
var str = Console.ReadLine();
Console.WriteLine(str.RemoveWhiteSpaces().Reverse());