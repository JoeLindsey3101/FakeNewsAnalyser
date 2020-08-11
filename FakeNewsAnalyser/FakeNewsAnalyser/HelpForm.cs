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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Home = new Home();
            Home.Closed += (s, args) => this.Close();
            Home.Show();
        }

        private void AnalyserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Analyser = new Analyser();
            Analyser.Closed += (s, args) => this.Close();
            Analyser.Show();
        }
    }
}
