using System;
using System.Collections.Generic;
using System.IO;

namespace OOPAndFiles
{
    class Program
    {
        class Movies
        {
            string title;
            string rating;
            string year;

            public Movies(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }

            //getters for movie

            public string Title
            {
                get { return title; }
            }
            public string Rating
            {
                get { return rating; }
            }
            public string Year
            {
                get { return year; }
            }
        }
        static void Main(string[] args)
        {
            List<Movies> myMovies = new List<Movies>();
            string[] moviesFromFile = GetDataFromFile();

            foreach(string line in moviesFromFile)
            {
                string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Movies newMovie = new Movies(tempArray[0], tempArray[1], tempArray[2]);
                myMovies.Add(newMovie);

            }

            foreach(Movies movieFromList in myMovies)
            {
                Console.WriteLine($"Title --> {movieFromList.Title}. Rating --> {movieFromList.Rating}. Year --> {movieFromList.Year}.");
            }
        }
        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Alexandra\Documents\movies\movies.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
    



}
