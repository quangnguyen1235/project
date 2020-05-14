using System;
using System.Security.Cryptography;

namespace TryCatchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 0;
            //int c = a / b;
            //Console.WriteLine(c);
            //try
            //{
            //    Console.Write("a = ");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.Write("b = ");
            //    int b = int.Parse(Console.ReadLine());
            //    int c = a / b;
            //    Console.WriteLine(c);
            //}
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine($"{e.GetType().Name}: {e.Message} At time: {DateTime.Now.ToLocalTime()}");
            //}
            //catch(OverflowException e)
            //{
            //    Console.WriteLine($"{e.GetType().Name}: {e.Message} At time: {DateTime.Now.ToLocalTime()}");
            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine($"{e.GetType().Name}: {e.Message} At time: {DateTime.Now.ToLocalTime()}");
            //}
            //catch (CustomException e)
            //{
            //    Console.WriteLine($"{e.GetType().Name}: {e.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Go to Finally");
            //}
            //try
            //{
            //    int a = 6;
            //    if ( a != 5)
            //    {
            //        throw new CustomException(a);
            //    }
            //}
            //catch (CustomException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{

            //}
            A a = new A();
            a.AM();
        }
    }
    class CustomException : Exception
    {
        public CustomException(): base()
        {
        }
        public CustomException(int value) : base($"{value} is not a prime")
        {

        }
    }
    class A : B
    {
        public void AM()
        {
            BM();
        }
    }
    class B : C
    {
        public void BM()
        {
            CM();
        }
    }
    class C
    {
        public Response<int> CM()
        {
            var result = new Response<int>()
            {
                ResponeCode = ResCode.E400,
                Message = "System Error",
                Payload = new int()
            };
            try
            {
                int a = 8;
                int b = 2;
                int c = a / b;
                result.ResponeCode = ResCode.E200;
                result.Payload = c;
                result.Message = "succes";
                Console.WriteLine($"ResCode: {result.ResponeCode}\t {result.Message}");
                return result;
            }
            catch(Exception e)
            {
                //throw e;
                Console.WriteLine($"ResCode: {result.ResponeCode}\t {result.Message}");
                return result;
            }
        }
    }
    public class Response<T>
    {
        public ResCode ResponeCode { get; set; }
        public T Payload;
        public string Message;
    }
    public enum ResCode
    {
        E400 = 400,
        E200 = 200,
    }
}
