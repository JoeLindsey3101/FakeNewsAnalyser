using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeNewsAnalyser
{
    public partial class Analyser : Form
    {
        // stores the values of the array and the amount of articles from the database.
        int i = 1;
        static int ArticleCount = 0;
        public Analyser()
        {
            InitializeComponent();
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            // navigation button to the home page.
            this.Hide();
            var Home = new Home();
            Home.Closed += (s, args) => this.Close();
            Home.Show();
        }

        private void Analyser_Load(object sender, EventArgs e)
        {
            //load the 2 methods below that start the program.
            OpenSQLConnection();
            analysis();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //reloads the connection and starts the array from the first iteration.
            i = 1;
            OpenSQLConnection();
            analysis();
        }

        private static void OpenSQLConnection()
        {
            
            // used helpful tutorial from https://www.guru99.com/c-sharp-access-database.html on how to access a database and display results
            try
            {
                // creates a connection to the Database that i have created
                string connection;
                SqlConnection Con;
                connection = @"Data Source=mysqlerver12093487.database.windows.net;Initial Catalog=NewsArticles;User ID=JoeLindsey98;Password=Miggie00;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                Con = new SqlConnection(connection);
                Con.Open();

                //defines a commander for reading in the data from the database
                SqlCommand command;
                SqlDataReader dataReader;
                string sql = "";

                //select all from the database table.
                sql = "Select * from [Table]";

                //create the commander using the two defind variables
                command = new SqlCommand(sql, Con);

                //create a data reader and variables for the datareader to assign data too.
                dataReader = command.ExecuteReader();
                string outputURLs = "";
                string outputTitle = "";
                string outputAuthor = "";
                
                //while the datareader is reading, assign the first column to the article count, which stores how many articles there are currently in the database. 
                //create a string for each different column. Couldnt assign them to a string array immidiately so had to create this long winded way of assigning them to a string and then putting the string in a list inside the articles class.
                while (dataReader.Read())
                {
                    ArticleCount = dataReader.GetInt32(0);
                    outputURLs = outputURLs + "`" + dataReader.GetString(1);
                    outputTitle = outputTitle + "`" + dataReader.GetString(2);
                    outputAuthor = outputAuthor + "`" + dataReader.GetString(3);

                }

                //split the above strings to a string array which i then input them into a string list. 
                string[] URLs = new string[25];
                string[] Titles = new string[25];
                string[] Author = new string[25];
                URLs = outputURLs.Split('`');
                Titles = outputTitle.Split('`');
                Author = outputAuthor.Split('`');
                foreach (string url in URLs)
                {
                    string urlArt = url;
                    Articles.setURL(urlArt);
                }
                foreach (string title in Titles)
                {
                    string TitleArt = title;
                    Articles.setTitle(TitleArt);
                }
                foreach (string author in Author)
                {
                    string AuthorArt = author;
                    Articles.setAuthor(AuthorArt);
                }
            }

            catch (Exception caught)
            {
                MessageBox.Show(caught.Message);
                Application.Exit();
            }
        }

        private void analysis()
        {
            try
            {
                // create an instance of a class using the articles specified in variable i to analyse inside the analysis class. 
                string URLanalysis = Articles.getURl(i);
                string TitleAnalysis = Articles.getTitles(i);
                string AuthorAnalysis = Articles.getAuthor(i);
                Analysis analysis = new Analysis(URLanalysis, TitleAnalysis, AuthorAnalysis);
                // return the values of the scores to the text box value that it corresponds too.
                textBox1.Text = URLanalysis;
                textBox2.Text = TitleAnalysis;
                textBox3.Text = AuthorAnalysis;
                textBox4.Text = analysis.Final_Score + "%";
                textBox5.Text = analysis.URL_Score + "%";
                textBox6.Text = analysis.Title_Score + "%";
                textBox7.Text = analysis.Author_Score + "%";


            }
            catch (Exception caught)
            {
                MessageBox.Show(caught.Message);
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // makes sure we dont exceed the bounds of the list - also is a way to cycle through all of the articles in the database. going through the next articles
            if (i >= ArticleCount)
            {
                i = ArticleCount;
            }
            else
            {
                i++;
            }
            analysis();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // makes sure we dont exceed the bounds of the list - also is a way to cycle through all of the articles in the database. going through the previous articles
            if (i <= 1)
            {
                i = 1;
            }
            else
            {
                i--;
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            analysis();
        }
    }
}
