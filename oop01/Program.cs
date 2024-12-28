using System.ComponentModel;

namespace oop01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.

            //WeekDays weekDays = new WeekDays();
            //for (int i = 0; i < 7; i++)
            //{
            //    weekDays = (WeekDays)i;
            //    Console.WriteLine(weekDays);
            //}

            #endregion

            #region 2-Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //SeasOn season = new SeasOn();
            //bool isparsed;
            //Console.WriteLine("Please Enter Season :");
            //do
            //{
            //    Console.Write("Season : ");
            //    //isparsed = SeasOn.TryParse(Console.ReadLine(), out season);
            //    isparsed = Enum.TryParse<SeasOn>(Console.ReadLine(), out season);
            //}
            //while (!isparsed);

            //if (season == SeasOn.Spring) { Console.WriteLine($"Month range for {season} season :: March to May"); }
            //else if (season == SeasOn.Winter) { Console.WriteLine($"Month range for {season} season :: December to February"); }
            //else if (season == SeasOn.Autumn) { Console.WriteLine($"Month range for {season} season :: September to November"); }
            //else { Console.WriteLine($"Month range for {season} season :: June to August"); }

            #endregion

            #region 3-Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable

            ////User user = new User();
            ////Console.WriteLine(user.permissions);
            ////user.permissions = user.permissions ^ Permissions.write;
            ////Console.WriteLine(user.permissions);
            ////user.permissions = user.permissions ^ Permissions.Delete;
            ////Console.WriteLine(user.permissions);
            ////user.permissions = user.permissions ^ Permissions.write;
            ////Console.WriteLine(user.permissions);

            //Permissions permissions = new Permissions();
            //Console.WriteLine(permissions);
            //permissions = permissions | Permissions.Delete;
            //permissions = permissions | Permissions.write;
            //Console.WriteLine(permissions);
            //permissions = permissions & Permissions.Delete;
            //Console.WriteLine(permissions);
            //permissions = permissions ^ Permissions.Delete;
            //Console.WriteLine(permissions);
            //if (permissions == Permissions.Delete)
            //    Console.WriteLine("permission has delete");
            //else
            //    permissions = permissions ^ Permissions.Delete;
            //Console.WriteLine(permissions);
            #endregion

            #region 4.Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter a color please");
            //Console.Write("Color : ");
            //if (Enum.TryParse<Colors>(Console.ReadLine(), out Colors colors))
            //    Console.WriteLine($"{colors} is a primary color ");
            //else Console.WriteLine("This color is not a primary color ");



            #endregion


        }

    }
   
}
