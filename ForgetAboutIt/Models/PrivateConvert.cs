using System;
using System.Collections.Generic;
using System.Linq;

namespace ForgetAboutIt.Models
{
    public static class PrivateConvert
    {
      

        public static Dictionary<string,int> Months = new Dictionary<string, int>
        {
            {"January", 1},
                {"Jan", 1},
                {"February", 2},
                {"Feb", 2},
                {"March", 3},
                {"Mar", 3},
                {"April", 4},
                {"Apr", 4},
                {"May", 5},
                {"June", 6},
                {"Jun", 6},
                {"July", 7},
                {"Jul", 7},
                {"August", 8},
                {"Aug", 8},
                {"September", 9},
                {"Sep", 9},
                {"Sept", 9},
                {"October", 10},
                {"Oct", 10},
                {"November", 11},
                {"Nov", 11},
                {"December", 12},
                {"Dec", 12}
        };


        public static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }
    }
}