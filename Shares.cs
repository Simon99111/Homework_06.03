public class Shares
{
    public static int Input(string msg) //Ввод значений с клавиатуры
    {
        Console.Write(msg + " ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static int[,] FillArray(int a, int b) //Заполнение массива случайными числами
    {
        int[,] table = new int[a, b];
        int row = table.GetLength(0);
        int columns = table.GetLength(1);
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                table[i, j] = new Random().Next(1, 10);
            }
        }
        return table;
    }

    public static int[,,] CubeArray() //Заполнение трехмерного массива случайными числами
    {
        int[,,] cube = new int[2, 2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    cube[i, j, k] = new Random().Next(10, 100);
                    
                }
            }
        }
        return cube;
    }

    public static int[,] ArrayKeyBoard(int a, int b) //Ввод матрицы с клавиатуры
    {
        int[,] table = new int[a, b];
        int row = table.GetLength(0);
        int columns = table.GetLength(1);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Введите элемент A[{i},{j}] = ");
                table[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        return table;
    }

    public static void Print(int[,] matrix) //вывод массива
    {
        Console.WriteLine();
        int row = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    public static void PrintCube(int[,,] matrix) //вывод трехмерного массива
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k})   ");
                }
                Console.WriteLine();
            }
        }
    }

    public static void Sort(int[,] array) //сортировка на уменьшение
    {
        int row = array.GetLength(0);
        int column = array.GetLength(1);
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                for (int k = j + 1; k < column; k++)
                {
                    if (array[i, k] > array[i, j])
                    {
                        int a = array[i, k];
                        array[i, k] = array[i, j];
                        array[i, j] = a;
                    }
                }
            }
        }
    }

    public static void SummMinimum(int[,] matrix) //Поиск строки с наименьшей суммой элементов
    {
        int minArrayNumber = 0;
        int row = matrix.GetLength(0);
        int column = matrix.GetLength(1);
        int min = 10000;

        for (int i = 0; i < row; i++)
        {
            int summ = 0;
            for (int j = 0; j < column; j++)
            {
                summ = summ + matrix[i, j];
            }

            if (summ < min)
            {
                minArrayNumber = i;
                min = summ;
            }
        }
        Console.WriteLine($"{minArrayNumber + 1} строка");
    }

    public static int[,] Multi(int[,] array1, int[,] array2) //Умножение матриц
    {
        int row1 = array1.GetLength(0);
        int column1 = array1.GetLength(1);
        int row2 = array2.GetLength(0);
        int column2 = array2.GetLength(1);
        int[,] array3 = new int[row1, column2];

        if (column1 == row2)
        {

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < column2; j++)
                {
                    for (int l = 0; l < column1; l++)
                    {
                        array3[i, j] += array1[i, l] * array2[l, j];
                    }
                }
            }

        }
        else
        {
            Console.WriteLine("Выполнить умножение невозможно!");
        }
        return array3;
    }

}