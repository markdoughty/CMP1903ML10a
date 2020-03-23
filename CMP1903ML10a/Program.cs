using System;
using System.Collections.Generic;

namespace CMP1903ML10a
{
    class Program
    {
        //a delegate which references methods which 
        //take two integers and return and integer
        public delegate int aDelegate(int value1, int value2);
        static void Main(string[] args)
        {
            List<int> aList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //**Anonymous Methods**
            aDelegate aDel = delegate (int value1, int value2)
            {
                return (value1 + value2);
            };

            ////Call the delegate with the anonymous method
            //Console.WriteLine(aDel(3, 6));

            //**Lambda Expressions 1**
            //List<int> aList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Func<int, int> lambda = x => x * 10;
            //List<int> result = new List<int>();
            //foreach (int y in aList)
            //{
            //    result.Add(lambda.Invoke(y));
            //}
            ////List<int> result = aList.FindAll(x => x % 2 == 0);
            //foreach (int x in result)
            //{
            //    Console.WriteLine(x);
            //}

            //**Lambda Expressions 2**
            //aDelegate aDel = (x, y) => x + y;
            //Console.WriteLine(aDel(3, 4));

            //**Statement Lambda**
            //aDelegate aDel = (x, y) =>
            //{
            //    //A random int between 1 and 10
            //    int random = new Random().Next(1, 11);
            //    random = random + x + y;
            //    return random;
            //};
            //Console.WriteLine(aDel(3, 4));

            ////**Using 'Func<..>'**
            ////Instead of using the custom delegate 'aDelegate'
            //Func<int, int, int> aDel = (x, y) => x + y;
            //Console.WriteLine(aDel(4, 5));

            //Func<int> getRandom = () => new Random().Next(1, 101);
            //Console.WriteLine(getRandom());

            ////**Using 'Action<..>'**
            //Action<string> print = (message) => Console.WriteLine(message);
            //print("Hello world");


        }

        public static bool divisibleByTwo(int x)
        {
            return x % 2 == 0;
        }

        public static int multiplyByTen(int x)
        {
            return x * 10;
        }
    }
}
