//Задание 3
void PrintArray(int[] array, int i)
{
    if(i < 0)
    {
        return;
    }
    if (i == array.Length)
    {
        return;
    }
    Console.Write(array[i]);
    PrintArray(array, i - 1);
}
int[] array = {1, 2, 5, 0, 10, 34};
PrintArray(array, 5);