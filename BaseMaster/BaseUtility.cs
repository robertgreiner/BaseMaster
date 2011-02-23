namespace BaseMaster {
    public static class BaseUtility {

        //After doing some research, it looks like .NET has overloaded some methods to make base 
        //conversion mind-numbingly trivial.  This is not what I intended to do from the beginning of 
        //the project, but I can’t bring myself to re-invent the wheel here, even for a mind-exercise.
        public static string Convert(string num, int fromBase, int toBase) {
            string result = "";

            //An exception can be thrown if the input number is not formatted properly for its respective base.
            //Example: 109 base 2 is not valid input and should be caught by the client-side validation before it ever gets this far.
            try {
                //Convert the number to base 10 so we can start off on common ground.
                long decValue = System.Convert.ToInt64(num, fromBase);

                //Now that we have the user inputed value in base-10 we can convert it to whatever base we like
                //using the overloaded Convert.ToString() method.
                result = System.Convert.ToString(decValue, toBase);
            } catch (System.Exception) {
                result = "ERR";
            }

            //Return the result that is criminally easy to come by and move on to the next project.  Bummer.
            return result.ToUpper();
        }

    }
}