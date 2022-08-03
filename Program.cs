// написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры
// либо задать на старте выполнения алгоритма.
// Примеры:
// ["hello", "2", "world", ":-)"] => ["2", ":-)"]
void PrintArray(string[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < len - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i] + "]");
    }
    Console.WriteLine();
}

string[] Array3AndLess(string[] array)
{
    int len = array.Length;
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i].Length <= 3)
            count++;
    }
    string[] resultArray = new string[count];
    int j = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;
}

string[] initArray = new string[] { "RUSSIA", "Denmark", "Kazan" };
if (Array3AndLess(initArray).Length == 0)
    Console.Write("[]");
else
    PrintArray(Array3AndLess(initArray));
