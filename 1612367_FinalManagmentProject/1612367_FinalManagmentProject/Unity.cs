using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1612367_FinalManagmentProject
{
    public static class Unity
    {
        const int spereratorEach = 3;
        const string sepereatorCharacter = ".";
        public static string formatMoney(long money)
        {
            string stringMoney = money.ToString();
            int i = stringMoney.Length- spereratorEach;

            for (; i > 0; i -= spereratorEach)
            {
                stringMoney=stringMoney.Insert(i, sepereatorCharacter);
            }
            stringMoney = stringMoney + "đ";
            return stringMoney;

        }
        public static void main()
        {
            Console.Out.WriteLine(formatMoney(120000));
        }
    }
}
