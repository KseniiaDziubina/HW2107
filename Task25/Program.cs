Console.Write("Введите число для возведения в степень:  ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень, в которую нужно возвести число:  ");
int numberB = Convert.ToInt32(Console.ReadLine());
int GetPower(int numberA, int numberB)
{
    int Power = 1;
    for(int i=0; i < numberB; i++)
    {
        Power = Power*numberA;
    }
    return Power;
}
int Power = GetPower(numberA,numberB);
Console.WriteLine($"Возведение числа {numberA} в степень {numberB} равно {Power}");

