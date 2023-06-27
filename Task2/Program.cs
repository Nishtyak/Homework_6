// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] coordinate = EnterCoordinate();
Console.WriteLine(Findintersection(coordinate));

double[] EnterCoordinate()
{
    string stringArrs;
    Console.Write("Введите коэффициенты b1, k1, b2, k2 через пробел: ");
    stringArrs = Console.ReadLine();
    var arr = stringArrs.Split(" ");
    double[] numArr = new double[arr.Length];
    double num = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(!double.TryParse(arr[i], out num)) 
        {
            Console.WriteLine("Введите числa!");
            break;
        }
        else numArr[i] = double.Parse(arr[i]);
    }
    return numArr;
}

string Findintersection (double[] coord)
{
    double b1 = coordinate[0];
    double k1 = coordinate[1];
    double b2 = coordinate[2];
    double k2 = coordinate[3];
    double x = 0;
    double y = 0;

    if(k1 == k2 && b1 == b2) return "Прямые совпадают";
    else if(k1 == k2) return "Прямые параллельны";
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        return $"Точка пересечения: x = {Math.Round(x, 2)}, y = {Math.Round(y, 2)}";
    }
}
