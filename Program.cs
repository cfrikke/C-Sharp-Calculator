
public class Program{
    internal static double n1;
    internal static char op;
    internal static double n2;
    internal static double result;
    internal static bool continuing = true;

    public static void Main(){
        while(continuing){
        Console.Clear();
        Console.WriteLine("Choose First Number");
        n1 = Calculator.GetFirstNumber();
        Console.WriteLine("Choose Operation");
        op = Calculator.GetOperation();
        Console.WriteLine("Choose Second Number");
        n2 = Calculator.GetSecondNumber();
        Console.Write($"{n1} {op} {n2} = ");
        result = Calculator.Calculate(n1, op, n2);
        Console.WriteLine($"{result}");
        Console.WriteLine("Press enter to continue");
        Console.WriteLine("Press backspace to exit");
        int c = Console.ReadKey().KeyChar;
        switch (c)
        {
          case 08:
          continuing = false;
          break;
          case 13: 
          continuing = true;
          break;
        }
        Thread.Sleep(100);
        Console.Clear();
    }
    }
    }