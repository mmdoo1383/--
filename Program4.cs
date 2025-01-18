using System;

class Program
{
    static void Main(string[] args)
    {
        // مرحله 1: دریافت عدد از کاربر
        Console.Write("enter number: ");
        int number = Convert.ToInt32(Console.ReadLine()); // تبدیل ورودی به عدد صحیح

        // مرحله 2: محاسبه قدر مطلق
        int absoluteValue;
        if (number < 0)
        {
            absoluteValue = -number; // اگر عدد منفی باشد، علامت آن را تغییر می‌دهیم
        }
        else
        {
            absoluteValue = number; // اگر عدد مثبت یا صفر باشد، همان عدد را برمی‌گردانیم
        }

        // مرحله 3: نمایش نتیجه
        Console.WriteLine($"absoluteValue: {absoluteValue}");

        // پایان برنامه
    }
}