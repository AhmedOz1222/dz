Console.Write("Введите число ");
double a = double.Parse(Console.ReadLine());
for(int i = 1; i < a+1; i++)
    if (i%2 == 0){
        Console.Write(i + " ");
    }
