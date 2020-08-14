using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
         public class Person 
        {
            private string Fname;
            private string Mname;
            private string Lname;
            private string Street1;
            private string Street2;
            private string City;
            private string State;
            private string Zip;
            private string Phone;
            private string Email;

            public string fname
            {
                get
                {
                    return Fname;
                }
                set
                {
                    Fname = value;
                }
            }

            public string mname
            {
                get
                {
                    return Mname;
                }
                set
                {
                    Mname = value;
                }
             }

            public string lname
            {
                get
                {
                    return Lname;
                }
                set
                {
                    Lname = value;
                }
            }
            public string street1
            {
                get
                {
                    return Street1;
                }
                set
                {
                    Street1 = value;
                }
            }
            public string street2
            {
                get
                {
                    return Street2;
                }
                set
                {
                    Street2 = value;
                }
            }
            public string city
            {
                get
                {
                    return City;
                }
                set
                {
                    City = value;
                }
            }
            public string state
            {
                get
                {
                    return State;
                }
                set
                {
                    State = value;
                }
            }
            public string zip
            {
                get
                {
                    return Zip;
                }
                set
                {
                    Zip = value;
                }
            }
            public string phone
            {
                get
                {
                    return Phone;
                }
                set
                {
                    Phone = value;
                }
            }
            public string email
            {
                get
                {
                    return Email;
                }
                set
                {
                    Email = value;
                }
            }
        }
        static bool zipcodechar(string zip)
        {
            bool result = false; 
            if (zip.Length < 5)
            {
                result = true;
            }
            return result;
        }

        static bool IsItFilledIn(string zip, int minlen)
        {
            bool result = false; 
            if (zip.Length > minlen)
            {
                result = true;
            }
            return result;
        }
        static bool phonechar(string phone)
        {
            bool result = false;
            if (phone.Length < 10)
            {
                result = true;
            }
            return result;
        }

        static bool IsItEntered(string phone, int minlen)
        {
            bool result = false;
            if (phone.Length > minlen)
            {
                result = true;
            }
            return result;
        }
        static bool emailchar(string email)
        {
            bool result = false;
            if (email.Length < 5)
            {
                result = true;
            }
            return result;
        }

        static bool FilledInCheck(string zip, int minlen)
        {
            bool result = false;
            if (zip.Length > minlen)
            {
                result = true;
            }
            return result;
        }

        static void Main(string[] args)
        {
            bool blnResult = false;

            Person temp = new Person();
            
            Console.Write("\nPlease Enter First Name  :");
            temp.fname= Console.ReadLine()+"Poopy";

            Console.Write("\nPlease Enter Middle Name  :");
            temp.mname= Console.ReadLine();

            Console.Write("\nPlease Enter Last Name  :");
            temp.lname = Console.ReadLine();

            Console.Write("\nPlease Enter Street1 Address  :");
            temp.street1 = Console.ReadLine();

            Console.Write("\nPlease Enter Street2 Address  :");
            temp.street2 = Console.ReadLine();

            Console.Write("\nPlease Enter City  :");
            temp.city = Console.ReadLine();

            Console.Write("\nPlease Enter State :");
            temp.state = Console.ReadLine();

            Console.Write("\nPlease Enter Zip  :");
            temp.zip = Console.ReadLine();

            Console.Write("\nPlease Enter Phone number  :");
            temp.phone = Console.ReadLine();

            Console.Write("\nPlease Enter Email  :");
            temp.email = Console.ReadLine();

            Console.Write("\n\n Here is the information that we have on you: ");
            Console.Write($"\n\n First name: {temp.fname} ");
            Console.Write($"\n\n Middle name: {temp.mname} ");
            Console.Write($"\n\n Last name: {temp.lname} ");
            Console.Write($"\n\n Address One: {temp.street1} ");
            Console.Write($"\n\n Address Two: {temp.street2} ");
            Console.Write($"\n\n City: {temp.city} ");
            Console.Write($"\n\n State: {temp.state} ");
            Console.Write($"\n\n Zip: {temp.zip} ");
            Console.Write($"\n\n Phone Number: {temp.phone} ");
            Console.Write($"\n\n Email: {temp.email} ");
            Console.ReadKey();




        }
    }
}


