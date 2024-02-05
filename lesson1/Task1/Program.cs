//Задание 1
int m = 1;
int n = 5;
void nat(int m, int n)
{
    if (m > n)
    return;
    if (m % 2 == 0)
    {
        Console.Write($"{m}, ");
    }
    nat(m + 1, n);
}
nat(m, n);