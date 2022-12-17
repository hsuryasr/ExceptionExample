using ConsoleApp1;

public class Test
{

    public static void Main()
    {
        int Number1, Number2, Result;

        try
        {
            
            //Getting a custom exception
            Console.WriteLine("Enter First Number:");
            Number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            Number2 = int.Parse(Console.ReadLine());

            // if number is modulous by 2 and the remainder is greater than 0 then calling exception
            if (Number2 % 2 > 0)
            {
                throw new CustomException();  //Customexception class
            }
        }
        catch (CustomException ce)
        {

            Console.WriteLine($"Message: {ce.Message}");
        }

    }
}

//using System;
//using System.IO;

//public class ExpProg
//{
//    public static void Main(string[] args)
//    {
//        static void GetException()
//        {
//            try
//            {
//                try
//                {
//                    Console.WriteLine("Enter First Number");
//                    int FN = Convert.ToInt32(Console.ReadLine());

//                    Console.WriteLine("Enter Second Number");
//                    int SN = Convert.ToInt32(Console.ReadLine());

//                    int Result = FN / SN;
//                    Console.WriteLine("Result = {0}", Result);
//                }
//                catch (Exception ex)
//                {
//                    string filePath = @"C:\Program Files\log.txt";
//                    if (File.Exists(filePath))
//                    {
//                        StreamWriter sw = new StreamWriter(filePath);
//                        sw.Write(ex.GetType().Name);
//                        sw.WriteLine();
//                        sw.Write(ex.Message);
//                        sw.Close();
//                        Console.WriteLine("There is a Problem,please try later");
//                    }
//                    else
//                    {
//                        throw new FileNotFoundException(filePath + " is not present", ex);
//                    }
//                }
//            }
//            catch (Exception exception)
//            {
//                Console.WriteLine("Current Exception = {0}", exception.GetType().Name);
//                if (exception.InnerException != null)
//                {
//                    Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);
//                }
//            }
//        }
//    }
//}