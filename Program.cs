using System;
using System.Threading.Tasks;

namespace invalid_program
{
    class Program
    {
        static void Main(string[] args)
        {
            DoStuff().Wait();
            Console.WriteLine("If you see this then everything is OK!");
        }

        static async Task DoStuff()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                await Task.Delay(100);
            }
            finally
            {
                //If finally block is removed bug will no longer appear
            }
        }
    }
}
