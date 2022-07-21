Console.Write("Введите число    "); 
int Number = Convert.ToInt32(Console.ReadLine()); 

int Sum = 0;
while (Number > 0)
{
    Sum += Number %10;
    Number = Number/10;
}
Console.WriteLine($"Сумма цифр в числе равна: {Sum}");