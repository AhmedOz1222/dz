// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 2, 4, 9 -> [1, 2, 5, 7, 19, 2, 4, 9]
// 6, 1, 33, 2, 93, 15, 424, 0 -> [6, 1, 33, 2, 93, 15, 424, 0]

void Main()
{
    Console.Write("Введите ряд чисел, разделенных запятой: ");
    string? seriesOfNumbers = Console.ReadLine();
    seriesOfNumbers = seriesOfNumbers + ",";    //обозначения конца строки
    string seriesNew = RemovingSpaces(seriesOfNumbers);
    int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);
    PrintArry(arrayOfNumbers);
}
// функция удаления пробелов из строки 
string RemovingSpaces(string series)
{
    string seriesNew = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != ' ')
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
}
// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string seriesNew)
{

    int[]? arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

    int j = 0;

    for (int i = 0; i < seriesNew.Length; i++)
    {
        string seriesNew1 = "";

        while (seriesNew[i] != ',' && i < seriesNew.Length)
        {
            seriesNew1 += seriesNew[i];
            i++;
        }
        arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки  
        if (i < seriesNew.Length - 1)
        {
            arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray();    // добавляет новый нулевой элемент в конец массива
        }
        j++;
    }
    return arrayOfNumbers;
}
//вывод массива
void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

Main();