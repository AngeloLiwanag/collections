using System;
using System.Collections.Generic;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // basic_9(9);
            // basic_name();
            // basic_tf(10);

            // ice_cream();
            basic_dict();

        }

        public static void basic_9(int num)
        {
            int[] numArr = new int[num];
            int[] arr = {1,2,3,4,5,6,7,8,9};
            for(int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }
        }

        public static void basic_name()
        {
            string[] people = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            for (int i = 0; i < people.Length; i++)
            {
                System.Console.WriteLine(people[i]);
            }
        }
        
        public static void basic_tf(int num)
        {
            int[] numArr = new int[num];
            int[] arr = {1,2,3,4,5,6,7,8,9,10};
            for (int i = 0; i < arr.Length; i++)
            {
                if ( arr[i] % 2 != 0)
                {
                    System.Console.WriteLine("True");;
                } else {
                    System.Console.WriteLine("False");
                }
            }
        }

        public static void ice_cream()
        {
            List <string> ice = new List <string> ();
            ice.Add("Vanilla");
            ice.Add("Chocolate");
            ice.Add("Mint");
            ice.Add("Strawberry");
            ice.Add("Cookies");
            
            System.Console.WriteLine(ice.Count);
            ice.RemoveAt(3);
            System.Console.WriteLine(ice.Count);            
        }

        public static void basic_dict()
        {
            Dictionary<string, string> basic = new Dictionary<string, string>();
            basic.Add("Tim", "Vanilla");
            basic.Add("Martin", "Chocolate");
            basic.Add("Nikki", "Mint");
            basic.Add("Sara", "Strawberry");

            foreach(KeyValuePair<string,string> entry in basic)
            {
                System.Console.WriteLine(entry.Key + " " + entry.Value);
            }
        }
    }
}
// Create a dictionary that will store both string keys as well as string values
// Add key/value pairs to this dictionary where:
// each key is a name from your names array
// each value is a randomly select a flavor from your flavors list.
// Loop through the dictionary and print out each user's name and their associated ice cream flavor