using System;
using System.Collections.Generic;
using System.Text;

namespace WefghDrawing
{
    public static class AbjadKabir
    {
        private static readonly Dictionary<char, int> AbjadValues = new Dictionary<char, int>()
        {
            {'ا',1}, {'أ',1}, {'إ',1}, {'آ',1},{'ئ',1},
            {'ب',2},
            {'ج',3},
            {'د',4},
            {'ه',5}, {'ة',5},
            {'و',6},
            {'ز',7},
            {'ح',8},
            {'ط',9},
            {'ی',10}, {'ي',10}, 
            //{'ئ',10},
            {'ك',20}, {'ک',20},
            {'ل',30},
            {'م',40},
            {'ن',50},
            {'س',60},
            {'ع',70},
            {'ف',80},
            {'ص',90},
            {'ق',100},
            {'ر',200},
            {'ش',300},
            {'ت',400},
            {'ث',500},
            {'خ',600},
            {'ذ',700},
            {'ض',800},
            {'ظ',900},
            {'غ',1000},

            // Persian letters mapped to closest Arabic equivalents
            {'پ',2},   // like ب
            {'چ',3},   // like ج
            {'ژ',7},   // like ز
            {'گ',20},  // like ک
            {'ء',0}
        };

        public static int Calculate(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return 0;

            int sum = 0;

            foreach (char c in Normalize(text))
            {
                if (AbjadValues.TryGetValue(c, out int value))
                    sum += value;
            }

            return sum;
        }

        private static string Normalize(string text)
        {
            return text
                .Replace("ي", "ی")
                .Replace("ك", "ک")
                .Replace("ؤ", "و")
                .Replace("إ", "ا")
                .Replace("أ", "ا")
                .Replace("آ", "ا");
        }
    }
}