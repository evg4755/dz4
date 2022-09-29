int num1 = ReadInt("Введите число A: ");
int num2 = ReadInt("Введите число B: ");
ToDegree(num1, num2);
void ToDegree(int num11, int num22)
{
    int result = 1;
    for (int i = 1; i <= num22; i++)
    {
        result = result * num11;
    }
    Console.WriteLine(result);
}
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}