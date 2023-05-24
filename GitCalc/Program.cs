namespace GitCalc;

public class Program
{
    private static void Main(string[] args)
    {
        string[] operations = new string[4] 
        { 
            "+",
            "-",
            "*",
            "/"
        };

        Menu menu = new Menu(operations);

        int input;

        double result = default;

        while(true)
        {
            input = menu.AwesomeMenu();

            switch ((OperationsEnum)input)
            {
                case OperationsEnum.sum:
                    result = MyCalc.Sum();
                    break;

                case OperationsEnum.dif:
                    result = MyCalc.Dif();
                    break;

                case OperationsEnum.mult:
                    result = MyCalc.Mult();
                    break;

                case OperationsEnum.div:
                    try
                    {
                        result = MyCalc.Div();
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                        Thread.Sleep(2000);
                    }
                    break;
            }
        }


    }
}
