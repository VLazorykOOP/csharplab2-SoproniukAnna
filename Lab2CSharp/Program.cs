using System.Xml.Linq;

namespace Lab2CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("          Lab 2 CSharp");

            Console.WriteLine("          Task 1 Var 1");
            //Task1_Var1();
            Console.WriteLine("          Task 1 Var 2");
            //Task1_Var2();

            Console.WriteLine("          Task 2");
            //Task2();

            Console.WriteLine("          Task 3");
            Task3();
        }

        static void Task1_Var1()
        {

            int n = 0;
            do
            {
                Console.Write("Input size of array (n): ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            double[] arr = new double[n];
            double dob = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Input [{i}] element of array: ");
                arr[i] = Convert.ToDouble(Console.ReadLine());
                dob *= arr[i];
            }

            Console.WriteLine("Your array:");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + "            ");
            Console.WriteLine();

                if (dob >= 100 && dob <= 999)
                Console.WriteLine($"The multiply of the elements is a three - digit number: {dob}");
            else
                Console.WriteLine($"The multiply of the elements is NOT a three - digit number: {dob}");
            Console.WriteLine();
        }

        static void Task1_Var2()
        {

            int m = 0, n = 0;
            do
            {
                Console.Write("Input size of array (n): ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input size of array (m): ");
                m = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0 && m <= 0);

            double[,] arr = new double[n, m];
            double dob = 1;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Input [{i}],[{j}] element of array: ");
                    arr[i,j] = Convert.ToDouble(Console.ReadLine());
                    dob *= arr[i, j];
                }

            Console.WriteLine("Your array:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(arr[i, j] + "             ");
                Console.WriteLine();
            }
            

            if (dob >= 100 && dob <= 999)
                Console.WriteLine($"The multiply of the elements is a three - digit number: {dob}");
            else
                Console.WriteLine($"The multiply of the elements is NOT a three - digit number: {dob}");
            Console.WriteLine();
        }

        static void Task2()
        {

            int n = 0;
            do
            {
                Console.Write("Input size of array (n): ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            double[] arr = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Input [{i}] element of array: ");
                arr[i] = Convert.ToDouble(Console.ReadLine()); 
            }

            Console.WriteLine("Your array:");
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + "            ");
            Console.WriteLine();

            int k = 0;
            for (int i = 1; i < n; i++)
                if (arr[i] > arr[i - 1])
                    k++;

            Console.WriteLine($"The number of elements whose value is greater than the value of the previous element: {k}");
            Console.WriteLine();
        }

        static void Task3()
        {
            int n = 0;
            do
            {
                Console.Write("Input size of array (n): ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);

            double[,] arr = new double[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Input [{i}],[{j}] element of array: ");
                    arr[i, j] = Convert.ToDouble(Console.ReadLine());
                }

            Console.WriteLine("Your array:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(arr[i, j] + "             ");
                Console.WriteLine();
            }

            double diagonalSum = 0;
            for (int i = 0; i < n; i++)
                diagonalSum += arr[i, n - 1 - i];

            Console.WriteLine($"Sum of elements on the secondary diagonal: {diagonalSum}");
            Console.WriteLine();
        }
    }
}
