using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void firstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string fNameValue = firstName.Text;
            string lastNameValue = lastName.Text;
            MessageBox.Show($"Hello World!{fNameValue}{lastNameValue}", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
