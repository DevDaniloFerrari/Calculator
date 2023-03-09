void Sum()
{
    Console.WriteLine("First value: ");
    float firstValue = float.Parse(Console.ReadLine());

    Console.WriteLine("Second value: ");
    float secondValue = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("The result of sum is: " + (firstValue + secondValue));
}

Sum();