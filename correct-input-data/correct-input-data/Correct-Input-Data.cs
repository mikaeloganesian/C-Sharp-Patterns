using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correct_Input_Data
{
    class No_Repeat
    {
        public static void No_Repeat_Int()
        {
            Console.WriteLine("Enter input data (Type: Int):");
            string? s = Console.ReadLine();
            if (!int.TryParse(s, out int d))
            {
                Console.WriteLine("Incorrect data value!");
                return;
            }
        }

        public static void No_Repeat_Double()
        {
            Console.WriteLine("Enter input data (Type: Double):");
            string? s = Console.ReadLine();
            if (!double.TryParse(s, out double d))
            {
                Console.WriteLine("Incorrect data value!");
                return;
            }
        }

       public static void No_Repeat_String() {
            Console.WriteLine("Enter input data (Type: String):");
            string? s = Console.ReadLine();
            if (s == null || s.Replace(" ", "").Length == 0 || string.IsNullOrEmpty(s))
            {
                Console.WriteLine("Incorrect data value!");
                return;
            }
        }
    }

    class Repeat
    {
        public static void Repeat_Int()
        {
            Console.WriteLine("Enter input data (Type: Int):");
            string? s = Console.ReadLine();
            int i;
            do
            {
                if (s == null || s.Length == 0 || !int.TryParse(s, out i))
                {
                    Console.WriteLine("Incorrect data value!");
                    s = Console.ReadLine();
                }
            } while (!int.TryParse(s, out i));
        }

        public static void Repeat_Double()
        {
            Console.WriteLine("Enter input data (Type: Double):");
            string? s = Console.ReadLine().Replace(".", ",");
            double i;
            do
            {
                if (s == null || s.Length == 0 || !double.TryParse(s, out i))
                {
                    Console.WriteLine("Incorrect data value!");
                    s = Console.ReadLine().Replace(".", ",");
                }
            } while (!double.TryParse(s, out i));
        }
    
        public static void Repeat_String()
        {
            Console.WriteLine("Enter input data (Type: String):");
            string? s = Console.ReadLine();
            do
            {
                if (s == null || s.Replace(" ", "").Length == 0 || string.IsNullOrEmpty(s))
                {
                    Console.WriteLine("Incorrect data value!");
                    s = Console.ReadLine();
                }
            } while (s == null || s.Replace(" ", "").Length == 0 || string.IsNullOrEmpty(s));
        }
    }
}
