void Main()
{
    Console.WriteLine((int)(254 / Math.Pow(10, 2)));
    Console.Write("Введите число: ");
    int A = int.Parse(Console.ReadLine());
    int number_of_digits = NumberOfDigits(A);
    int sum_of_digits = SumOfDigits(A, number_of_digits);
    Console.WriteLine(sum_of_digits);
}

void Main(){
    Console.WriteLine( (int)(254 / Math.Pow(10, 2)) );
    Console.Write("Введите число: ");
    int A = int.Parse(Console.ReadLine());
    int number_of_digits = NumberOfDigits(A);
    int sum_of_digits = SumOfDigits(A, number_of_digits);
    Console.WriteLine( sum_of_digits );    
}

int NumberOfDigits(int A) {//находит количество цифр = (number_of_digits)
    int number_of_digits = 1;
    bool i = true;
    while (i)
    {
        if( A / Math.Pow(10, number_of_digits) < 1){
            i = false;
        }
        else{
            number_of_digits++;
        }
    }
    return number_of_digits;
}

int SumOfDigits(int A, int number_of_digits) {//находит сумму цифр = (sum_of_digits)
    int sum_of_digits = 0;
    int j = 0; // цифры числа
    
    for (int i = number_of_digits-1; i > -1; i--)//находим каждую цифру и прибавляем ее к sum_of_digits
    {
        j = Convert.ToInt32((int)(A / Math.Pow(10, i)) -  Convert.ToInt32( (int)(A / Math.Pow(10, i+1)) ) *  10 );//находим каждую цифру
        sum_of_digits += j;//цифру прибавляем к sum_of_digits
    } 
    return sum_of_digits;
}
Main();