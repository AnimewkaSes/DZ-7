internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите количество строк m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите количество столбцов n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double [,]mass= new double [m,n];
        Random rnd = new Random();

        Console.WriteLine("Массив: ");
        for (int i = 0; i < mass.GetLength(0); i++)
        { for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i,j]= Math.Round(rnd.NextDouble()*10.0,1);
            Console.Write(mass[i,j]+"|");
        }
         Console.WriteLine();
        }
    }
}