        Console.Write("Введіть довжину сторони a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину сторони b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину сторони c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double longest = a;
        string longestSide = "a";

        if (b > longest)
        {
            longest = b;
            longestSide = "b";
        }

        if (c > longest)
        {
            longest = c;
            longestSide = "c";
        }

        Console.WriteLine($"Найдовша сторона: {longestSide}, її довжина: {longest}");
