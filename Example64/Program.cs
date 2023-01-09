int num = int.Parse(Console.ReadLine());

OutputAllNaturalNumbersInInterval(num);

void OutputAllNaturalNumbersInInterval(int number)
{
    if(number < 0)
    {
        Console.WriteLine("Start over and enter a number greater than zero");
    }
    else if (number == 0) return;
    Console.Write("{0,4}", number);
    OutputAllNaturalNumbersInInterval (number - 1);
}
