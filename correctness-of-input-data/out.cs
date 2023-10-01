using System;


class Program{
    static void Main(){
        Console.WriteLine("Enter digit value:");
        string s = Console.ReadLine();
        if (!double.TryParse(s, out double d)) {
            Console.WriteLine("Incorrect value of input!");
            return;
        }
    }
}