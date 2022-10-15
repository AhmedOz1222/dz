void Main(){
    Console.Write("Введите A: ");
    double A = double.Parse(Console.ReadLine());
    Console.Write("Введите B: ");
    int B = int.Parse(Console.ReadLine());
    double sum_degree = A;
    if (B == 0)
    {
        Console.Write("1");
    }
    if (B > 0)
    {
        Console.Write(Degree (A,B, sum_degree));
    }
}
double Degree(double A, int B, double sum_degree) {
    for (int i = 1; i < B ; ++i){
        sum_degree = A* sum_degree;
    }
    return sum_degree;
}
Main();