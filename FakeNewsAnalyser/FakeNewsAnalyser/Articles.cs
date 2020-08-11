using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeNewsAnalyser
{
    class Articles
    {
        //creates a list of strings storing the URLs, Titles and Authors of the articles inputted.
        static List<string> listOfURLs = new List<string>();
        static List<string> listOfTitles = new List<string>();
        static List<string> listOfAuthors = new List<string>();

        public Articles()
        {
        }
        //getters and setters for the lists.
        public static void setURL(string pURL)
        {
            listOfURLs.Add(pURL);
        }

        public static void setTitle(string pTitles)
        {
            listOfTitles.Add(pTitles);
        }

        public static void setAuthor(string pAuthor)
        {
            listOfAuthors.Add(pAuthor);
        }

        public static string getURl(int i)
        {
            string URL = listOfURLs[i];
            return URL;
        }
        public static string getTitles(int i)
        {
            string Titles = listOfTitles[i];
            return Titles;
        }
        public static string getAuthor(int i)
        {
            string Author = listOfAuthors[i];
            return Author;
        }
    }
}
