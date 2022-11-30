using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- Strings and Integers ----- //
            string strInt = "45";
            int int32 = Int32.Parse(strInt);
            Console.WriteLine(int32); // output: 45

            int int16 = Int16.Parse(strInt);
            Console.WriteLine(int16); // output: 45

            string invalidString = "Hello";
            //int invalidResult = Int32.Parse(invalidString);

            int tryParseResult = 0;
            if (Int32.TryParse(invalidString, out tryParseResult))
            {
                Console.WriteLine(tryParseResult);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

            string intString = 45.ToString();
            Console.WriteLine(intString); //output: 45


            // ----- Strings and Doubles ----- //
            string strDouble = "90.5";
            double d = Double.Parse(strDouble);
            Console.WriteLine(d); //output: 90.5

            string invalidStringDouble = "Hello";
            int tryParseDouble = 0;
            if (Int32.TryParse(invalidString, out tryParseDouble))
            {
                Console.WriteLine(tryParseDouble);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

            double dDouble = 90.5;
            string dString = dDouble.ToString();
            Console.WriteLine(dString); //output: 90.5


            // ----- Doubles and Integers ----- //
            double dValue = 12.34;
            int iValue = (int)dValue;
            Console.WriteLine(iValue); //output: 12

            dValue = (double)iValue;
            Console.WriteLine(dValue); //output: 12


            // ----- Strings and DateTime ----- //
            DateTime newDateTime = DateTime.Parse("01/01/2018 00:00:00");
            Console.WriteLine(newDateTime); //output: 01/01/2018 00:00:00

            string invalidDateTimeString = "Hello";
            DateTime tryParseDate = new DateTime();
            if (DateTime.TryParse(invalidString, out tryParseDate))
            {
                Console.WriteLine(tryParseDate);
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

            DateTime dt = new DateTime(2018, 1, 1);
            string dtString = dt.ToString();
            Console.WriteLine(dtString); //output: 01/01/2018 00:00:00


            // ----- Strings and Boolean ----- //
            string stringBool = "True";
            bool b = bool.Parse(stringBool);
            //or
            b = Convert.ToBoolean(stringBool);
            Console.WriteLine(b); //output: true

            string strTrue = true.ToString();
            string strFalse = false.ToString();


            // ----- Integers and Boolean ----- //
            int falseBit = 0;
            int trueBit = 1;
            Console.WriteLine(Convert.ToBoolean(falseBit)); //output: false
            Console.WriteLine(Convert.ToBoolean(trueBit)); //output: true

            int invalidBit = 8;
            Console.WriteLine(Convert.ToBoolean(invalidBit)); //output: true

            bool iBool = true;
            int bInt = Convert.ToInt32(iBool);
            Console.WriteLine(bInt); //output: 1
        }
    }
}
