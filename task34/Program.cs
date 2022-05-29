/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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
        arr[i] = rnd.Next(100, 1000);
    return arr;
}

void arrayEven(int[] numer)
{
    int result = 0;
    for (int i = 0; i < numer.Length; i++)
    {
        if (numer[i] % 2 == 0) result = result + 1;

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
Console.Write("Количество чётных чисел в массиве ");
printArray(rnd1);
arrayEven(rnd1);

