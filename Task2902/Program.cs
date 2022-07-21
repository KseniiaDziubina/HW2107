Console.WriteLine("Массив:   ");
int [] Array2 = new int[8];
Random range = new Random();

    for (int i = 0; i < Array2.Length; i++)
         {
            Array2[i] = range.Next(99);
            Console.WriteLine(Array2[i]);
         }

