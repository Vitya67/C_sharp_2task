Console.Write("Введіть кількість років: ");

int age = Convert.ToInt32(Console.ReadLine());

if (age >= 12 && age <= 18)
{
    Console.WriteLine("Цей вік є підлітковим.");
}
else
{
    Console.WriteLine("Цей вік не є підлітковим.");
}
