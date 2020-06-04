using System;
using System.Collections.Generic;
using System.Text;

namespace Cau3
{
    static class Constaints
    {
        //Constants Menu
        public const string MENU_START = "====================MENU====================";
        public const string CREATE_ACCOUNT = "1. Create newAccount";
        public const string PAYINTO_ACCOUNT = "2. PayInto";
        public const string SHOW_INFO_ACCOUNT = "3. ShowInfo";
        public const string MENU_EXIT = "4. EXIT";
        public const string MENU_END = "============================================";
        public const string MENU_OPT = "Your option: ";
        //Constants Input
        public const string INPUT_FIRST_NAME = "Input firstName: ";
        public const string INPUT_LAST_NAME = "Input lastName: ";
        public const string INPUT_GENDER = "Input Gender: ";
        public const string INPUT_AMOUNT = "Input Amount: ";
        public const string INPUT_ID = "Input ID: ";
        public const string INPUT_Number = "Input number: ";
        //Constants Errors
        public const string ERROR_INVALLID_NAME = "INVALLID NAME: name is only string!";
        public const string ERROR_INVALLID_GENDER = "INVALLID GENDER!";
        public const string ERROR_UNFORMAT_ID = "NUMBER not STRING!";
        public const string ERROR_UNFORMAT_AMOUNT = "AMOUNT is a NUMBER not STRING!";
        public const string ERROR_NOT_ENOUGH_BALANCE = "BALANCE is NOT ENOUGH!";
        public const string ERROR_ACCOUNT_NOT_EXIST = "NOT EXIST!";
    }
}
