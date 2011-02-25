using System;
using System.Text.RegularExpressions;

namespace BaseMaster {
    public static class ValidationUtility {

        public static string Validate(string number, string fromBase) {
            string validChars = String.Empty;
            string errorText = String.Empty;
            
            switch (Convert.ToInt32(fromBase)) {
                case 2: validChars = "[01]";
                    break;
                case 8: validChars = "[0-7]";
                    break;
                case 10: validChars = "[0-9]";
                    break;
                case 16: validChars = "[0-9a-fA-F]";
                    break;
            }

            string invalidString = Regex.Replace(number, validChars, "");

            if (!String.IsNullOrEmpty(invalidString)) {
                errorText = String.Format("Invalid number format. Valid input range for base {0} is {1}.", fromBase, validChars);
            }

            return errorText;
        }

    }
}