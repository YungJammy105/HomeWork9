Console.WriteLine("Enter number N:");
int numberM  = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number M:");
int numberN = int.Parse(Console.ReadLine());

SumNumbersInInterval(numberM, numberN, 0);

void SumNumbersInInterval (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Sum of natural elements between N and M: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    SumNumbersInInterval(numberM, numberN, sum);
}
