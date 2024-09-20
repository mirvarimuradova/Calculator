
Console.WriteLine("Ededleri daxil edin ");
Console.Write("eded1:");
int eded1 = Convert.ToInt32( Console.ReadLine());

Console.Write("eded2:");

int eded2 = Convert.ToInt32(Console.ReadLine());
label1:
Console.Clear();
Console.WriteLine("Emeliyati teyin edin: \n" +
    "1.+\n" +
    "2.-\n" +
    "3.*\n" +
    "4./ \n");

string  emeliyyat = Console.ReadLine()??"";
 

int toplama(int x, int y)
{
    return x + y;
}
int cixma(int x, int y)
{
    return (x - y);
}
 int vurma(int x, int y)
{
    return x* y;
}
 float bolme(float x, float y)
{
    return x / y;
}

if (emeliyyat == "+")
{
    Console.WriteLine(toplama(eded1, eded2));
}

 else if (emeliyyat == "-")
{
    Console.WriteLine(cixma(eded1, eded2));
}
 else if (emeliyyat == "*")
{
    Console.WriteLine(vurma(eded1, eded2));
}
else if (emeliyyat == "/")
{
    Console.WriteLine(bolme(eded1, eded2));
}
else
{
    Console.WriteLine("Daxil olunan  emeliyyat yanlisdir:");
    goto label1;
}




