namespace DrawTile
{
    internal class Program
    {
        static byte width;
        static byte height;
        static string? fill;

        static void Main()
        {
            Console.WriteLine("Enter the parameters:\n" +
                "width\n" +
                "height\n" +
                "fill\n");
            Read();
            Draw();
        }
        static void Read()
        {
            width = Convert.ToByte(Console.ReadLine());
            height = Convert.ToByte(Console.ReadLine());
            fill = Console.ReadLine();
        }

        static void Draw()
        {
            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height -1)
                {
                    TopAndBottom();
                }
                else
                {
                    SidesAndFill();
                }
                Console.WriteLine();
            }
        }

        static void TopAndBottom()
        {
            for (int j = 0; j < width; j++)
            {
                if (j == 0 || j == width - 1)
                {
                    Console.Write('+');
                }
                else
                {
                    Console.Write('-');
                } 
            }
        }

        static void SidesAndFill()
        {
            for (int k = 0; k < width; k++)
            {
                if (k == 0 || k == width - 1)
                {
                    Console.Write('|');
                }
                else
                {
                    Console.Write(fill);
                }
            }
        }
    }
}