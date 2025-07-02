using System;
namespace Demo
{
    internal class program
    {
        #region Q1)
        private  static  void Main()
        {
            //WeekDays W = new WeekDays();
            string[] W =Enum.GetNames(typeof(WeekDays));
            foreach(string WeekDays in W) 
            Console.WriteLine(WeekDays);

        }
        public enum WeekDays 
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7,

        }

        #endregion

}   }