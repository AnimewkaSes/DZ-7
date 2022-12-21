internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.Write("Введите размер двумерного массива : ");
        int n = Int32.Parse(Console.ReadLine());
        Random rnd = new Random();
        int [,] mass = new int [n,n];

        for (int i = 0; i < n; i++)
        {for (int j = 0; j < n; j++)
        {
            mass[i,j] = rnd.Next(0,10);
            Console.Write(mass[i,j]+" ");
        }
            Console.WriteLine();
        }
        
        for (int i = 0; i < n; i++)
        {
            double result=0;
            double ost = 0;
            for (int j = 0; j <n; j++)
            {
                result += mass[j,i];
                ost = Math.Round(result/n,1);
                 
            }
           
           Console.WriteLine("Сумма элементов в столбце {0} равно: {1}. Среднее арифметическое {2} ",i,result,ost);
        }
        

        
    }
}