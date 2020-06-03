using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    static class MyRegex
    {
        public static Regex gender = new Regex("^male$|^female$");
        public static Regex name = new Regex("^[A-Z][a-zA-Z]*$");
        public static Regex number = new Regex("^[0-9]+$");
        public static Regex intnumber = new Regex("^-[0-9]+$|^[0-9]+$");
        public static Regex validRealNumber = new Regex("^([-]|[.]|[-.]|[0-9])[0-9]*[.]*[0-9]+$");

    }
}
