using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.) Compute Full Name (String) [ check ]
            // 2.) Compute Height CM (double)
            // 3.) Compute if you Can Vote (bool)


            // 1

            string firstName;
            string middleName;
            string lastName;

            Console.WriteLine("Shantel");
            firstName = Console.ReadLine();

            Console.WriteLine("DeSha");
            middleName = Console.ReadLine();

            Console.WriteLine("Binford");
            lastName = Console.ReadLine();

            string fullName = firstName + " " + middleName + " " + lastName;

            Console.WriteLine("fullName");

            Console.ReadKey();

            // 2

            const double CM_MULTIPLER = 2.54;
            const double INCHES_PER_FOOT = 12;
            int heightFeet;
            double heightInches;

            Console.WriteLine("5: ");
            heightFeet = int.Parse(Console.ReadLine());

            Console.WriteLine("6: ");
            heightInches = double.Parse(Console.ReadLine());

            double inches = heightFeet * INCHES_PER_FOOT;

            inches += heightInches;

            double heightCM = CM_MULTIPLER * inches;

            Console.WriteLine(heightCM);

            // 3

            int age;
            bool isCitizen;

            Console.WriteLine("28");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("yes");
            isCitizen = Console.ReadLine().ToLower().StartsWith("y", StringComparison.CurrentCulture);

            Console.WriteLine(age >= 18 && isCitizen);

            Console.ReadKey();










        }
    }
}
