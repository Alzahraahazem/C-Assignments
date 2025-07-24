using System;

namespace Assignment1OOP
{
    internal class Program
    {
        #region Part1
        #region Q1
        enum WeekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
        #endregion

        #region Q2
        struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
        #endregion

        #region Q3
        enum Season { Spring, Summer, Autumn, Winter }

        #endregion

        #region Q4
        [Flags]
        enum Permissions { Read = 1, Write = 2, Delete = 4, Execute = 8 }

        #endregion

        #region Q5
        enum Colors { Red, Green, Blue }

        #endregion

        #region Q6
        struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
        }
        #endregion

        #region Q7
        struct Person2
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person2(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
        #endregion

        #endregion

        #region Part2

        enum Gender
        {
            M,
            F
        }

        enum SecurityLevel
        {
            Guest,
            Developer,
            Secretary,
            DBA
        }
        class HireDate
        {
            public int Day { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }

            public HireDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public override string ToString()
            {
                return $"{Day}/{Month}/{Year}";
            }
        }

        class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public SecurityLevel Security { get; set; }
            public double Salary { get; set; }
            public HireDate HireDate { get; set; }
            public Gender Gender { get; set; }

            public Employee(int id, string name, SecurityLevel security, double salary, HireDate hireDate, Gender gender)
            {
                ID = id;
                Name = name;
                Security = security;
                Salary = salary;
                HireDate = hireDate;
                Gender = gender;
            }

            public override string ToString()
            {
                return $"ID: {ID}  Name: {Name} Gender: {Gender} Security Level: {Security}  Salary: {String.Format("{0:C}", Salary)} Hire Date: {HireDate}";
            }

            #endregion

            static void Main(string[] args)
            {

                #region Part1

                #region Q1
                Console.WriteLine("Days:");
                foreach (var day in Enum.GetValues(typeof(WeekDays)))
                {
                    Console.WriteLine(day);
                }
                #endregion

                #region Q2
                Person[] people = new Person[3];
                people[0] = new Person("Zahraa", 22);
                people[1] = new Person("Hazem", 50);
                people[2] = new Person("Akl", 70);

                foreach (var person in people)
                {
                    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
                }
                #endregion

                #region Q3
                bool isparesd = true;

                Console.WriteLine("Enter a season name:");
                string s = Console.ReadLine()!;

                isparesd = Enum.TryParse(s, out Season season);

                if (isparesd)
                {
                    switch (season)
                    {
                        case Season.Spring:
                            Console.WriteLine(" March to May");
                            break;
                        case Season.Summer:
                            Console.WriteLine(" June to August");
                            break;
                        case Season.Autumn:
                            Console.WriteLine(" September to November");
                            break;
                        case Season.Winter:
                            Console.WriteLine(" December to February");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid season name");
                }

                #endregion

                #region Q4
                Permissions prem = Permissions.Read | Permissions.Write; // add read , write
                Console.WriteLine(prem);

                prem |= Permissions.Execute; //add execute
                Console.WriteLine(prem);

                prem &= ~Permissions.Write; //delete write
                Console.WriteLine(prem);

                bool hasDelete = (prem & Permissions.Delete) == Permissions.Delete;

                if (hasDelete)
                {
                    Console.WriteLine("Delete permission found.");
                }
                else
                {
                    Console.WriteLine("Delete not found.");
                }

                bool hasExecute = prem.HasFlag(Permissions.Execute);

                if (hasExecute)
                {
                    Console.WriteLine("Execute permission found.");
                }
                else
                {
                    Console.WriteLine("Execute permission not found.");
                }
                #endregion

                #region Q5
                Console.WriteLine("Enter a color name:");
                string c = Console.ReadLine()!;

                isparesd = Enum.TryParse(c, out Colors color);

                if (isparesd)
                {

                    Console.WriteLine($"{color} is a primary color.");
                }
                else
                {
                    Console.WriteLine($"{color}is not  primary ");
                }
                #endregion

                #region Q6
                Console.WriteLine("Enter Point x1 and y1:");
                double x1 = Convert.ToDouble(Console.ReadLine());

                double y1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Point x2 and y2:");
                double x2 = Convert.ToDouble(Console.ReadLine());

                double y2 = Convert.ToDouble(Console.ReadLine());

                Point p1 = new Point(x1, y1);
                Point p2 = new Point(x2, y2);

                double dist = (p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y);

                Console.WriteLine($"\nDistance between the two points: {dist}");

                #endregion

                #region Q7
                Person[] p = new Person[3];

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Enter details for person :");
                    Console.Write("Name: ");
                    string name = Console.ReadLine()!;

                    Console.Write("Age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    p[i] = new Person(name, age);
                }

                Person oldest = p[0];

                for (int i = 1; i < p.Length; i++)
                {
                    if (p[i].Age > oldest.Age)
                    {
                        oldest = p[i];
                    }
                }

                Console.WriteLine($"The oldest person is: {oldest.Name} Age: {oldest.Age}");

                #endregion

                #endregion
                #region Part2

                Employee[] Emp = new Employee[3];

                Emp[0] = new Employee(1, "zahraa", SecurityLevel.DBA, 10000, new HireDate(1, 5, 2020), Gender.M);
                Emp[1] = new Employee(2, "hazem", SecurityLevel.Guest, 5000, new HireDate(10, 6, 2023), Gender.F);
                Emp[2] = new Employee(3, "akl", SecurityLevel.Secretary, 12000, new HireDate(15, 1, 2019), Gender.F);

                foreach (var e in Emp)
                {
                    Console.WriteLine(e);
                }

                #endregion
            }
        }
    }
}
