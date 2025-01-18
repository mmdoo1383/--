//1: .correctUsername و correctPassword: نام کاربری و رمز عبور صحیح در این متغیرها ذخیره شده است.
//2: .Console.ReadLine(): برای دریافت ورودی کاربر از کنسول استفاده می‌شود.
//3: .شرط if:بررسی می‌کند که آیا نام کاربری و رمز عبور وارد شده با مقادیر صحیح مطابقت دارند یا خیر.اگر هر دو درست باشند، پیام "Login successful!" چاپ می‌شود.در غیر این صورت، پیام "Invalid username or password." نمایش داده می‌شود.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Define the correct username and password
        string correctUsername = "admin";
        string correctPassword = "1234";

        // Get the username from the user
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        // Get the password from the user
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        // Check if the username and password are correct
        if (username == correctUsername && password == correctPassword)
        {
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Invalid username or password.");
        }
    }
}
