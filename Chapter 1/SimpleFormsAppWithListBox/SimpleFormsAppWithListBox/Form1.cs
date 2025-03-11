namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void clear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);

        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text) && listBox.Items.Contains(textBox.Text)) ;
            {
                listBox.Items.Add(textBox.Text);
            }
        }
    }
}
