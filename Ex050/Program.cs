internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите количество строк : ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите количество столбцов : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Random rnd = new Random();
        int [,] mass = new int [m,n];

        for (int i = 0; i < mass.GetLength(0); i++)
        {for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i,j] = rnd.Next(0,10);
            Console.Write(mass[i,j]+"|");
        }
            Console.WriteLine();
        }
        
        Console.WriteLine("Вывод элеиента по индексу");
        Console.Write("Введите индекс строки: ");
        int x = Convert.ToInt32(Console.ReadLine()); 
        Console.Write("Введите индекс столбца: ");
        int y = Convert.ToInt32(Console.ReadLine()); 
        var result = 0;
        for (int i = 0; i < mass.GetLength(0); i++)
        {for (int j = 0; j < mass.GetLength(1); j++)
        {
         result = (mass[x,y]);
        }
            
        }
      Console.WriteLine("Значение элемента: {0}",result);
    }
}