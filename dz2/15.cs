Console.Write("Введите a ");
int a = int.Parse(Console.ReadLine());
if (a<1 || a>7)
    Console.Write("Число не обозначает день недели");
else{
    if (a%6==0 || a%7==0)
        Console.Write("да");
    else
        Console.Write("нет");
}