using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kā tevi sauc?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Sveiks, {userName}");

            // --------------------------------------------------------------------



            Console.WriteLine("Kās ir tavs vecums?");
            string ageText = Console.ReadLine();
            int age = int.Parse(ageText);

            int ageNextYear = age + 1;
            bool isAdult = age >= 18;

            Console.WriteLine($"Nākamgad tev paliks {ageNextYear}, Tu esi pilngadīgs: {isAdult}");

            Console.WriteLine("--------------------------------------------------------------------");

            Console.WriteLine("Ievadi pirmo skailti");
            string UserNumber1 = Console.ReadLine();
            int Number1 = int.Parse(UserNumber1);
            Console.WriteLine("Ievadi otro skailti");
            string UserNumber2 = Console.ReadLine();
            int Number2 = int.Parse(UserNumber2);

            int LargerNumber = Math.Max(Number1, Number2);
            Console.WriteLine($"No abiem skaitliem : {LargerNumber} ir lielakais skaitlis");


            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Ievadi pirmo skailti");
            string UserNumber3 = Console.ReadLine();
            int Number3 = int.Parse(UserNumber1);
            Console.WriteLine("Ievadi otro skailti");

            string UserNumber4 = Console.ReadLine();
            int Number4 = int.Parse(UserNumber2);

            int SmallestNumber = Math.Min(Number3, Number4);
            Console.WriteLine($"No abiem skaitliem: {SmallestNumber} ir mazakais skaitlis");

            Console.WriteLine("---------------------------------------------------------------------------");


            Console.WriteLine("Ievadi pirmo skaitli A matematiskai darbibai B % A = atlikums");
            string UserNumber5 = Console.ReadLine();
            int Number5 = int.Parse(UserNumber5);

            Console.WriteLine("Ievadi otro skaitli B matematiskai darbibai B % A = atlikums");
            string UserNumber6 = Console.ReadLine();
            int Number6 = int.Parse(UserNumber6);


            int Dalijums = Number6 % Number5;
            Console.WriteLine($"{Number6} dalot ar {Number5} atlikums ir : {Dalijums}");




            //string hellotext = "My name is Atvars";
            //int MyNumber = 254;
            //float MyFloat = 13.55f;
            //bool isCool = true;
            //char MyLetter = 'D';

            //Console.WriteLine(hellotext);
            //Console.WriteLine(MyNumber);
            //Console.WriteLine(MyFloat);
            //Console.WriteLine(isCool);
            //Console.WriteLine(MyLetter);

            //string a = new string('A', 10);
            //Console.WriteLine("Heere  \" Whaaat\" \\    \\ \n\r " + a);
            //Console.WriteLine(@"  \  \  \  \r\n ");

            //

            //int number1 = 5;
            //int number2 = 7;
            //int numSum = number1 + number2;
            //Console.WriteLine(numSum);

            //int number3 = 10;
            //int number4 = 3;
            //int numSum2 = number3 / number4;
            //Console.WriteLine(numSum2);

            //int number5 = 10;
            //double number6 = 3;
            //double numSum3 = number5 / number6;
            //Console.WriteLine(numSum3);

            //Console.WriteLine("=============================================================");

            //bool isEqual = 15 == 17;
            //Console.WriteLine(isEqual);

            //bool isNotEqual = !isEqual;
            //Console.WriteLine(isNotEqual);

            //int isSmallerNumber1 = 15;
            //int isSmallerNumber2 = 17;

            //bool isSmaller = isSmallerNumber1 <= isSmallerNumber2;
            //Console.WriteLine(isSmaller);

            //bool iAmTrue = true;
            //bool iAmFalse = false;

            //bool result1 = iAmTrue && iAmFalse;
            //bool result2 = iAmTrue || iAmFalse;

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);

            //Console.WriteLine("=============================================================");

            //int myNumber7 = 15;
            //myNumber7 += 4; // same as myNumber7 + 4

            //Console.WriteLine(myNumber7);

            //int myNumber8 = 15;
            //myNumber8 -= 3; // same as myNumber8 - 3

            //Console.WriteLine(myNumber8);

            //Console.WriteLine("=============================================================");

            //Console.WriteLine("Ievadi savu vārdu");
            //string userAnswer = Console.ReadLine();

            //Console.WriteLine("Hi! "  + userAnswer);

            //Console.WriteLine("Ievadi savu vecumu");
            //string userAgeText = Console.ReadLine();

            //int userAge = int.Parse(userAgeText);
            //int fullAge = userAge + 100;

            //Console.WriteLine("My year " + fullAge);

            //Console.WriteLine("=============================================================");

            //int maxNumber1 = 4;
            //int maxNumber2 = 1;

            //int maxLargest = Math.Max(maxNumber1, maxNumber2);
            //Console.WriteLine(maxLargest);

            //int maxNumber3 = 9;
            //int maxNUmber4 = 5;
            //int maxNUmber5 = 3;

            //int firstMax = Math.Max(maxNUmber4, maxNUmber5);
            //int maxLargest2 = Math.Max(maxNumber3, firstMax);

            //Console.WriteLine(maxLargest2);

            //int withAbs = Math.Abs(-5);
            //Console.WriteLine(withAbs);

            //double numberToRound = 13.458;
            //double rounded = Math.Round(numberToRound, 2);
            //Console.WriteLine(rounded);

            //Console.WriteLine("=============================================================");

            //string myName = "Atvars";
            //string formattedText = string.Format("My name is {0} {1} {2}", myName, "AAA", myName);
            //Console.WriteLine(formattedText);

            //string interpolatedText = $"My name is {myName} AAA {myName}";
            //Console.WriteLine(interpolatedText);


            //var a = 1;
            //var b = a++;

            //var a = 1;
            //var b = ++a

        }
    }
}
