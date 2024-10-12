class Program 
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Enter the first number / Введите первое число");

        if (!Int32.TryParse(Console.ReadLine(), out var a)) 
        {
            Console.WriteLine("Not a number! / Это не число!");
            return;
        }

        Console.WriteLine("Enter the second number / Введите второе число");

        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Not a number! / Это не число!");
            return;
        }

        Console.WriteLine("Enter one of the listed actions / " +
            "Введите одно из перечисленных действий: +, -, *, /, %, &, |, ^.");

        var c = Console.ReadLine();
        var d = a & b;
        var boolVar = true;
        if (c.Length == 0 || c.Length > 1 && boolVar)
        {
            Console.WriteLine("Wrong action! / Неверное действие!");
            return;
        }

        switch (c[0])
        {
        case '+':
            Console.WriteLine("Result of: {0} + {1} = {2}", a, b, a + b);
            Console.WriteLine(Convert.ToString(a, 2));
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(d, 2));
            Console.WriteLine(Convert.ToString(a, 16));
            Console.WriteLine(Convert.ToString(b, 16));
            Console.WriteLine(Convert.ToString(d, 16));
            break;
        case '-':
            Console.WriteLine("Result of: {0} - {1} = {2}", a, b, a - b);
            Console.WriteLine(Convert.ToString(a, 2));
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(d, 2));
            Console.WriteLine(Convert.ToString(a, 16));
            Console.WriteLine(Convert.ToString(b, 16));
            Console.WriteLine(Convert.ToString(d, 16));
            break;
        case '*':
            Console.WriteLine("Result of: {0} * {1} = {2}", a, b, a * b);
            Console.WriteLine(Convert.ToString(a, 2));
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(d, 2));
            Console.WriteLine(Convert.ToString(a, 16));
            Console.WriteLine(Convert.ToString(b, 16));
            Console.WriteLine(Convert.ToString(d, 16));
            break;
        case '/':
            Console.WriteLine("Result of: {0} / {1} = {2}", a, b, a / b);
            Console.WriteLine(Convert.ToString(a, 2));
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(d, 2));
            Console.WriteLine(Convert.ToString(a, 16));
            Console.WriteLine(Convert.ToString(b, 16));
            Console.WriteLine(Convert.ToString(d, 16));
            break;
        case '%':
            Console.WriteLine("Result 0f: {0} % {1} = {2}", a, b, a % b);
            Console.WriteLine(Convert.ToString(a, 2));
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(d, 2));
            Console.WriteLine(Convert.ToString(a, 16));
            Console.WriteLine(Convert.ToString(b, 16));
            Console.WriteLine(Convert.ToString(d, 16));
            break;
        case '&':
            Console.WriteLine("Result 0f: {0} & {1} = {2}", a, b, a & b);
            Console.WriteLine(Convert.ToString(a, 2));
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(d, 2));
            Console.WriteLine(Convert.ToString(a, 16));
            Console.WriteLine(Convert.ToString(b, 16));
            Console.WriteLine(Convert.ToString(d, 16));
            break;
        case '|':
            Console.WriteLine("Result 0f: {0} | {1} = {2}", a, b, a | b);
            Console.WriteLine(Convert.ToString(a, 2));
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(d, 2));
            Console.WriteLine(Convert.ToString(a, 16));
            Console.WriteLine(Convert.ToString(b, 16));
            Console.WriteLine(Convert.ToString(d, 16));
            break;
        case '^':
            Console.WriteLine("Result 0f: {0} ^ {1} = {2}", a, b, a ^ b);
            Console.WriteLine(Convert.ToString(a, 2));
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(d, 2));
            Console.WriteLine(Convert.ToString(a, 16));
            Console.WriteLine(Convert.ToString(b, 16));
            Console.WriteLine(Convert.ToString(d, 16));
            break;
            default:
            Console.WriteLine("Wrong action! / Неверное действие!");
            break;
        }
    }
}
