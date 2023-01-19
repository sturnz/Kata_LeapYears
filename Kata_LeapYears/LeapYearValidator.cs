namespace Kata_LeapYears
{
    public static class LeapYearValidator
    {
        public static bool CheckForLeapYears (this int year)
        {
            if(year < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid input");
            }

            return  year        == 0 ?  false   :
                    year % 400  == 0 ?  true    :
                    year % 100  == 0 ?  false   :
                    year % 4    == 0 ?  true    :
                                        false;
        }
    }
}