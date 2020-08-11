using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeNewsAnalyser
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void AnalyserBtn_Click(object sender, EventArgs e)
        {
            //goto analyser form.
            this.Hide();
            var Analyser = new Analyser();
            Analyser.Closed += (s, args) => this.Close();
            Analyser.Show();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            //reload home form.
            this.Hide();
            var Home = new Home();
            Home.Closed += (s, args) => this.Close();
            Home.Show();
        }
        private void analysis()
        {
            try
            {
                //takes the strins inputted in the textboxes and stores them in a variable
                string URLanalysis = UrlTxt.Text;
                string TitleAnalysis = TitleTxt.Text;
                string AuthorAnalysis = AuthorTxt.Text;
                //checks to see if the URL is a valid URL inputted.
                if (URLanalysis.Contains("https://") || URLanalysis.Contains("http://"))
                { 
                    //checks to see if the title isnt empty, or contains the default string.
                    if (TitleAnalysis != "" && TitleAnalysis != "Please input the title of the article from the URL")
                    {
                        //checks to see if the author isnt empty or contains the default string
                        if (AuthorAnalysis != "" && AuthorAnalysis != "Please input the author of the article")
                        {
                            //constructs the analysis class, inputs the strings and gets the scores out from the analysis class.
                            Analysis analysis = new Analysis(URLanalysis, TitleAnalysis, AuthorAnalysis);
                            double URLScore = analysis.URL_Score;
                            double TitleScore = analysis.Title_Score;
                            double AuthorScore = analysis.Author_Score;
                            double finalscore = analysis.Final_Score;
                            FinalScoreTxt.Text = finalscore.ToString() + "%";
                            UrlScoreTxt.Text = URLScore.ToString() +"%";
                            TitleScoreTxt.Text = TitleScore.ToString() + "%";
                            AuthorScoreTxt.Text = AuthorScore.ToString() + "%";
                        }


                    }
                    
                }
                //data validation checkers to display error messages on the software.
                else if (!URLanalysis.Contains("https://") || !URLanalysis.Contains("http://"))
                {
                    MessageBox.Show("Please input a valid URL.");
                }
                if (TitleAnalysis == "" || TitleAnalysis == "Please input the title of the article from the URL")
                {
                    MessageBox.Show("Please input a title.");
                }
                if (AuthorAnalysis == "" || AuthorAnalysis == "Please input the author of the article")
                {
                    MessageBox.Show("Please input a Author.");
                }

            }
            catch (Exception caught)
            {
                MessageBox.Show(caught.Message);
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calls the analysis method when clicked to analyse the inputted article
            analysis();
        }
        private void UrlTxt_Click(object sender, EventArgs e)
        {
            //selects all the text inside the textbox when clicked
            UrlTxt.SelectAll();
        }

        private void TitleTxt_Click(object sender, EventArgs e)
        {
            //selects all the text inside the textbox when clicked
            TitleTxt.SelectAll();
        }

        private void AuthorTxt_Click(object sender, EventArgs e)
        {
            //selects all the text inside the textbox when clicked
            AuthorTxt.SelectAll();
        }
    }
}
