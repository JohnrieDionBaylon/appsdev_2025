using System.Windows.Forms;

namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] movies = { "The Super Mario Bros. Movie", " Spider-Man: Across the Spider-Verse", "The Wizard of Oz", "The Matrix", "Guardians of the Galaxy Vol. 3", "The Lord of the Rings", "Ang Probinsyano", "The Godfather", "Shrek", "Despicable Me", "Wallace & Gromit", "Puss in Boots", "Tom and Jerry", "The Pursuit of Happyness", "Slumdog Millionaire", "Baby John", "Sing", "Madagascar: Escape 2 Africa", "Newtopia", "Reacher" };

            checkedListBox.Items.AddRange(movies);
            checkedListBox.CheckOnClick = true;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_CLick_Click(object sender, EventArgs e)
        {
            foreach (var movies in checkedListBox.Items)
            {
                bool isSelected = checkedListBox.GetItemChecked(checkedListBox.Items.IndexOf(movies));
                if (isSelected && !listBox.Items.Contains(movies))
                {
                    listBox.Items.Add(movies);
                }
            }
        }

        private void dltBtn_Click_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count >= 1)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }

        private void clrBtn_Click_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

        }
    }
}