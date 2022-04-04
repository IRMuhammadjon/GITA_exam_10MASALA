Console.WriteLine("1-sonni kiriting: ");
var a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2-sonni kiriting: ");
var b = Convert.ToInt32(Console.ReadLine());
while (a!=0 && b!=0)
{
    if(a>b)
    {
        a = a % b;
    }
    else
    {
        b= b % a;
    }
}
Console.WriteLine(a + b);