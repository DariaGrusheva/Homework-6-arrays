//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double DataEntry(string text) // метод, запрашивающий данные у пользователя
{
    Console.WriteLine(text);
    double number = double.Parse(Console.ReadLine());
    return number;
}

double FindingTheAbscissa(double k1, double k2, double b1, double b2) // метод, находящий абсциссу
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    return x;
}

double FindingTheOrdinate(double k1, double b1, double x) // метод, находящий ординату
{
    double y = Math.Round(k1 * x + b1, 2);
    return y;
}


double k1 = DataEntry("Введите угловой коэффициент первой прямой: ");
double b1 = DataEntry("Введите ординату точки пересечения с Оу первой прямой: ");
double k2 = DataEntry("Введите угловой коэффициент второй прямой: ");
double b2 = DataEntry("Введите ординату точки пересечения с Оу второй прямой: ");
Console.WriteLine();
double x = FindingTheAbscissa(k1, k2, b1, b2);
double y = FindingTheOrdinate(k1, b1, x);
if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны.");
}
else
{
    Console.WriteLine($"Точка пересечения прямых имеет координаты: ({x};{y}).");
}
