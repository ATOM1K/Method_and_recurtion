using System;

internal class Program
{
    /*
     * C помощью рекурсии
     * Реализовать вывод массива
     * найти сумму элементов массива
     * найти сумму цифр числа с помощью рекурсии
     */
    public static void ShowArray(int[] myArray, int i)
    {
        if (i < myArray.Length)
        {
            Console.Write(myArray[i] + "; ");
            i++;
            ShowArray(myArray, i);
        }

    }
    public static void LoudArray(int[] firstArray, Random random, int i)
    {

        if (i < firstArray.Length)
        {
            int arrElem = random.Next(1000);
            firstArray[i] = arrElem;
            i++;
            LoudArray(firstArray, random, i);
        }

    }

    public static void SumArrayElement(int[] firstArray, int i2, int result)
    {
        
        if (i2 < firstArray.Length)
        {
            result = firstArray[i2] + result;
            i2++;
            SumArrayElement(firstArray, i2, result);
        }
        else
        Console.WriteLine("Elements sum of array: " + result);
    }
    public static void DigitSum(int digit, int i3, int numSum)
    {

        if (digit >0)
        {
            numSum = numSum + (digit % 10);
            digit = digit / 10;
            DigitSum(digit, i3, numSum);
        }
        else 
        Console.WriteLine(numSum);

    }
    private static void Main(string[] args)
    {
        Console.WriteLine("1.Implement return of every element of array with recurtion!");

        Random random = new Random();
        int arrScale = random.Next(2,10);
        int[] firstArray = new int[arrScale];
        int i = 0; //counter of first task
        LoudArray(firstArray, random, i);
        ShowArray(firstArray, i);
        Console.WriteLine("");

        Console.WriteLine("2.Show sum of all element of array with recurtion!");
        int i2 = 0; //counter of third task
        int result = 0; //result of second task
        SumArrayElement(firstArray, i2, result);

        Console.WriteLine("");
        Console.WriteLine("3.Find sum of digit of number with recurtion!");
        Console.Write("Array have " + arrScale + " simbols. Enter position what you need to sum: ");
        int i3 = int.Parse(Console.ReadLine());
        int numSum = 0;
        int digit = firstArray[i3 - 1];
        DigitSum(digit, i3, numSum);

    }
}