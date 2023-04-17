// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

int ReadNum (string argument)
{
    int num;
    Console.WriteLine($"Input {argument}");
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("It,s not a number");
    }
    return num;
}

string IntersectionPoint (int a, int b, int c, int d)
{
    string result = String.Empty;
    double x;
    double y;
    if (a == c && b == d) result = "These lines match"; 
    if (a == c && b != d) result = "These lines are parallel"; 
    if (a != c && b != d)
    { 
        x = (d-b)/(a-c);
        y = a * x + b;
        result = ($"The point of intersection of thise lines - ({Math.Round(x,2)}; {Math.Round(y,2)})");
    }
    return result;
}

int k1 = ReadNum ("k1");
int b1 = ReadNum ("b1");
int k2 = ReadNum ("k2");
int b2 = ReadNum ("b2");
string intersection = IntersectionPoint (k1, b1, k2, b2);
Console.WriteLine();
Console.WriteLine(intersection);
