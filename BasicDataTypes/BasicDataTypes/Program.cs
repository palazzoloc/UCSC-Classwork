using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with basic data types *****\n");
            LocalVarDeclarations();
            NewingDataTypes();
            ObjectFunctionality();
            DataTypeFunctionality();
            CharFunctionality();
            ParseFromStrings();
            Arrays();
            ArrayInitialization();
            Console.Read();
        }
        #region Helper functions
        static void LocalVarDeclarations()
        {
            Console.WriteLine("=====> Data Declarations:");
            //Local variables are declared and initialized as so:
            // dataType varName = initialValue;
            int myInt = 0;
            string myString;
            myString = "This is my character data";

            //declare 3 booleans on a single line
            bool b1 = true, b2 = false, b3 = b1;
            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
            Console.WriteLine();
        }
        static void NewingDataTypes()
        {
            Console.WriteLine("=====> Using new to create intrinsic data types: ");
            bool b = new bool();                              //set to false.
            int i = new int();                                //set to 0.
            double d = new double();                          //set to 0.0.
            DateTime dt = new DateTime();                     //set to 1/1/0001 12:01:00 AM
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }
        static void ObjectFunctionality()
        {
            Console.WriteLine("=====> System.Object Functionality:");
            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }
        static void DataTypeFunctionality()
        {
            Console.WriteLine("=====> Data type Functionality:");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
            Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);
            Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine();
        }
        static void CharFunctionality()
        {
            char myChar = 'a';
            Console.WriteLine("=====> char type Functionality");
            Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There!', 5): {0}", char.IsWhiteSpace("Hello There!", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There!', 6): {0}", char.IsWhiteSpace("Hello There!", 6));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsWhiteSpace('?'));
        }

        static void ParseFromStrings()
        {
            Console.WriteLine("=====> Data type parsing: ");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);

            double d = double.Parse("99.88454");
            Console.WriteLine("Value of d: {0}", d);

            int i = int.Parse("8");
            Console.WriteLine("Value of i: {0}", i);

            char c = char.Parse("w");
            Console.WriteLine("Value of c: {0}", c);
            Console.WriteLine();
        }

        static void Arrays()
        {
            Console.WriteLine("=====> Array Iterations");
            //single-dimension array
            int[] numbers = new int[5];
            //multi-dimension array
            string[,] names = new string[5, 4];
            //array of arrays
            byte[][] scores = new byte[5][];
            //create the jagged array
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new byte[i + 3];
            }
            //print each row
            for (int i = 0; i < scores.Length; i++)
            {
                Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
            }
            Console.Read();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=====> Simple Array Creation");
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            foreach (int i in myInts)
                Console.WriteLine(i);
                Console.WriteLine();
        }

        static void ArrayInitialization()
        {
            Console.WriteLine("=====> Array Initialization");

            string[] stringArray = new string[] { "one", "two", "three" };
            bool[] boolArray = {false, true, false};
            int[] intArray = new int[5] { 29, 13, 20, 45, 99 };

            Console.WriteLine("stringArray has {0} elements", stringArray.Length);
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }

        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
        }

        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray"};
            return theStrings;
        }

        static void PassandReceiveArrays()
        {
            Console.WriteLine("=====> Arrays as params and return values");
            int[] ages = { 12, 14, 23, 34 };
            PrintArray(ages);
            string[] strs = GetStringArray();
            foreach (string s in strs)
                Console.WriteLine(s);
            Console.WriteLine();
        }

        #endregion
    }
}
