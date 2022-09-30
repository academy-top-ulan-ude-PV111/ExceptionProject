namespace ExceptionProject
{
    internal class Program
    {
        static void Run()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            try
            {
                int a;
                a = Int32.Parse(Console.ReadLine());
                Console.WriteLine(10 / a);
                Console.WriteLine(array[a]);

            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message + ex.Source);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (Exception ex)
            {
                Console.WriteLine("Run catch");
                Console.WriteLine("Message " + ex.Message);
                Console.WriteLine("Source " + ex.Source);
                Console.WriteLine("TargetSite " + ex.TargetSite);
                Console.WriteLine("StackTrace " + ex.StackTrace);
                throw;
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
        }
        static void Main(string[] args)
        {
            //try
            //{
            //    Run();
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("\nMain catch");
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.Source);
            //    Console.WriteLine(ex.TargetSite);
            //    Console.WriteLine(ex.StackTrace);
            //}


            //Console.WriteLine("Program work");

            try
            {
                Fraction fraction = new Fraction(10, 20);

                fraction.Denominator = 0;
            }
            catch(FractionException ex)
            {
                if (ex.Code == 100)
                    Console.WriteLine(ex.Message + " error in conctructor!");
                else if (ex.Code == 200)
                    Console.WriteLine(ex.Message + " error in property set!");
                else
                    Console.WriteLine(ex.Message);
            }

        }
    }
}