namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            genreComboBox.Items.Add("Action");
            genreComboBox.Items.Add("Comedy");
            genreComboBox.Items.Add("Drama");
            genreComboBox.Items.Add("Horror");
            genreComboBox.Items.Add("Sci-Fi");

            movieCheckedListBox.Items.Add("Avengers");
            movieCheckedListBox.Items.Add("Inception");
            movieCheckedListBox.Items.Add("Titanic");
            movieCheckedListBox.Items.Add("The Godfather");
            movieCheckedListBox.Items.Add("Jurassic Park");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void movieCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void favoriteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            while (favoriteListBox.SelectedItems.Count > 0)
            {
                favoriteListBox.Items.Remove(favoriteListBox.SelectedItems[0]);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            favoriteListBox.Items.Clear();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            foreach (var item in movieCheckedListBox.CheckedItems)
            {
                if (!favoriteListBox.Items.Contains(item))
                {
                    favoriteListBox.Items.Add(item);
                }
            }
         }
    }
}
