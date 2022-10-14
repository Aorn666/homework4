// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int c = 0;
while (a>0)
{
    c = c + a % 10;
    a = a/10;
}
Console.WriteLine(c);