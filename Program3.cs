using System;

class Program
{
    static void Main(string[] args)
    {
        // مرحله 1: نمایش پیام برای دریافت نام کاربر
        Console.Write("enter your name: ");
        string name = Console.ReadLine(); // دریافت نام کاربر و ذخیره در متغیر name

        // مرحله 2: نمایش پیام برای دریافت شماره تلفن کاربر
        Console.Write("enter your phone number: ");
        string phoneNumber = Console.ReadLine(); // دریافت شماره تلفن کاربر و ذخیره در متغیر phoneNumber

        // مرحله 3: ترکیب نام و شماره تلفن در یک متن
        string output = $"name: {name}, phone number: {phoneNumber}";

        // مرحله 4: نمایش نتیجه به کاربر
        Console.WriteLine(output);

        // مرحله 5: پایان برنامه
    }
}