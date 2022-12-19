// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindCrossing( double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k2 * x) + b2;
    Console.WriteLine($" b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> x = {x}, y = {y}");
}

double EnterData(string text)
{
    Console.WriteLine(text);
    double num = double.Parse(Console.ReadLine());
    return num;
} 

// ввести поочередно значения коэффициентов
double b1 = EnterData("Введите коэффициент b1: ");
double k1 = EnterData("Введите коэффициент k1: ");
double b2 = EnterData("Введите коэффициент b2: ");
double k2 = EnterData("Введите коэффициент k2: ");
// находим совпадение координат
FindCrossing( b1, k1, b2, k2);