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

        //private static void Main()
        //{
        //    Person[] P = new Person[3];
        //    P[0] = new Person("Mazen",20);
        //    P[1] = new Person("Ashraf", 20);
        //    P[2] = new Person("Omar", 20);

        //    foreach (Person p in P)
        //    {
        //        Console.WriteLine($"Name : {p.Name}  \nAge : {p.Age}");
        //    }
        //}
        //public struct Person
        //{
        //    public string Name;
        //    public int Age;

        //    public Person(string name, int age) 
        //    {
        //        Name = name;
        //        Age = age;
        //    }
        //}



        #endregion

        #region Q3)

        //public static void Main()
        //{
        //    String s =Console.ReadLine();
        //    Season S = (Season)Enum.Parse(typeof(Season), s, true);

        //    switch (S)
        //    {
        //        case Season.Spring:
        //            Console.WriteLine("march to may");
        //        break;

        //        case Season.Summer:
        //            Console.WriteLine("june to august");
        //        break;

        //        case Season.Autumn:
        //            Console.WriteLine("September to November");
        //        break;

        //        case Season.Winter:
        //            Console.WriteLine("December to February");
        //        break;

        //    }
        //}
        //public enum Season
        //{
        //    Spring =1,
        //    Summer =2,
        //    Autumn =3,
        //    Winter =4

        //}


        #endregion

        #region Q4)
        //public static void Main() 
        //{
        //    string C = Console.ReadLine();


        //    if (Enum.TryParse(typeof(Colors),C , true, out object result)) 
        //    {
        //        Colors color = (Colors)result;

        //        if (color == Colors.Red || color == Colors.Green || color == Colors.Blue)
        //        {
        //            Console.WriteLine($"{color} is Primary Color");
        //        }
        //        else 
        //        {
        //        Console.WriteLine($"{color} is not Primary Color");
        //        }

        //    }
        //    else 
        //    {

        //        Console.WriteLine("invalid");
        //     }



        //}
        //public enum Colors 
        //{
        //    Red,
        //   Green,
        //   Blue
        //}

        #endregion

        #region Q5)
        public static void Main() 
        {
            Console.WriteLine("To Calc Distance between 2D Two Points");
            Console.WriteLine("");
            Console.WriteLine("enter x1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter y1");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter x2");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter y2");
            double y2 = double.Parse(Console.ReadLine());

            Point Point1 = new Point (x1,y1);
            Point Point2 = new Point(x2, y2);

            double distance = Point1.calcdis(Point2);

            Console.WriteLine($"Distance Between : ({Point1.X},{Point1.Y}) , ({Point2.X},{Point2.Y}) = {distance:f} ");
        }
        public struct Point 
        {
        
            public double X;
            public double Y;
            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
            public double  calcdis(Point OtherPoint) 
            {
                double clacX = OtherPoint.X - X;
                double clacY = OtherPoint.Y - Y;
               return Math.Sqrt(clacX * clacX + clacY * clacY);
            }
        
        }

        #endregion
    }
}