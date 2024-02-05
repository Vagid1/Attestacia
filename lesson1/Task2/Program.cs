// Задание 2
int m1 = 2;
int n1 = 3;

AkkermanFunction(m1, n1);

void AkkermanFunction(int m1, int n1)
{
    Console.Write(Akkerman(m1, n1));
}

int Akkerman(int m1, int n1)
{
    if (m1 == 0)
    {
        return n1 + 1;
    }
    else if (n1 == 0 && m1 > 0)
    {
        return Akkerman(m1 - 1, 1);
    }
    else
    {
        return (Akkerman(m1 - 1, Akkerman(m1, n1 - 1)));
    }
}