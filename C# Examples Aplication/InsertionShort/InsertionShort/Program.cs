//Insertion Short Algoritmasi

public class myClass
{
    public static void InsertionShort(int [] array)
    {
        for (int i = 2; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;
            while (j>0 && array[j]>key)
            {
                array[j+1]=array[j];
                j = j - 1;
             
            }
            array[j + 1] = key;
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

    }
    public static void BubbleShort(int[]array)
    {
        int temp;
        for (int i = 1; i <= array.Length; i++)
        {
            for (int j = array.Length; j > i+1; j--)
            {
                if (array[j]<array[j-1])
                {
                    temp = array[j-1];
                    array[j-1] = array[j];  
                    array[j] = temp;

                }
            }
        }
        
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
    public static void Main()
    {
        int[] array = new int[] { 45,4,1, 2, 3, 9, 6, 6,7, 8, 10 };
        myClass.BubbleShort(array);
    }

}
