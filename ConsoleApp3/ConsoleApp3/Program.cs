int num1 = 37;
int num2 = 25;
int num3 = 20;

if ((num1 < num2) && (num1 < num3))

    {
        Console.WriteLine(num1);
    }
else if ((num2 < num1) && (num2 < num3))
    {
        Console.WriteLine(num2);
    }
    else 
{
        Console.WriteLine(num3);
    }
