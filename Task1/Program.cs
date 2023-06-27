// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

bool enterResult = true;
int[] array = EnterNumbers();
int count = CountPositive(array);
if(enterResult) 
{
    PrintArray(array);
    PrintCountPositive(count);
}

int[] EnterNumbers()
{
    string stringArrs;
    Console.Write("Введите цифры через пробел: ");
    stringArrs = Console.ReadLine();
    var arr = stringArrs.Split(" ");
    int[] intArr = new int[arr.Length];
    int num = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(!int.TryParse(arr[i], out num)) 
        {
            Console.WriteLine("Вы введили не числa!");
            enterResult = false;
            break;
        }
        else intArr[i] = int.Parse(arr[i]);
    }
    return intArr;
}

int CountPositive(int[] arr)
{
    int count = 0;
    foreach (var el in arr)
    {
        if(el > 0) count++;
    }
    return count;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
}

void PrintCountPositive(int count)
{
    Console.Write($" -> {count}");
}