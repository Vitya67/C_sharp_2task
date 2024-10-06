        Console.Write("Введіть символ: ");

        char symbol = Convert.ToChar(Console.ReadLine().ToLower());

        if (symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u')
        {
            Console.WriteLine("Цей символ є голосною.");
        }
              else if (char.IsLetter(symbol))
        {
            Console.WriteLine("Цей символ є приголосною.");
        }
        else
        {
            Console.WriteLine("Цей символ не є літерою.");
        }