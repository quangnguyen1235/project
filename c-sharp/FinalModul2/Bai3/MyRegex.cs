using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FinalModul2
{
    static class MyRegex
    {
        public static Regex gender = new Regex("^male$|^female$");
        public static Regex name = new Regex("^[a-zA-Z]*$");
        public static Regex number = new Regex("^[0-9]+$");
        public static Regex intnumber = new Regex("^-[0-9]+$|^[0-9]+$");
        public static Regex validRealNumber = new Regex("^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$");

    }
}
