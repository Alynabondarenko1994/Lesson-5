/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int[] ArrayRandom(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
        arr[i] = rnd.Next(-100, 100);
    return arr;
}

void SumElement(int[] numer)
{
    int result = 0;
    for (int i = 0; i < numer.Length; i++)
    {
        if (i % 2 != 0) result = result + numer[i];

    }
    Console.Write(result);

}


void printArray(int[] num)
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
int[] rnd1 = ArrayRandom(length);
Console.Write("Сумма элементов, стоящих на нечётных позициях массива");
printArray(rnd1);
SumElement(rnd1);

