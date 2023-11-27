public class Calculator {

public static double GetFirstNumber() {
    bool FirstNumber = true;
    while(FirstNumber){
    try {
    double d = double.Parse(Console.ReadLine());
    FirstNumber = false;
    return d;
    }catch{
        Console.WriteLine("That's not a number!");
        FirstNumber = true;
    }

}
return 0;
}
public static char GetOperation() {
    bool Operation = false;
    while(!Operation){
    char op = char.Parse(Console.ReadLine());
      switch (op) 
      {
        case '+':
          return '+';
        case '-':
          return '-';
        case '*':
          return '*';
        case '/':
          return '/';
        default:
            Console.Clear();
            Console.WriteLine($"That's not an operation!");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(Program.n1);
          break;
      }
}
return ' ';
}
public static double GetSecondNumber() {
    bool FirstNumber = true;
    while(FirstNumber){
    try {
    double d = double.Parse(Console.ReadLine());
    FirstNumber = false;
    return d;
    }catch{
        Console.WriteLine("That's not a number!");
        FirstNumber = true;
    }

}
return 0;
}

public static double Calculate(double n1, char op, double n2) {
        return op switch
        {
            '+' => n1 + n2,
            '-' => n1 - n2,
            '*' => n1 * n2,
            '/' => n1 / n2,
            _ => 0,
        };
    }
}