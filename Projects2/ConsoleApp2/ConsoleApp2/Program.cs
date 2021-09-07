using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string hellotext = "My name is Atvars";
            int MyNumber = 254;
            float MyFloat = 13.55f;
            bool isCool = true;
            char MyLetter = 'D';

            Console.WriteLine(hellotext);
            Console.WriteLine(MyNumber);
            Console.WriteLine(MyFloat);
            Console.WriteLine(isCool);
            Console.WriteLine(MyLetter);

            string a = new string('A', 10);
            Console.WriteLine("Heere  \" Whaaat\" \\    \\ \n\r " + a);
            Console.WriteLine(@"  \  \  \  \r\n ");

            Console.WriteLine("=============================================================");

            int number1 = 5;
            int number2 = 7;
            int numSum = number1 + number2;
            Console.WriteLine(numSum);

            int number3 = 10;
            int number4 = 3;
            int numSum2 = number3 / number4;
            Console.WriteLine(numSum2);

            int number5 = 10;
            double number6 = 3;
            double numSum3 = number5 / number6;
            Console.WriteLine(numSum3);

            Console.WriteLine("=============================================================");

            bool isEqual = 15 == 17;
            Console.WriteLine(isEqual);

            bool isNotEqual = !isEqual;
            Console.WriteLine(isNotEqual);

            int isSmallerNumber1 = 15;
            int isSmallerNumber2 = 17;

            bool isSmaller = isSmallerNumber1 <= isSmallerNumber2;
            Console.WriteLine(isSmaller);

            bool iAmTrue = true;
            bool iAmFalse = false;

            bool result1 = iAmTrue && iAmFalse;
            bool result2 = iAmTrue || iAmFalse;

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            Console.WriteLine("=============================================================");

            int myNumber7 = 15;
            myNumber7 += 4; // same as myNumber7 + 4

            Console.WriteLine(myNumber7);

            int myNumber8 = 15;
            myNumber8 -= 3; // same as myNumber8 - 3

            Console.WriteLine(myNumber8);

            Console.WriteLine("=============================================================");

            //Console.WriteLine("Ievadi savu vārdu");
            //string userAnswer = Console.ReadLine();

            //Console.WriteLine("Hi! "  + userAnswer);

            //Console.WriteLine("Ievadi savu vecumu");
            //string userAgeText = Console.ReadLine();

            //int userAge = int.Parse(userAgeText);
            //int fullAge = userAge + 100;

            //Console.WriteLine("My year " + fullAge);

            //Console.WriteLine("=============================================================");

            int maxNumber1 = 4;
            int maxNumber2 = 1;

            int maxLargest = Math.Max(maxNumber1, maxNumber2);
            Console.WriteLine(maxLargest);

            int maxNumber3 = 9;
            int maxNUmber4 = 5;
            int maxNUmber5 = 3;

            int firstMax = Math.Max(maxNUmber4, maxNUmber5);
            int maxLargest2 = Math.Max(maxNumber3, firstMax);

            Console.WriteLine(maxLargest2);

            int withAbs = Math.Abs(-5);
            Console.WriteLine(withAbs);

            double numberToRound = 13.458;
            double rounded = Math.Round(numberToRound, 2);
            Console.WriteLine(rounded);

            Console.WriteLine("=============================================================");

            string myName = "Atvars";
            string formattedText = string.Format("My name is {0} {1} {2}", myName, "AAA", myName);
            Console.WriteLine(formattedText);

            string interpolatedText = $"My name is {myName} AAA {myName}";
            Console.WriteLine(interpolatedText);


            //var a = 1;
            //var b = a++;

            //var a = 1;
            //var b = ++a

        }
    }
}
