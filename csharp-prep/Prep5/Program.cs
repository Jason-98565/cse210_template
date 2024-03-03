using System;

class Program
{
    static void Main(string[] args)
    {
        {
            display_message();
            string name = get_user_name();
            int fav_number = get_fav_number();

            int squared_number = square_number(fav_number);

            display_results(name,squared_number);
        }
        static void display_message()
        {
            Console.WriteLine("Welcome to the Program");
        }
        static string get_user_name()
        {
            Console.Write("Please Enter your name");
            string name = Console.ReadLine();
            return name;
        }
        static int get_fav_number()
        {
            Console.Write("Please enter your favorite number");
            string fav_number_str = Console.ReadLine();
            int fav_number = int.Parse(fav_number_str);
            return fav_number;
        }
        static int square_number(int fav_number)
        {
            int squared_number = fav_number*fav_number;
            return squared_number;
        }
        static void display_results(string name, int squared_number)
        {
            Console.WriteLine($"{name}, the square of your number is {squared_number}");
        }
    }
}