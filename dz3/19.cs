Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
int length = a.Length;
if (length == 5)
{
    if (a[0] == a[4] && a[1] == a[3])
        Console.WriteLine(a + " - число является палиндромом");
    else
        Console.WriteLine(a + " - не является числом палиндромом");
}
else
    Console.WriteLine(a + " - не пятизначное число");
