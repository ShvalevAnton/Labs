using System;

namespace Working_with_array
{
    internal class Program
    {        
        //---------------------CalculateAverage-----------------------
        static public double CalculateAverage(int [] arr)
        {              
            // Проверка на пустой массив
            if (arr.Length == 0) return 0;            
            int sum = 0;
            // Вычисление суммы элементов
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;           
        }

        //-------------------PosNegSumArr-------------------------
        static public (int, int) PosNegSumArr(int[] arr)
        {
            // Проверка на пустой массив
            if (arr.Length == 0) return (0,0);

            int posSum = 0;
            int negSum = 0;            
            // Вычисление отрицательной и положительной суммы элементов
            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[k] > 0)
                {
                    posSum += arr[k];
                }
                else if (arr[k] < 0)
                {
                    negSum += arr[k];
                }
            }
            return (negSum, posSum);
            
}

        //------------------SumArr--------------------------
        static public int SumArr(int[] arr)
        {
           
            // Проверка на пустой массив
            if (arr.Length == 0) return 0;

            int Sum = 0;
            // Вычисление отрицательной и положительной суммы элементов
            for (int k = 0; k < arr.Length; k++)
            {
                Sum = checked(Sum + arr[k]);
            }
            return Sum;
            
        }

        //------------------InputArr--------------------------
        static public void InputArr(int[] arr, ref bool flag)
        {
            for (int k = 0; k < arr.GetLength(0); k++)
            {
                Console.Write("Enter value for [{0}] : ", k );
                string s = Console.ReadLine();
                flag = int.TryParse(s, out arr[k]);
                if (!flag)
                {
                    Console.WriteLine("Введенны не верные данные!");
                    return;
                }
            }
            Console.WriteLine();
        }

        //-------------------SumEvenOrOddIndex-------------------------
        static public (int, int) SumEvenOrOddIndex(int[] arr)
        {
            // Проверка на пустой массив
            if (arr.Length == 0) return (0, 0);

            int oddSum = 0;// Сумма нечетных элементов            
            int evenSum = 0; // Сумма четных элементов

            // Вычисление четной и нечетной суммы элементов
            for (int k = 0; k < arr.Length; k++)
            {
                if (k % 2 == 0)
                {
                    evenSum += arr[k];
                }
                else
                {
                    oddSum += arr[k];
                }
            }
            return (oddSum, evenSum);
        }

        //-------------------FindMinAndMax-------------------------
        static public (int, int) FindMinAndMax(int[] arr)
        {
            int maxValue = arr[0];
            int maxIndex = 0;
            int minValue = arr[0];
            int minIndex = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                    maxIndex = i;
                }
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                    minIndex = i;
                }
            }
            return (minIndex, maxIndex);
        }

        //-------------------ProductBetweenMaxAndMin-------------------------
        static public int ProductBetweenMaxAndMin(int[] arr)
        {
            (int minIndex, int maxIndex) var = FindMinAndMax(arr);           

            // Определяем границы между максимальным и минимальным элементами
            int startIndex = Math.Min(var.minIndex, var.maxIndex)+1;
            int endIndex = Math.Max(var.minIndex, var.maxIndex);

            // Проверка на наличие элементов между максимальным и минимальным
            if (startIndex >= endIndex)
                return 0; // Нет элементов между

            int product = 1;
            for (int i = startIndex; i < endIndex; i++)
            {
                product *= arr[i];
            }
            return product;
        }
        static void Main(string[] args)
        {
            int[] myArr = new int[4];
            
            // Метод ввода массива
            bool flag = true;
            InputArr(myArr, ref flag);
            if (!flag)
                return;
            try
            {
                int tmp = SumArr(myArr);
                // Метод определение суммы всех элементов массива
                Console.WriteLine($"Cумма всех элементов массива = {tmp}");
                Console.WriteLine();

                // Метод среднего значения массива
                double dTmp = CalculateAverage(myArr);
                Console.WriteLine($"Cреднее значение массива = {dTmp}");
                Console.WriteLine();

                // Метод расчета суммы отрицательных и положительных элементов.
                (int, int) Temp = PosNegSumArr(myArr);
                Console.WriteLine($"Cуммы отрицательных элементов = {Temp.Item1} и положительных элементов = {Temp.Item2}");
                Console.WriteLine();

                // Метод расчета суммы элементов с нечетными и четными индексами
                Temp = SumEvenOrOddIndex(myArr);
                Console.WriteLine($"Cуммы элементов с нечетным индексом = {Temp.Item1} и четными индексом = {Temp.Item2}");
                Console.WriteLine();

                // Метод поиска максимального или минимального элементы массива и вывести их индексы            
                Temp = (FindMinAndMax(myArr));
                Console.WriteLine($"Индекс минимального элемента в массиве = {Temp.Item1} и максимального элемента в массиве = {Temp.Item2}");
                Console.WriteLine();
                // Метод рассчёта произведения элементов массива, расположенных между максимальным и минимальным элементами           
                tmp = ProductBetweenMaxAndMin(myArr);
                Console.WriteLine($"Произведение элементов массива, расположенных между максимальным и минимальным элементами = {tmp}");
                Console.WriteLine();            
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);               
            }
}
    }
}
// проверка на ввод массива + и на переполнение +
// среднее значение массива в double + и все элементы массива в модуль -
// Cуммы отрицательных элементов = 0 
// Cуммы элементов с нечетным индексом = 2+