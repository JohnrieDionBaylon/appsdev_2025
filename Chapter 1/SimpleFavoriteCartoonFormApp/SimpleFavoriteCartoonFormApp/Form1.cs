using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;

    namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Rick");
            comboBox1.Items.Add("Morty");
            comboBox1.Items.Add("Summer");
            comboBox1.Items.Add("Beth");
            comboBox1.Items.Add("Jerry");

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            string basePath = @"C:\Users\Public\Documents\picz\";

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Rick":
                    pictureBox1.Image = Image.FromFile(basePath + "Rick.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Morty":
                    pictureBox1.Image = Image.FromFile(basePath + "Morty.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Summer":
                    pictureBox1.Image = Image.FromFile(basePath + "Summer.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Beth":
                    pictureBox1.Image = Image.FromFile(basePath + "Beth.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case "Jerry":
                    pictureBox1.Image = Image.FromFile(basePath + "Jerry.jpg");
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                default:
                    pictureBox1.Image = null;
                    break;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
