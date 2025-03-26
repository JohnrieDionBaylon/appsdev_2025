namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Draculaura");
            comboBox1.Items.Add("Cleo");
            comboBox1.Items.Add("Frankie");
            comboBox1.Items.Add("Clawdeen");

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vwBtn_Click_Click(object sender, EventArgs e)
        {
            string basePath = @"C:\Users\shanicec\Desktop\Chapter 1\MonsterHigh\";

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Draculaura":
                    pictureBox1.Image = Image.FromFile(basePath + "Draculaura.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Cleo":
                    pictureBox1.Image = Image.FromFile(basePath + "Cleo.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Frankie":
                    pictureBox1.Image = Image.FromFile(basePath + "Frankie.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Clawdeen":
                    pictureBox1.Image = Image.FromFile(basePath + "Clawdeen.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox1.Image = null;
                    break;
            }
        }

        private void clrBtn_Click_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
