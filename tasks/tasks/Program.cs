using System;
class HelloWorld
{
    static void Main()
    {
        #region task 1
        //int[] a = { 1, 2, 3, 4, 5 };
        //int hasil = 1;
        //for (int i = 0; i < a.Length; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        hasil *= a[i];
        //    }
        //}
        //Console.WriteLine($"tek indeksde  duran ededlerin hasili {hasil} dir ");

        #endregion

        #region task 2

        //string[] a = { "salam" };
        //for (int i = 1; i <= a[0].Length; i++)
        //{
        //    Console.Write(a[0][^i]);

        //}
        #endregion

        #region task 3
        int[] a = { 1, 2, 3, 4, 5 ,6 };
        double count = 0;
        double sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
            count++;
        }
        Console.WriteLine(sum/count);


        #endregion
    }
}