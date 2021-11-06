using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChuckNorrisAPI;

namespace ChuckNorrisAPIFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //This is to wrap the joke around the box incase it ends up being a long joke.
            jokeText.MaximumSize = new Size(400, 0);
            jokeText.AutoSize = true;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            jokeText.Text = "";
            //Allows the user to get a joke from any category no exclusions.
            jokeCombBox.Items.Add("none");
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach (var cat in categories)
            {
                jokeCombBox.Items.Add(cat);
            }
        }

        private async void jokeButton_Click(object sender, EventArgs e)
        {
            //Joke j = await ChuckNorrisClient.GetRandomJoke();
            //jokeText.Text = j.JokeText;
            string excluded = "";
            if (jokeCombBox.SelectedIndex > -1)
            {
                excluded = jokeCombBox.SelectedItem.ToString();
            }
            if(!excluded.Equals("none"))
            {
                Joke j = await ChuckNorrisClient.GetRandomJokeExcludeCategory(excluded);
                jokeText.Text = j.JokeText;
            }
            else
            {
                Joke j = await ChuckNorrisClient.GetRandomJoke();
                jokeText.Text = j.JokeText;
            }
        }
    }
}
