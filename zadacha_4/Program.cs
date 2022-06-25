Console.WriteLine("Введите первое число ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число ");
int Number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (Number1 > Number2)
{
    max = Number1;
}
else
{
    max = Number2;
}
if (max < Number3)
{
    max = Number3;
}
Console.Write("Максимальное число ");
Console.Write(max);