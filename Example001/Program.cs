// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void PositiveNumbers ()
{
    string a = String.Empty;
    int num;
    int sum = 0; 
    while (a != "N")
    {
        Console.WriteLine
        ("Input number or input N if you wont to finish");
        a = Console.ReadLine();
        if (int.TryParse(a, out num))
        {
            sum += 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine
    ($"The number of entered numbers that are greater than 0 is equal to {sum}");
}

PositiveNumbers();
