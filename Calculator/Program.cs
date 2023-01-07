namespace Calculator
{
    internal class Program
    {
        static string? op;
        static double num1;
        static double num2;
        static double result;

        static void Main()
        {
            string? prompt;
            Title("Calculator");

            do
            {
                Console.Write(
                    "Input operator\n" +
                    "[a]ddition\n[s]ubtraction\n" +
                    "[m]ultiplication\n[d]ivision\n" +
                    "Input first number\n" +
                    "Input second number\n\n"
                    );
                Read();
                Calculate();
                Output();
                Console.WriteLine("Again?\nyes\t--> enter\nno\t--> n\n");
                prompt = Console.ReadLine();
                Console.Clear();
            } while (prompt != "n");
            Console.WriteLine("\n\tPROGRAM TERMINATED...");
        }

        static void Read()
        {
            try
            {
                op = Console.ReadLine();
                num1 = Convert.ToDouble(Console.ReadLine());
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Wrong input format!");
                return;
            }
        }

        static bool Calculate()
        {
            if (op!.Equals("a") || op!.Equals("s") || op!.Equals("m") || op!.Equals("d"))
            {
                switch (op)
                {
                    case "a":
                        result = num1 + num2;
                        return true;
                    case "s":
                        result = num1 - num2;
                        return true;
                    case "m":
                        result = num1 * num2;
                        return true;
                    case "d":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            return true;
                        }
                        else { return false; }
                    default:
                        return false;
                }
            }
            else
            { return false; }
        }

        static void Output()
        {
            if (Calculate())
            {
                string resultString = "\nResult: " + result.ToString();
                DrawLine(resultString);
            }
            else { return; }
        }

        static void Title(string title)
        {
            Console.WriteLine(title);
            for (int i = 0; i < title.Length; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine("\n");
        }

        static void DrawLine(string text)
        {
            Console.WriteLine(text);
            for (int i = 0; i < text.Length - 1; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine("\n");
        }
    }
}