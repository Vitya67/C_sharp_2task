        Console.Write("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть третє число: ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double max = num1;

        if (num2 > max)
        {
            max = num2;
        }

        if (num3 > max)
        {
            max = num3;
        }
        Console.WriteLine($"Найбільше число: {max}");
    
