namespace FakeNewsAnalyser
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.AnalyserBtn = new System.Windows.Forms.Button();
            this.UrlTxt = new System.Windows.Forms.TextBox();
            this.UrlScoreTxt = new System.Windows.Forms.TextBox();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.AuthorTxt = new System.Windows.Forms.TextBox();
            this.TitleScoreTxt = new System.Windows.Forms.TextBox();
            this.AuthorScoreTxt = new System.Windows.Forms.TextBox();
            this.FinalScoreTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(76, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fake News Analyser";
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Brown;
            this.HomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeBtn.Location = new System.Drawing.Point(-6, 132);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(362, 63);
            this.HomeBtn.TabIndex = 2;
            this.HomeBtn.Text = "Analyse Your Article";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // AnalyserBtn
            // 
            this.AnalyserBtn.BackColor = System.Drawing.Color.Brown;
            this.AnalyserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalyserBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AnalyserBtn.Location = new System.Drawing.Point(-5, 187);
            this.AnalyserBtn.Name = "AnalyserBtn";
            this.AnalyserBtn.Size = new System.Drawing.Size(362, 67);
            this.AnalyserBtn.TabIndex = 3;
            this.AnalyserBtn.Text = "Preset Examples";
            this.AnalyserBtn.UseVisualStyleBackColor = false;
            this.AnalyserBtn.Click += new System.EventHandler(this.AnalyserBtn_Click);
            // 
            // UrlTxt
            // 
            this.UrlTxt.Location = new System.Drawing.Point(357, 154);
            this.UrlTxt.Name = "UrlTxt";
            this.UrlTxt.Size = new System.Drawing.Size(545, 20);
            this.UrlTxt.TabIndex = 6;
            this.UrlTxt.Text = "Please input a URL";
            this.UrlTxt.Click += new System.EventHandler(this.UrlTxt_Click);
            // 
            // UrlScoreTxt
            // 
            this.UrlScoreTxt.Location = new System.Drawing.Point(924, 154);
            this.UrlScoreTxt.Name = "UrlScoreTxt";
            this.UrlScoreTxt.ReadOnly = true;
            this.UrlScoreTxt.Size = new System.Drawing.Size(87, 20);
            this.UrlScoreTxt.TabIndex = 7;
            // 
            // TitleTxt
            // 
            this.TitleTxt.Location = new System.Drawing.Point(357, 250);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(545, 20);
            this.TitleTxt.TabIndex = 8;
            this.TitleTxt.Text = "Please input the title of the article from the URL";
            this.TitleTxt.Click += new System.EventHandler(this.TitleTxt_Click);
            // 
            // AuthorTxt
            // 
            this.AuthorTxt.Location = new System.Drawing.Point(357, 348);
            this.AuthorTxt.Name = "AuthorTxt";
            this.AuthorTxt.Size = new System.Drawing.Size(545, 20);
            this.AuthorTxt.TabIndex = 9;
            this.AuthorTxt.Text = "Please input the author of the article";
            this.AuthorTxt.Click += new System.EventHandler(this.AuthorTxt_Click);
            // 
            // TitleScoreTxt
            // 
            this.TitleScoreTxt.Location = new System.Drawing.Point(924, 250);
            this.TitleScoreTxt.Name = "TitleScoreTxt";
            this.TitleScoreTxt.ReadOnly = true;
            this.TitleScoreTxt.Size = new System.Drawing.Size(87, 20);
            this.TitleScoreTxt.TabIndex = 10;
            // 
            // AuthorScoreTxt
            // 
            this.AuthorScoreTxt.Location = new System.Drawing.Point(924, 348);
            this.AuthorScoreTxt.Name = "AuthorScoreTxt";
            this.AuthorScoreTxt.ReadOnly = true;
            this.AuthorScoreTxt.Size = new System.Drawing.Size(87, 20);
            this.AuthorScoreTxt.TabIndex = 11;
            // 
            // FinalScoreTxt
            // 
            this.FinalScoreTxt.Location = new System.Drawing.Point(924, 431);
            this.FinalScoreTxt.Name = "FinalScoreTxt";
            this.FinalScoreTxt.Size = new System.Drawing.Size(87, 20);
            this.FinalScoreTxt.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(924, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Analyse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "URL ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Author";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(921, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "URL Score";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(921, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Title Score";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(921, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Author Score";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(921, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Final Score";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(670, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Grading is split 50% URL, 40% Title and 10% Author.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 136);
            this.panel1.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Location = new System.Drawing.Point(357, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(77, 136);
            this.panel3.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.Location = new System.Drawing.Point(0, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 512);
            this.panel2.TabIndex = 32;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1042, 762);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FinalScoreTxt);
            this.Controls.Add(this.AuthorScoreTxt);
            this.Controls.Add(this.TitleScoreTxt);
            this.Controls.Add(this.AuthorTxt);
            this.Controls.Add(this.TitleTxt);
            this.Controls.Add(this.UrlScoreTxt);
            this.Controls.Add(this.UrlTxt);
            this.Controls.Add(this.AnalyserBtn);
            this.Controls.Add(this.HomeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button AnalyserBtn;
        private System.Windows.Forms.TextBox UrlTxt;
        private System.Windows.Forms.TextBox UrlScoreTxt;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.TextBox AuthorTxt;
        private System.Windows.Forms.TextBox TitleScoreTxt;
        private System.Windows.Forms.TextBox AuthorScoreTxt;
        private System.Windows.Forms.TextBox FinalScoreTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}

