Console.WriteLine("Enter number M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Enter number N:");
int numberN = int.Parse(Console.ReadLine());

int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}

Console.WriteLine($"Ackermann function for numbers A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");
