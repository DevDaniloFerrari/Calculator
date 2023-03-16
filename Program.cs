void Sum()
{
    Console.Clear();
    Console.WriteLine("First value: ");
    float firstValue = float.Parse(Console.ReadLine());

    Console.WriteLine("Second value: ");
    float secondValue = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("The result of sum is: " + (firstValue + secondValue));
    Console.ReadKey();
    Menu();
}

void Subtraction(){
    Console.Clear();
    Console.WriteLine("First value: ");
    float firstValue = float.Parse(Console.ReadLine());

    Console.WriteLine("Second value: ");
    float secondValue = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("The result of subtraction is: " + (firstValue - secondValue));
    Console.ReadKey();
    Menu();
}

void Division(){
    Console.Clear();
    Console.WriteLine("First value: ");
    float firstValue = float.Parse(Console.ReadLine());

    Console.WriteLine("Second value: ");
    float secondValue = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("The result of division is: " + (firstValue / secondValue));
    Console.ReadKey();
    Menu();
}

void Multiplication(){
    Console.Clear();
    Console.WriteLine("First value: ");
    float firstValue = float.Parse(Console.ReadLine());

    Console.WriteLine("Second value: ");
    float secondValue = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    Console.WriteLine("The result of multiplication is: " + (firstValue * secondValue));
    Console.ReadKey();
    Menu();
}

void Menu(){
    Console.Clear();
    Console.WriteLine("Hello, what do you want to calculate?");
    Console.WriteLine("1 - Sum");
    Console.WriteLine("2 - Subtraction");
    Console.WriteLine("3 - Division");
    Console.WriteLine("4 - Multiplication");
    Console.WriteLine("5 - Exit");

    Console.WriteLine("--------------");
    Console.WriteLine("Select one option: ");
    short response = short.Parse(Console.ReadLine());

    switch (response)
    {
        case 1: Sum(); break;
        case 2: Subtraction(); break;
        case 3: Division(); break;
        case 4: Multiplication(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

Menu();