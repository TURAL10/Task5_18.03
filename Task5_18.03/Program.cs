using System.Diagnostics.Metrics;
using System.Drawing;

namespace Task5_18._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            //int a = 0;
            //for (int i = 1; i < 1001; i++)
            //{
            //    a += i;
            //}

            //if (a % 7 == 0)
            //{
            //    Console.WriteLine("Ededlerin cemi 7ye bolunur");
            //}
            //else
            //{
            //    Console.WriteLine("Ededlerin cemi 7ye bolunmur");
            //}
            #endregion

            #region Task 2

            //for (int i = 1; i < 1001; i++)
            //{
            //    if (i % 7 == 0 && i % 8 == 0) // i % 56 == 0
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Task 3

            //int temp_1, qaliq, result;  // ancaq 3e bolunenleride tapsaq cavabi almis olariq.
            //for (int i = 1; i < 1001; i++)
            //{
            //    result = 0;
            //    temp_1 = i;

            //    while (temp_1 > 0)
            //    {
            //        qaliq = temp_1 % 10;
            //        temp_1 /= 10;
            //        result += qaliq;
            //    }
            //    if (result % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Task 4

            //int temp_1, qaliq, result; 
            //for (int i = 1; i < 1001; i++)
            //{
            //    result = 0;
            //    temp_1 = i;

            //    while (temp_1 > 0)
            //    {
            //        qaliq = temp_1 % 10;
            //        temp_1 /= 10;
            //        result += qaliq;
            //    }
            //    if (result % 3 == 0 && i % 10 != 3) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Task 5

            //int temp_1, qaliq, result; 
            //for (int i = 1; i < 1001; i++)
            //{
            //    result = 0;
            //    temp_1 = i;

            //    while (temp_1 > 0)
            //    {
            //        qaliq = temp_1 % 10;
            //        temp_1 /= 10;
            //        result += qaliq;
            //    }
            //    if (result % 5 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Task 6

            //int temp_1, qaliq, result, temp_2;
            //for (int i = 1; i < 1001; i++)
            //{
            //    result = 0;
            //    temp_1 = i;
            //    temp_2 = i * 10;
            //    while (temp_1 > 0)
            //    {
            //        qaliq = temp_1 % 10;
            //        temp_1 /= 10;
            //        result += qaliq;
            //        temp_2 /= 10;
            //    }
            //    if (result % 2 == 1 && i % 2 == 0 && temp_2 % 2 ==1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Task 7
            //int temp_1;
            //int temp_2;

            //for (int i = 1; i < 1001; i++)
            //{
            //    temp_1 = i / 10;
            //    temp_2 = i / 100;

            //    if (i % 10 != 3 && temp_1 % 10 != 3 && temp_2 % 10 != 3)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Task 8

            //int a, b, c;
            //for (int i = 1000; i > 0; i--)
            //{
            //    a = i / 100;
            //    b = i / 10 % 10;
            //    c = i % 10;
            //    if (a != 3 && b != 3 && c != 3 && a + b + c == 3) 
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}

            #endregion

            #region Task 9

            //int a, b, c;
            //int count = 0;
            //for (int i = 0; i < 1001; i++)
            //{
            //    a = i / 100;
            //    b = i / 10 % 10;
            //    c = i % 10;
            //    if (i % 11 == 0 && a + b + c > 11)
            //    {
            //        count++;
            //        if (count == 11)
            //        {
            //            Console.WriteLine(i);
            //            break;
            //        }
            //    }
            //}

            #endregion

            #region Task 10

            //int a, b, c;
            //for (int i = 1000; i > 0; i--)
            //{
            //    a = i / 100;
            //    b = i / 10 % 10;
            //    c = i % 10;
            //    if (a + b + c == 6 && i % 2 == 0) 
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}

            #endregion

            #region Task 11

            //int temp, a, b, c;
            //for (int i = 0; i < 1001; i++)
            //{
            //    int newNumber = 0;
            //    temp = i;

            //    while (temp > 0)
            //    {
            //        int qaliq = temp % 10;
            //        newNumber = newNumber * 10 + qaliq;
            //        temp /= 10;
            //    }
            //    a = i / 100;
            //    b = i / 10 % 10;
            //    c = i % 10;
            //    if (newNumber == i && a != 3 && b != 3 && c != 3 && a + b + c > 10 && i > 100)  
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion

            #region Task 12
            //int number1, number2, qaliq;

            //for (int i = 10; i < 100000; i++)
            //{
            //    qaliq = i % 10;
            //    number1 = i / 10;

            //    while (number1 > 0 && number1 % 10 == qaliq)
            //    {
            //        number1 /= 10;
            //    }

            //    if (number1 == 0)
            //    {
            //        number2 = i;
            //        if (number2 % 10 == 5)
            //        {
            //            continue;
            //        }
            //        int sum = 0;

            //        while (number2 > 0)
            //        {
            //            sum += number2 % 10;
            //            number2 /= 10;
            //        }
            //        if (sum > 5)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            #endregion

            #region Task 13

            //int temp, newNumber;
            //int number1, qaliq, qaliq2, count;
            //for (int i = 100; i < 100001; i++)
            //{
            //    count = 0;
            //    qaliq = i % 10;
            //    number1 = i / 10;
            //    if(qaliq % 2 == 1)
            //    {
            //        while (number1 > 0 && number1 % 2 == 1)
            //        {
            //            if (number1 % 10 == 5)
            //            {
            //                count = 1;
            //            }
            //            number1 /= 10;
            //        }
            //    }
            //    if (number1 == 0 && count == 1)
            //    {
            //        newNumber = 0;
            //        temp = i;

            //        while (temp > 0)
            //        {
            //            qaliq2 = temp % 10;
            //            newNumber = newNumber * 10 + qaliq2;
            //            temp /= 10;
            //        }
            //        if (newNumber == i) 
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}

            #endregion

            #region Task 14

            //int number1, qaliq, count1, count2, sum, number2;
            //for (int i = 100; i < 100001; i++)
            //{
            //    count1 = 0;
            //    count2 = 0;
            //    qaliq = i % 10;
            //    number1 = i;

            //    while (number1 > 0) 
            //        {
            //        if (number1 % 10 == 6)
            //        { 
            //            break;
            //        }
            //        if (number1 % 100 == 11) 
            //        {
            //            count2 = 2;
            //        }
            //        if (number1 % 10 == 5) 
            //        {
            //            count1++;
            //        }
            //        number1 /= 10;
            //    }


            //    if (count2 == 2 && count1 == 2 )
            //    {
            //        number2 = i;
            //        sum = 0;
            //        while (number2 > 0)
            //        {
            //            sum += number2 % 10;
            //            number2 /= 10;
            //        }
            //        if (sum > 7 && sum < 15)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //}
            #endregion

            #region Task 15

            //int number1, number2, count1, count2;
            //int sum, num_qaliq;
            //for (int i = 3; i < 10000; i++)
            //{
            //    count1 = 0;
            //    num_qaliq = 0;

            //    number1 = i;

            //    while (number1 > 0)
            //    {
            //        num_qaliq = number1 % 10;
            //        if (num_qaliq % 2 == 1)
            //        {
            //            if (number1 % 10 != 3)
            //            {
            //                break;
            //            }
            //        }
            //        if (number1 % 10 == 0)
            //        {
            //            break;
            //        }
            //        number1 /= 10;

            //        if (number1 == 0)
            //        {
            //            for (int j = 2; j < i; j++)
            //            {
            //                if (i % j == 0)
            //                {
            //                    count1 = 1;
            //                }
            //            }
            //        }
            //    }

            //    number2 = i;
            //    sum = 0;

            //    while (number2 > 0)
            //    {
            //        sum += number2 % 10;
            //        number2 /= 10;
            //    }

            //    count2 = 0;
            //    while (sum > 0)
            //    {
            //        if (sum % 10 == 2)
            //        {
            //            count2 = 2;
            //        }

            //        sum /= 10;
            //    }

            //    if (number1 == 0 && count1 == 0 && count2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            #endregion
        }
    }
}