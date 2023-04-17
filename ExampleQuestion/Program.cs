// Попытка сделать ввод чисел от Пользователя, где условием окончания ввода будет нажатие символа "N"
// Пока не введено "N", просто считаю сумму введенных чисел. Можно вместо этого запустить какую-то функцию,
// например, подсчёт положительных чисел.

void EnterMumbers ()
{
    string a = String.Empty;
    int num;
    int sum = 0;
    while (!(a == "N")) // Вот тут, по моему, что-то не то. 
    {
        Console.WriteLine
        ("Input number or input N if you wont to finish");
        int.TryParse(Console.ReadLine(), out num);
        sum += num;
        
    }
    Console.WriteLine(sum);
}

EnterMumbers();

