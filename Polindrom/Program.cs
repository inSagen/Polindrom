// See https://aka.ms/new-console-template for more information

int data = 121;
int data2 = data;
int b = 0;
while (b < data)
{
    b = b * 10 + data2 % 10;
    data2 = data2 / 10;
    if (data2 == b)
    {
        Console.WriteLine($"{data} - полиндромное число");
        return;
    }
}
Console.WriteLine($"{data} - не полиндромное число!");
