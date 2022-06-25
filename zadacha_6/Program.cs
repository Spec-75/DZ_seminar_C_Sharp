Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
if (N % 2 == 0)
{
    Console.Write("Число ");
    Console.Write(N);
    Console.Write(" чётное.");
}
else
{
    Console.Write("Число ");
    Console.Write(N);
    Console.Write(" не чётное.");
}