using System;

namespace try_catch
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Scrieti un numar care val cer");

            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Scrieti ceea ce va cer");
            }
            finally
            {
                System.Console.WriteLine("");
            }
        }
    }
}