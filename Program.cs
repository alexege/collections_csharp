using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            collections();
        }

        public static void collections(){
            int[] arr = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            string[] arr2 = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] arr3 = {true, false, true, false, true, false, true, false, true, false};

            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Strawberry");
            flavors.Add("Grape");
            flavors.Add("Blueberry");

            System.Console.WriteLine(flavors.Count);
            System.Console.WriteLine(flavors[2]);
            flavors.Remove(flavors[2]);
            System.Console.WriteLine(flavors.Count);

            Dictionary<string,string> profile = new Dictionary<string,string>();
            
            Random rand = new Random();
            for(int i = 0; i < arr2.Length-1; i++){
                profile.Add(arr2[i], flavors[rand.Next(0,5)]);
            }                                    

            foreach(KeyValuePair<string,string> entry in profile){
                System.Console.WriteLine(entry.Key + " - " + entry.Value);
            }
            
        }
    }
}
