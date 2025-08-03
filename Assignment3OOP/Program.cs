using System;
using System.Threading.Channels;
using static Assignment3OOP.IShape;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment3OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface Questions and Answers

            // Question 1:
            /// What is the primary purpose of an interface in C#?
            /// a) To provide a way to implement multiple inheritance
            /// b) To define a blueprint for a class
            /// c) To declare abstract methods and properties
            /// d) To create instances of objects
            // Answer: b

            // Question 2:
            /// Which of the following is NOT a valid access modifier for interface members in C#?
            /// a) private
            /// b) protected
            /// c) internal
            /// d) public
            // Answer: a

            // Question 3:
            /// Can an interface contain fields in C#?
            /// a) Yes
            /// b) No
            /// c) Only if they are static
            /// d) Only if they are readonly
            // Answer: c

            // Question 4:
            /// In C#, can an interface inherit from another interface?
            /// a) No, interfaces cannot inherit from each other
            /// b) Yes, interfaces can inherit from multiple interfaces
            /// c) Yes, but only if they have the same methods
            /// d) Only if the interfaces are in the same namespace
            // Answer: b

            // Question 5:
            /// Which keyword is used to implement an interface in a class in C#?
            /// a) inherit
            /// b) use
            /// c) extends
            /// d) implements
            // Answer: d

            // Question 6:
            /// Can an interface contain static methods in C#?
            /// a) Yes
            /// b) No
            /// c) Only if the interface is sealed
            /// d) Only if the methods are private
            // Answer: a

            // Question 7:
            /// In C#, can an interface have explicit access modifiers for its members?
            /// a) Yes, for all members
            /// b) No, all members are implicitly public
            /// c) Yes, but only for abstract members
            /// d) Only if the interface is sealed
            // Answer: b

            // Question 8:
            /// What is the purpose of an explicit interface implementation in C#?
            /// a) To hide the interface members from outside access
            /// b) To provide a clear separation between interface and class members
            /// c) To allow multiple classes to implement the same interface
            /// d) To speed up method resolution
            // Answer: a

            // Question 9:
            /// In C#, can an interface have a constructor?
            /// a) Yes, but it must be private
            /// b) No, interfaces cannot have constructors
            /// c) Yes, but only if the interface is sealed
            /// d) Only if the constructor is static
            // Answer: b

            // Question 10:
            /// How can a C# class implement multiple interfaces?
            /// a) By using the "implements" keyword
            /// b) By using the "extends" keyword
            /// c) By separating interface names with commas
            /// d) A class cannot implement multiple interfaces
            // Answer: c

            #endregion

            #region Q1
            IRectangle rect = new Rectangle(2.0, 3.4);
            rect.DisplayShapeInfo();

            ICircle circ = new Circle(5);
            circ.DisplayShapeInfo();
            #endregion


          

            #region Q2
            IAuthenticationService service = new BasicAuthenticationService("admin", "1234", "Administrator");
           Console.WriteLine( service.AuthenticateUser());
            Console.WriteLine(service.AuthorizeUser());

            IAuthenticationService service02 = new BasicAuthenticationService("zahraa", "1234", "user");
            Console.WriteLine(service02.AuthenticateUser());
            Console.WriteLine(service02.AuthorizeUser());
            #endregion

            #region Q3
            INotificationService sms = new SmsNotificationService();
            sms.SendNotification(" zahraa", " hello zahraa");

            INotificationService email = new EmailNotificationService();
            email.SendNotification(" zahraa", " hello zahraa");

            INotificationService noti = new PushNotificationService();
            noti.SendNotification(" zahraa", " hello zahraa");
            #endregion



        }
}
    }