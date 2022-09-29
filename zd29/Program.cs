int lenArray = ReadInt("Введите длинну массива: ");
int[] randomArray = new int[lenArray];
for (int num1 = 0; num1 < randomArray.Length; num1++)
{
    randomArray[num1] = new Random().Next(1,99);
    Console.Write(randomArray[num1] + " ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}