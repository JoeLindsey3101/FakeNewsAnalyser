using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeNewsAnalyser
{
    class Analysis
    {
        // List of variables used inside the class.
        public string m_URL;
        public string m_Title;
        public string m_Author;
        public double URL_Score;
        public double Title_Score;
        public double Author_Score;
        public double Final_Score;
        public string Newspaper = "";
        public string URLStarter = "";


        public Analysis(string pURL, string pTitle, string pAuthor)
        {
            //Class Constructor with method calls inside.
            SetURL(pURL);
            SetTitle(pTitle);
            SetAuthor(pAuthor);
            URLAnalyser();
            TitleAnalyser();
            AuthorAnalyser();
            Addition();

        }
        // These methods are getters and setters for the variables above.
        public void SetURL(string pURL)
        {
            m_URL = pURL;
        }

        public void SetTitle(string pTitle)
        {
            m_Title = pTitle;
        }
        public void SetAuthor(string pAuthor)
        {
            m_Author = pAuthor;
        }

        public string GetURL()
        {
            return m_URL;
        }

        public string GetTitle()
        {
            return m_Title;
        }

        public string GetAuthor()
        {
            return m_Author;
        }

        public double URLAnalyser()
        {
            //set 2 strings, one to analyse using the algorithm and the other keeps the score.
            string analysis = m_URL;
            URL_Score = 100;
            // these check the length of the URL and depending on length lower the score for the URL.
            if (analysis.Length >= 50 && analysis.Length <= 74)
            {
                URL_Score = URL_Score - 10;
            }
            else if (analysis.Length >= 75 && analysis.Length <= 99)
            {
                URL_Score = URL_Score - 25;
            }
            else if (analysis.Length >= 100 && analysis.Length <= 149)
            {
                URL_Score = URL_Score - 50;
            }
            else if (analysis.Length >= 150)
            {
                URL_Score = URL_Score - 66.6;
            }
            else if (analysis.Length <= 25)
            {
                // if the article is below 25 characters long, its likely not a real URL, or a real Article.
                URL_Score = 0;
            }
            //this checks to see if the connection of the website is HTTPS secure or not.
            if (analysis.Contains("Https") || analysis.Contains("HTTPS") || analysis.Contains("https"))
            {
                URL_Score = URL_Score + 3;
                URLStarter = "https";
            }
            else
            {
                URL_Score = URL_Score - 10;
            }
            //these checks to see if the website URL is apart of any known Newspaper websites.
            if (analysis.Contains("theguardian"))
            {
                URL_Score = URL_Score + 15;
                Newspaper = "theguardian";
            }
            if (analysis.Contains("independant") && analysis.Contains("https"))
            {
                URL_Score = URL_Score + 15;
                Newspaper = "independant";
            }
            if (analysis.Contains("thesun"))
            {
                URL_Score = URL_Score - 5;
                Newspaper = "thesun";
            }
            if (analysis.Contains("nytimes"))
            {
                URL_Score = URL_Score + 10;
                Newspaper = "nytimes";
            }
            if (analysis.Contains("infowars"))
            {
                URL_Score = URL_Score -  35;
                Newspaper = "infowars";
            }
            if (URL_Score >= 100)
            {
                //this caps the score at 100%
                URL_Score = 100;
            }
            return URL_Score;
        }
        public double TitleAnalyser()
        {
            // sets strings for analysis and score
            string analysis = m_Title;
            Title_Score = 100;
            // checks the length of the title and scores dependant on the length of the title.
            if (analysis.Length >= 30 && analysis.Length <= 49)
            {
                Title_Score = Title_Score - 10;
            }
            else if (analysis.Length >= 50 && analysis.Length <= 74)
            {
                Title_Score = Title_Score - 25;
            }
            else if (analysis.Length >= 75 && analysis.Length <= 110)
            {
                Title_Score = Title_Score - 45;
            }
            else if (analysis.Length >= 111)
            {
                Title_Score = Title_Score - 70;
            }
            else if (analysis.Length <= 29)
            {
                Title_Score = Title_Score - 38.5;
            }
            // Checks the string to see the language contained inside and lower the score if it contains the language listed below.
            if (analysis.Contains("you") || analysis.Contains("You"))
            {
                Title_Score = Title_Score - 5;
            }
            if (analysis.Contains("Scariest") || analysis.Contains("scariest"))
            {
                Title_Score = Title_Score - 3.5;
            }
            if (analysis.Contains("Angriest") || analysis.Contains("angriest"))
            {
                Title_Score = Title_Score - 3.5;
            }
            if (analysis.Contains("Brightest") || analysis.Contains("brightest"))
            {
                Title_Score = Title_Score - 3.5;
            }
            if (analysis.Contains("Coldest") || analysis.Contains("coldest"))
            {
                Title_Score = Title_Score - 3.5;
            }
            if (analysis.Contains("Coolest") || analysis.Contains("coolest"))
            {
                Title_Score = Title_Score - 3.5;
            }
            if (analysis.Contains("Richest") || analysis.Contains("richest"))
            {
                Title_Score = Title_Score - 3.5;
            }
            if (analysis.Contains("Smartest") || analysis.Contains("smartest"))
            {
                Title_Score = Title_Score - 3.5;
            }
            if (analysis.Contains("Simplest") || analysis.Contains("simplest"))
            {
                Title_Score = Title_Score - 3.5;
            }
            if (analysis.Contains("Most famous") || analysis.Contains("most famous"))
            {
                Title_Score = Title_Score - 3.5;
            }
            if (analysis.Contains("Longest") || analysis.Contains("longest"))
            {
                Title_Score = Title_Score - 3.5;
            }
            if (analysis.Contains("Most immense") || analysis.Contains("most immense"))
            {
                Title_Score = Title_Score - 3.5;
            }
            if (analysis.Contains("Quickest") || analysis.Contains("quickest"))
            {
                Title_Score = Title_Score - 3.5;
            }
            if (analysis.Contains("Truth") || analysis.Contains("truth"))
            {
                Title_Score = Title_Score - 5;
            }
            //checks to see if the language used is classified as "Clickbait"
            if (analysis.Contains("Rumours") || analysis.Contains("rumours") || analysis.Contains("rumour") || analysis.Contains("Rumour"))
            {
                Title_Score = Title_Score - 7;
            }
            if (analysis.Contains("Click Here") || analysis.Contains("Click here") || analysis.Contains("click Here") || analysis.Contains("click here"))
            {
                Title_Score = Title_Score - 7;
            }
            if (Title_Score >= 100)
            {
                Title_Score = 100;
            }
            
            return Title_Score;
        }
        public double AuthorAnalyser()
        {
            // sets strings for analysis and score
            string analysis = m_Author;
            Author_Score = 100;
            // checks to see if the length of the authors name
            if (analysis.Length >= 70)
            {
                Author_Score = Author_Score - 20;
            }
            //checks to see if the author is a Dr. or has a PhD
            if (analysis.Contains("Dr."))
            {
                Author_Score = Author_Score + 10;
            }
            if (analysis.Contains("PhD"))
            {
                Author_Score = Author_Score + 15;
            }
            //checks to see if a variable defind before contains any of these papers and if it does scores is based on the paper.
            if (Newspaper.Contains("theguardian"))
            {
                Author_Score = Author_Score + 15;
            }
            if (Newspaper.Contains("independant"))
            {
                Author_Score = Author_Score + 15;
            }
            if (Newspaper.Contains("thesun"))
            {
                Author_Score = Author_Score - 5;
            }
            if (Newspaper.Contains("infowars"))
            {
                Author_Score = Author_Score - 50;
            }
            if (Newspaper.Contains("nytimes"))
            {
                Author_Score = Author_Score + 10;
            }
            //scores the paper based on if the website was HTTPS or not
            if (URLStarter.Contains("https"))
            {
                Author_Score = Author_Score + 15;
            }
            if (!URLStarter.Contains("https"))
            {
                Author_Score = Author_Score - 10;
            }
            if (Author_Score > 100)
            {
                Author_Score = 100;
            }
            if(analysis.Length <= 8)
            {
                Author_Score = Author_Score - 40;
            }
            if (Author_Score >= 100)
            {
                Author_Score = 100;
            }
            return Author_Score;
        }

        public double Addition()
        {
            //calculate the final score for the article that is inputted.
            Final_Score = (URL_Score * 0.5) + (Title_Score * 0.4) + (Author_Score * 0.1);
            return Final_Score;
        }
    }
}
