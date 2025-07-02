using System;
namespace Demo
{
    internal class program
    {
        #region Q1)
        //private  static  void Main()
        //{
        //    //WeekDays W = new WeekDays();
        //    string[] W =Enum.GetNames(typeof(WeekDays));
        //    foreach(string WeekDays in W) 
        //    Console.WriteLine(WeekDays);

        //}
        //public enum WeekDays 
        //{
        //    Monday = 1,
        //    Tuesday = 2,
        //    Wednesday = 3,
        //    Thursday = 4,
        //    Friday = 5,
        //    Saturday = 6,
        //    Sunday = 7,

        //}

        #endregion

        #region Q2)

        private static void Main()
        {
            Person[] P = new Person[3];
            P[0] = new Person("Mazen",20);
            P[1] = new Person("Ashraf", 20);
            P[2] = new Person("Omar", 20);

            foreach (Person p in P)
            {
                Console.WriteLine($"Name : {p.Name}  \nAge : {p.Age}");
            }
        }
        public struct Person
        {
            public string Name;
            public int Age;

            public Person(string name, int age) 
            {
                Name = name;
                Age = age;
            }
        }



        #endregion

    }
}