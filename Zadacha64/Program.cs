
void Natural(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        Natural(n, count + 1);
        Console.Write(count + " ");
    }
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
Natural(number, count);