using System;

namespace UnitTestingForString
{
    public class LengthHelper
    {
       public int findLength(string str)
        {
            return str.Length;
        }
        static void Main(string[] args)
        {
            LengthHelper helper = new LengthHelper();
            string str;
            int len = 0;
            Console.Write("Enter Your String:");
            str = Console.ReadLine();
            len = helper.findLength(str);
            Console.Write("Length of the string is : {0}\n\n", len);

        }
    }
}
