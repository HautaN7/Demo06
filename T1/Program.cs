using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object from Persons
            Persons myFriends = new Persons();


            // create a friends...
            Person person1 = new Person { Firstname = "Jussi", Lastname = "Jurkka", SocialSecurityNumber = "020202-123A" };
            Person person2 = new Person { Firstname = "Jukka", Lastname = "Jurkka", SocialSecurityNumber = "123456+987B" };
            Person person3 = new Person { Firstname = "Juuso", Lastname = "Jurkka", SocialSecurityNumber = "010203-456C" };

            // add persons to collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // print collection
            myFriends.PrintCollection();

            // get one person
            Console.WriteLine("Get on person from friends");
            Person person4 = myFriends.GetPerson(1);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find person in that position...");
            }

            // find person with SSN
            string socialSecurityNumber = "010203-456C";
            myFriends.FindPerson(socialSecurityNumber);
            Person person5 = myFriends.FindPerson(socialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Not found...");
            }
        }
    }
}
