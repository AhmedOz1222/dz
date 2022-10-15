//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.
//  [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[size];
ArrayRandomNumbers(array1);
Console.WriteLine("массив: ");
PrintArray(array1);
Console.WriteLine("Кол-во чет. чисел: " + NumberEvenNumbers(array1));

void PrintArray(int[] array1)// Выводит масив
{
    Console.Write("[");
    for(int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i]);
        if ( i != array1.Length-1){
          Console.Write(" ");
        }
    }
    Console.WriteLine("]");
}

void ArrayRandomNumbers(int[] array1)//заполняет массив случайными числами 
{
    for(int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(100,1000);
    }
}

int NumberEvenNumbers(int[] array1)//кол-во чет чисел 
{
  int j = 0;
  for (int i = 0; i < array1.Length; i++){
    if (array1[i] % 2 == 0)
    j++;  
  }
  return j;
}


