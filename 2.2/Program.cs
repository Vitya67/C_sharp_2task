        Console.Write("Введіть рік: ");

        int year = Convert.ToInt32(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.WriteLine($"{year} рік є високосним.");
        }
        else
        {
            Console.WriteLine($"{year} рік не є високосним.");
        }
   