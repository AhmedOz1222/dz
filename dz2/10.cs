Console.Write("Введите a ");
int a = int.Parse(Console.ReadLine());
if (a/100<1 || a/100>9)
    Console.Write("Вы ввели не трех значное число");
else
    Console.Write((a%100-a%10)/10);
