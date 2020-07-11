using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SchoolManagement
{
    class Program
    {
        //Helper.InputField(Constant.INPUT_Number, MyRegex.validRealNumber, Constant.ERROR_UNFORMAT_ID)
        static void Main(string[] args)
        {
            //Match fomat = MyRegex.validRealNumber.Match(Helper.InputField(Constant.INPUT_Number, MyRegex.validRealNumber, Constant.ERROR_UNFORMAT_ID));
            float number = float.Parse(Helper.InputField(Constant.INPUT_Number, MyRegex.validRealNumber, Constant.ERROR_UNFORMAT_ID));
            //Console.WriteLine(name);

        }
    }
}
