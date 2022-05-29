/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int GetNumber(string str)
{
    while (true)
    {
        Console.WriteLine(str);
        string num = Console.ReadLine();
        if (int.TryParse(num, out int number) == false)
            Console.WriteLine("Введено не число");
        else
            return number;
    }
}


double GetNumberArray(string str)
{
    while (true)
    {
        Console.WriteLine(str);
        string arr = Console.ReadLine();
        if (double.TryParse(arr, out double number_) == false)
            Console.WriteLine("Введено не число");
        else
            return number_;
    }
}
double[] Array(int length)
{
    double[] a = new double[length];
    for (int i = 0; i < length; i++)
    {

        a[i] = GetNumberArray($"Введите {i + 1}-й элемент массива");

    }
    return a;
}

void diffElement(double[] numer)
{
    double max = numer[0];
    double min = numer[0];
    int result = 0;
    for (int i = 0; i < numer.Length; i++)
    {
        if (numer[i] <= min) min = numer[i];

    }
    for (int i = 0; i < numer.Length; i++)
    {
        if (numer[i] >= max) max = numer[i];

    }

    Console.WriteLine(max - min);

}


void printArray(double[] num)
{
    Console.Write("[");
    for (int i = 0; i < num.Length; i++)
    {
        if (i < num.Length - 1)
            Console.Write(num[i] + ", ");
        else
            Console.Write(num[i] + "]:");
    }



}

int length = GetNumber("Введите размерность массива : ");
double[] rnd1 = Array(length);
Console.Write("Разница между максимальным и минимальным элементов массива");
printArray(rnd1);
diffElement(rnd1);

