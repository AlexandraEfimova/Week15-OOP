using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Gifts
        {
            string name;
            string thing;

            public Gifts(string _name, string _thing)
            {
                name = _name;
                thing = _thing;
            }

            public string Name
            {
                get { return name; }
            }
            public string Thing
            {
                get { return thing; }
            }

        }

        static void Main(string[] args)
        {
            List<Gifts> myGifts = new List<Gifts>();
            string[] giftsFromFile = GetDataFromFile();

            foreach (string line in giftsFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Gifts newGift = new Gifts(tempArray[0], tempArray[1]);
                myGifts.Add(newGift);

            }

            foreach (Gifts giftFromList in myGifts)
            {
                Console.WriteLine($" {giftFromList.Name} wants {giftFromList.Thing} for Christmas.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Alexandra\Documents\frozen\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
