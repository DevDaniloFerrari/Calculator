void Sum()
{
    Console.Clear();
    Console.WriteLine("First value: ");
    float firstValue = float.Parse(Console.ReadLine());

    Console.WriteLine("Second value: ");
    float secondValue = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("The result of sum is: " + (firstValue + secondValue));
}

void Subtraction(){
    Console.Clear();
    Console.WriteLine("First value: ");
    float firstValue = float.Parse(Console.ReadLine());

    Console.WriteLine("Second value: ");
    float secondValue = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("The result of subtraction is: " + (firstValue - secondValue));
}

void Division(){
    Console.Clear();
    Console.WriteLine("First value: ");
    float firstValue = float.Parse(Console.ReadLine());

    Console.WriteLine("Second value: ");
    float secondValue = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("The result of subtraction is: " + (firstValue / secondValue));
}

Division();