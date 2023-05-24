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

        while(true)
        {
            input = menu.AwesomeMenu();

            switch ((OperationsEnum)input)
            {
                case OperationsEnum.sum:
                    //menu.AwesomeMenu();
                    break;

                case OperationsEnum.dif:
                    //menu.AwesomeMenu();
                    break;

                case OperationsEnum.mult:
                    //menu.AwesomeMenu();
                    break;

                case OperationsEnum.div:
                    //menu.AwesomeMenu();
                    break;
            }
        }


    }
}
