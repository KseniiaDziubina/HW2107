Console.WriteLine("Введите массив из восьми чисел: ");
{
int [] myArray = new int[8];
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:   ");
    myArray[i] = Convert.ToInt32(Console.ReadLine()); 
}


Console.WriteLine("\nВывод массива:");
    for ( int i = 0; i < myArray.Length; i++)
    {
    Console.Write(myArray[i] + " ");
    }
     Console.ReadLine();
}

