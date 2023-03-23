class ArrayProgram
{
    static void Main(string[] args)
    {

        //1D array
        // Array declaration
        int[] array;
        // Array initialization
        array = new int[10];
        // Array initialization with values
        int[] array1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Array initialization with values (shorter syntax)
        array[0] = 1;
        DisplayArray(array1);

        //2D array
        //Array initialization
        int[,] array2D = new int[3, 3];
        //Array initialization with values
        int[,] array2Dwithvalues = { { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 } };
        Display2DArray(array2Dwithvalues);
        //3D array
        int[,,] array3D = {
                { { 1, 2, 3}, {4, 5, 6} },
                { { 7, 8, 9}, {10, 11, 12} }
            };
        Display3DArray(array3D);

        //Jagged Array of Single dimension
        int[][] jArray = new int[2][];

        jArray[0] = new int[3] { 1, 2, 3 };

        jArray[1] = new int[4] { 4, 5, 6, 7 };

        DisplayJArray(jArray);

        //Jagged Array of Double dimension
        int[][,] jArray2D = new int[2][,];

        jArray2D[0] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        jArray2D[1] = new int[2, 2] { { 7, 8 }, { 9, 10 } };
        DisplayJarray2d(
            jArray2D);

    }
    public static void DisplayArray(int[] array)
    {
        Console.WriteLine("The Values are");
        foreach (int i in array)
        {
            Console.WriteLine(i);
        }
    }
    public static void Display2DArray(int[,] array)
    {
        Console.WriteLine("The 2d array is");
        for (int i = 0; i < array.GetLength(0); i++)

        {
            Console.WriteLine("Row" + i.ToString());
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.WriteLine(array[i, j]);
            }
        }
    }
    public static void Display3DArray(int[,,] array)
    {
        Console.WriteLine("The 3d array is");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.WriteLine("index" + i + " " + j + " " + k + "=" + array[i, j, k]);
                }
            }
        }
    }
    public static void DisplayJArray(int[][] array)
    {
        Console.WriteLine("Jagged Array is");
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
    public static void DisplayJarray2d(int[][,] array)
    {
        Console.WriteLine("Jagged 2D Array is");
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Display2DArray(array[i]);
            }
        }
    }
}


