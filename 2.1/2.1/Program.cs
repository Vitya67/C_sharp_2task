        Console.Write("Введіть число: ");

        double number = Convert.ToDouble(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Число додатнє.");
        }
        else if (number < 0)
        {
            Console.WriteLine("Число від'ємне.");
        }
        else
        {
            Console.WriteLine("Число дорівнює нулю.");
        }
   