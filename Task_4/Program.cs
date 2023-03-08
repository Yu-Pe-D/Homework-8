// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
Console.Clear();
            int i, n, c;
            Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");
            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                for (c = 0; c <= (n - i); c++) 
                {
                    Console.Write(" "); 
                }
                for (c = 0; c <= i; c++)
                {
                    Console.Write(" "); 
                    Console.Write(factorial(i) / (factorial(c) * factorial(i - c)));
                }
                Console.WriteLine();
            }
        
     static float factorial(int n)
        {
            float i, x = 1;
            for (i = 1; i <= n; i++)
            {
                x *= i;
            }
            return x;

        }
    

        