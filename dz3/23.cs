Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());
for(int i = 1; i < N+1; ++i){
    Console.Write(Math.Pow(i, 3) + " ");
}