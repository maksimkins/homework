using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitCalc;

public class Menu
{
    public readonly string[] strings;

    public Menu(string[] strings)
    {
        this.strings = strings;
    }

    public void ShowStrings()
    {
        for (int i = 0; i < this.strings.Length; i++)
        {
            Console.WriteLine($"\n{i + 1}. {this.strings[i]}");
        }
    }

    public int AwesomeMenu()
    {
        bool GotInput;
        int whatToDo = -1;

        do
        {
            Console.Clear();
            this.ShowStrings();
            GotInput = this.GetInput(ref whatToDo);

        } while (!GotInput);

        return whatToDo;
    }

    private bool GetInput(ref int input)
    {

        string? strInput;

        Console.Write("\n\nInput your choise: ");
        strInput = Console.ReadLine();

        if (string.IsNullOrEmpty(strInput) || int.TryParse(strInput, out input) == false || int.Parse(strInput) < 1 || int.Parse(strInput) > this.strings.Length)
        {
            return false;
        }

        input = int.Parse(strInput) - 1;

        return true;
    }

}
