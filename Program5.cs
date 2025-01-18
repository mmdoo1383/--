using System;

class Program
{
    static void Main(string[] args)
    {
        // مرحله 1: مقدار اولیه متغیر i
        int i = 1;

        // مرحله 2: اجرای حلقه تا زمانی که i <= 20
        while (i <= 20)
        {
            // مرحله 3: بررسی اگر i فرد باشد
            if (i % 2 != 0)
            {
                Console.WriteLine(i); // چاپ عدد فرد
            }

            // مرحله 4: افزایش i
            i++;
        }
    }
}