Console.Write("Введите a ");
int a = int.Parse(Console.ReadLine());
if (a/100<1)
    Console.Write("Вы ввели не трех значное число");
else
    Console.Write((a%1000-a%100)/100);