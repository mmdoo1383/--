//برنامه‌ای که یک آرایه از مقادیر داشته باشد و هر بار با زدن یک کلید، مقدار متغیر به مقدار بعدی در آرایه تغییر کند. وقتی به انتهای آرایه رسید، دوباره به اولین مقدار برگردد.
using System;

class Program
{
    static void Main(string[] args)
    {
        // Define an array of values
        //این خط یک آرایه از رشته‌ها (string[]) تعریف می‌کند که مقادیر موردنظر برای چرخش در آن قرار دارند.
       // در اینجا، آرایه شامل 4 مقدار است: "Value 1", "Value 2", "Value 3", "Value 4".
        string[] values = { "Value 1", "Value 2", "Value 3", "Value 4" };

        //یک متغیر به نام currentIndex تعریف شده که اندیس فعلی آرایه را نگهداری می‌کند.
        //مقدار اولیه آن 0 است که به معنای شروع از اولین مقدار آرایه است.
        int currentIndex = 0; // Current index


        // یک حلقه while بی‌نهایت که برنامه را دائماً اجرا می‌کند تا زمانی که کاربر آن را متوقف کند.
        while (true)
        {
            //مقدار فعلی آرایه (بر اساس currentIndex) در کنسول چاپ می‌شود.
           //از $ برای قالب‌بندی رشته استفاده شده تا مقدار متغیر values[currentIndex] به طور مستقیم در متن قرار گیرد.
                        Console.WriteLine($"Current Value: {values[currentIndex]}");
            Console.WriteLine("Press Enter to go to the next value, or type Q to quit.");

            string input = Console.ReadLine();

            if (input?.ToLower() == "q") // Exit the program
            {
                Console.WriteLine("Exiting the program.");
                break;
            }

            // Move to the next value in a circular way
            currentIndex = (currentIndex + 1) % values.Length;
        }
    }
}