using System;
using System.Reflection.Metadata.Ecma335;

namespace Open_Lab_04._04
{
    public class PhoneNumbers
    {
        public string FormatPhoneNumber(int[] numbers)
        {
            int[] pleb = new int[numbers.Length - 7];
            for(int i = 0; i < pleb.Length; i++)
            {
                pleb[i] = numbers[i];
            }
            string bruh = string.Join("",(pleb));
            string bruhplus = "(" + bruh + ")" + " " + numbers[3] + numbers[4] + numbers[5] + "-" + numbers[6] + numbers[7] + numbers[8] + numbers[9];
            return bruhplus;
            









        } 


       
    }
}
